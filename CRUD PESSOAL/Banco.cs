using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUD_PESSOAL
{
    internal class Banco
    {
        private string stringConexao =
            "Data Source=localhost; Initial Catalog=Lancamento_Eletiva; User ID=usuario; password=senha;language=Portuguese";

        private SqlConnection cn;

        private void conexao()
        {
            cn = new SqlConnection(stringConexao);
        }

        public SqlConnection abrirConexao()
        {
            try
            {
                conexao();
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir conexão:\n" + ex.Message);
                return null;
            }
        }

        public void fecharConexao()
        {
            try
            {
                if (cn != null && cn.State == ConnectionState.Open)
                    cn.Close();
            }
            catch { }
        }

        // ============================================
        // INSERT, UPDATE, DELETE
        // ============================================
        public bool executarComando(string sql)
        {
            try
            {
                abrirConexao();

                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro SQL (executarComando):\n" + ex.Message);
                return false;
            }
            finally
            {
                fecharConexao();
            }
        }

        // ============================================
        // SELECT
        // ============================================
        public DataTable executarConsulta(string sql)
        {
            try
            {
                abrirConexao();

                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro SQL (executarConsulta):\n" + ex.Message);
                return null;
            }
            finally
            {
                fecharConexao();
            }
        }
    }
}