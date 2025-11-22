using System.Data;

namespace CRUD_PESSOAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CarregarTabela()
        {
            if (comboFiltroTipo.SelectedItem == null)
                return;

            Banco banco = new Banco();

            string sql = "SELECT * FROM lancamentos WHERE 1=1";

            if (comboFiltroTipo.SelectedItem.ToString() != "Todos")
            {
                sql += $" AND tipoLancamento = '{comboFiltroTipo.SelectedItem}'";
            }

            if (chkFiltroData.Checked)
            {
                DateTime inicio = dtInicio.Value.Date;
                DateTime fim = dtFim.Value.Date;

                sql += $" AND dataLancamento >= '{inicio:yyyy-MM-dd}'";
                sql += $" AND dataLancamento <= '{fim:yyyy-MM-dd}'";
            }

            sql += " ORDER BY idLancamento DESC";

            DataTable dt = banco.executarConsulta(sql);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string descricao = textBox1.Text;
            string valor = textBox2.Text.Replace(',', '.');
            string data = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string tipo = comboBox1.Text;

            string sql = $@"
                INSERT INTO lancamentos (descricaoLancamento, valorLancamento, dataLancamento, tipoLancamento)
                VALUES ('{descricao}', {valor}, '{data}', '{tipo}')
            ";

            Banco banco = new Banco();

            bool ok = banco.executarComando(sql);

            if (ok)
            {
                MessageBox.Show("Lançamento registrado com sucesso!");
                CarregarTabela();
            }
            else
            {
                MessageBox.Show("Erro ao registrar dados!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["idLancamento"].Value.ToString();
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["descricaoLancamento"].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["valorLancamento"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["dataLancamento"].Value);
                comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["tipoLancamento"].Value.ToString();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Selecione um lançamento primeiro.");
                return;
            }

            if (MessageBox.Show("Tem certeza que deseja excluir este lançamento?",
                "Confirmar", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            string sql = $"DELETE FROM lancamentos WHERE idLancamento = {textBox3.Text}";

            Banco banco = new Banco();

            bool ok = banco.executarComando(sql);

            if (ok)
            {
                MessageBox.Show("Lançamento excluído com sucesso!");
                CarregarTabela();

                textBox3.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarTabela();
            dataGridView1.AllowUserToAddRows = false;

            comboFiltroTipo.Items.Add("Todos");
            comboFiltroTipo.Items.Add("Entrada");
            comboFiltroTipo.Items.Add("Saída");
            comboFiltroTipo.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Selecione um lançamento para editar.");
                return;
            }

            string descricao = textBox1.Text;
            string valor = textBox2.Text.Replace(',', '.');
            string data = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string tipo = comboBox1.Text;

            string sql = $@"
        UPDATE lancamentos SET
            descricaoLancamento = '{descricao}',
            valorLancamento = {valor},
            dataLancamento = '{data}',
            tipoLancamento = '{tipo}'
        WHERE idLancamento = {textBox3.Text}
    ";

            Banco banco = new Banco();

            bool ok = banco.executarComando(sql);

            if (ok)
            {
                MessageBox.Show("Lançamento atualizado com sucesso!");
                CarregarTabela();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar registro.");
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CarregarTabela();
        }

        private void comboFiltroTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarTabela();
        }
    }
}
