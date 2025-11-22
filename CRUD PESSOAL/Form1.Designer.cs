namespace CRUD_PESSOAL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            label4 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            button2 = new Button();
            textBox3 = new TextBox();
            btnExcluir = new Button();
            comboFiltroTipo = new ComboBox();
            label6 = new Label();
            dtFim = new DateTimePicker();
            dtInicio = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            btnFiltrar = new Button();
            chkFiltroData = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 70);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(229, 25);
            label1.TabIndex = 0;
            label1.Text = "Descrição do Lançamento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 344);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(186, 25);
            label2.TabIndex = 1;
            label2.Text = "Data do Lançamento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 435);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(184, 25);
            label3.TabIndex = 2;
            label3.Text = "Tipo do Lançamento";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(42, 109);
            textBox1.Margin = new Padding(4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(322, 117);
            textBox1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(45, 384);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(319, 29);
            dateTimePicker1.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Entrada", "Saída" });
            comboBox1.Location = new Point(45, 475);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(319, 29);
            comboBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(45, 248);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(191, 25);
            label4.TabIndex = 6;
            label4.Text = "Valor do Lançamento";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(42, 287);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(322, 29);
            textBox2.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(45, 543);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(100, 34);
            button1.TabIndex = 8;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(462, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(546, 395);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(339, 25);
            label5.Name = "label5";
            label5.Size = new Size(249, 37);
            label5.TabIndex = 10;
            label5.Text = "Controle Financeiro";
            // 
            // button2
            // 
            button2.Location = new Point(152, 543);
            button2.Name = "button2";
            button2.Size = new Size(116, 34);
            button2.TabIndex = 11;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(45, 25);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(100, 29);
            textBox3.TabIndex = 14;
            textBox3.Visible = false;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(274, 543);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(90, 34);
            btnExcluir.TabIndex = 15;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // comboFiltroTipo
            // 
            comboFiltroTipo.FormattingEnabled = true;
            comboFiltroTipo.Location = new Point(841, 510);
            comboFiltroTipo.Name = "comboFiltroTipo";
            comboFiltroTipo.Size = new Size(167, 29);
            comboFiltroTipo.TabIndex = 16;
            comboFiltroTipo.SelectedIndexChanged += comboFiltroTipo_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(747, 513);
            label6.Name = "label6";
            label6.Size = new Size(88, 21);
            label6.TabIndex = 17;
            label6.Text = "Filtrar Tipo:";
            // 
            // dtFim
            // 
            dtFim.Location = new Point(673, 614);
            dtFim.Name = "dtFim";
            dtFim.Size = new Size(335, 29);
            dtFim.TabIndex = 18;
            // 
            // dtInicio
            // 
            dtInicio.Location = new Point(673, 579);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(335, 29);
            dtInicio.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(581, 585);
            label7.Name = "label7";
            label7.Size = new Size(86, 21);
            label7.TabIndex = 20;
            label7.Text = "Data Inicial";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(581, 620);
            label8.Name = "label8";
            label8.Size = new Size(79, 21);
            label8.TabIndex = 21;
            label8.Text = "Data Final";
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(673, 649);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(335, 35);
            btnFiltrar.TabIndex = 22;
            btnFiltrar.Text = "Filtrar Período";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // chkFiltroData
            // 
            chkFiltroData.AutoSize = true;
            chkFiltroData.Location = new Point(874, 545);
            chkFiltroData.Name = "chkFiltroData";
            chkFiltroData.Size = new Size(134, 25);
            chkFiltroData.TabIndex = 23;
            chkFiltroData.Text = "Filtrar Período?";
            chkFiltroData.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 696);
            Controls.Add(chkFiltroData);
            Controls.Add(btnFiltrar);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dtInicio);
            Controls.Add(dtFim);
            Controls.Add(label6);
            Controls.Add(comboFiltroTipo);
            Controls.Add(btnExcluir);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox textBox2;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label5;
        private Button button2;
        private TextBox textBox3;
        private Button btnExcluir;
        private ComboBox comboFiltroTipo;
        private Label label6;
        private DateTimePicker dtFim;
        private DateTimePicker dtInicio;
        private Label label7;
        private Label label8;
        private Button btnFiltrar;
        private CheckBox chkFiltroData;
    }
}
