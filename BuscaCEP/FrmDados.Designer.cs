namespace BuscaCEP
{
    partial class FrmDados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            mtxtCep = new MaskedTextBox();
            label2 = new Label();
            label3 = new Label();
            txtRua = new Controles.ControlesTextBox();
            txtComplemento = new Controles.ControlesTextBox();
            txtBairro = new Controles.ControlesTextBox();
            label4 = new Label();
            txtCidade = new Controles.ControlesTextBox();
            label5 = new Label();
            txtUF = new Controles.ControlesTextBox();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            btApagar = new Button();
            txtNumero = new Controles.ControlesTextBox();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            btnExportar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 81);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 8;
            label1.Text = "CEP";
            // 
            // mtxtCep
            // 
            mtxtCep.Location = new Point(25, 99);
            mtxtCep.Mask = "00000-000";
            mtxtCep.Name = "mtxtCep";
            mtxtCep.Size = new Size(100, 23);
            mtxtCep.TabIndex = 15;
            mtxtCep.Validating += mtxtCep_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 287);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 11;
            label2.Text = "Logradouro:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 181);
            label3.Name = "label3";
            label3.Size = new Size(144, 15);
            label3.TabIndex = 13;
            label3.Text = "Complemento (opcional):";
            // 
            // txtRua
            // 
            txtRua.Font = new Font("Century Gothic", 12F);
            txtRua.ForeColor = Color.FromArgb(64, 64, 64);
            txtRua.Location = new Point(25, 305);
            txtRua.MaxLength = 50;
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(242, 27);
            txtRua.TabIndex = 14;
            // 
            // txtComplemento
            // 
            txtComplemento.Font = new Font("Century Gothic", 12F);
            txtComplemento.ForeColor = Color.FromArgb(64, 64, 64);
            txtComplemento.Location = new Point(25, 199);
            txtComplemento.MaxLength = 50;
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(242, 27);
            txtComplemento.TabIndex = 9;
            // 
            // txtBairro
            // 
            txtBairro.Font = new Font("Century Gothic", 12F);
            txtBairro.ForeColor = Color.FromArgb(64, 64, 64);
            txtBairro.Location = new Point(25, 254);
            txtBairro.MaxLength = 50;
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(242, 27);
            txtBairro.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 236);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 16;
            label4.Text = "Bairro:";
            // 
            // txtCidade
            // 
            txtCidade.Font = new Font("Century Gothic", 12F);
            txtCidade.ForeColor = Color.FromArgb(64, 64, 64);
            txtCidade.Location = new Point(25, 145);
            txtCidade.MaxLength = 50;
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(242, 27);
            txtCidade.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 127);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 18;
            label5.Text = "Cidade:";
            // 
            // txtUF
            // 
            txtUF.Font = new Font("Century Gothic", 12F);
            txtUF.ForeColor = Color.FromArgb(64, 64, 64);
            txtUF.Location = new Point(289, 145);
            txtUF.MaxLength = 2;
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(65, 27);
            txtUF.TabIndex = 21;
            txtUF.KeyPress += txtUF_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(289, 127);
            label6.Name = "label6";
            label6.Size = new Size(24, 15);
            label6.TabIndex = 20;
            label6.Text = "UF:";
            // 
            // label7
            // 
            label7.BackColor = Color.LightSkyBlue;
            label7.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(1, -3);
            label7.Name = "label7";
            label7.Size = new Size(961, 70);
            label7.TabIndex = 22;
            label7.Text = "CADASTRO:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(912, 0);
            button1.Name = "button1";
            button1.Size = new Size(50, 24);
            button1.TabIndex = 23;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(94, 366);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 24;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += button2_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(437, 366);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(99, 23);
            btnEditar.TabIndex = 25;
            btnEditar.Text = "Editar Dados";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += button3_Click;
            // 
            // btApagar
            // 
            btApagar.Location = new Point(603, 366);
            btApagar.Name = "btApagar";
            btApagar.Size = new Size(111, 23);
            btApagar.TabIndex = 26;
            btApagar.Text = "Apagar dados";
            btApagar.UseVisualStyleBackColor = true;
            btApagar.Click += btApagar_Click;
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Century Gothic", 12F);
            txtNumero.ForeColor = Color.FromArgb(64, 64, 64);
            txtNumero.Location = new Point(289, 199);
            txtNumero.MaxLength = 4;
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(65, 27);
            txtNumero.TabIndex = 28;
            txtNumero.KeyPress += txtNumero_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(289, 181);
            label8.Name = "label8";
            label8.Size = new Size(21, 15);
            label8.TabIndex = 27;
            label8.Text = "N°";
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleRole = AccessibleRole.ScrollBar;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(366, 117);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowCellErrors = false;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new Size(584, 238);
            dataGridView1.TabIndex = 29;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(776, 366);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(118, 23);
            btnExportar.TabIndex = 30;
            btnExportar.Text = "Exportar para Excel";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // FrmDados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(962, 426);
            ControlBox = false;
            Controls.Add(btnExportar);
            Controls.Add(dataGridView1);
            Controls.Add(txtNumero);
            Controls.Add(label8);
            Controls.Add(btApagar);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(txtUF);
            Controls.Add(label6);
            Controls.Add(txtCidade);
            Controls.Add(label5);
            Controls.Add(txtBairro);
            Controls.Add(label4);
            Controls.Add(txtComplemento);
            Controls.Add(txtRua);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(mtxtCep);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "FrmDados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dados";
            Load += FrmDados_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private MaskedTextBox mtxtCep;
        private Label label2;
        private Label label3;
        private Controles.ControlesTextBox txtRua;
        private Controles.ControlesTextBox txtComplemento;
        private Controles.ControlesTextBox txtBairro;
        private Label label4;
        private Controles.ControlesTextBox txtCidade;
        private Label label5;
        private Controles.ControlesTextBox txtUF;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btApagar;
        private Controles.ControlesTextBox txtNumero;
        private Label label8;
        private DataGridView dataGridView1;
        private Button btnExportar;
    }
}