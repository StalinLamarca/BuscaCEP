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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            txtNumero = new Controles.ControlesTextBox();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 127);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 8;
            label1.Text = "CEP";
            // 
            // mtxtCep
            // 
            mtxtCep.Location = new Point(25, 145);
            mtxtCep.Mask = "00000-000";
            mtxtCep.Name = "mtxtCep";
            mtxtCep.Size = new Size(100, 23);
            mtxtCep.TabIndex = 15;
            mtxtCep.Validating += mtxtCep_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 333);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 11;
            label2.Text = "Logradouro:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 227);
            label3.Name = "label3";
            label3.Size = new Size(144, 15);
            label3.TabIndex = 13;
            label3.Text = "Complemento (opcional):";
            // 
            // txtRua
            // 
            txtRua.Font = new Font("Microsoft Sans Serif", 12F);
            txtRua.ForeColor = Color.FromArgb(64, 64, 64);
            txtRua.Location = new Point(25, 351);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(242, 26);
            txtRua.TabIndex = 14;
            // 
            // txtComplemento
            // 
            txtComplemento.Font = new Font("Microsoft Sans Serif", 12F);
            txtComplemento.ForeColor = Color.FromArgb(64, 64, 64);
            txtComplemento.Location = new Point(25, 245);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(242, 26);
            txtComplemento.TabIndex = 9;
            // 
            // txtBairro
            // 
            txtBairro.Font = new Font("Microsoft Sans Serif", 12F);
            txtBairro.ForeColor = Color.FromArgb(64, 64, 64);
            txtBairro.Location = new Point(25, 300);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(242, 26);
            txtBairro.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 282);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 16;
            label4.Text = "Bairro:";
            // 
            // txtCidade
            // 
            txtCidade.Font = new Font("Microsoft Sans Serif", 12F);
            txtCidade.ForeColor = Color.FromArgb(64, 64, 64);
            txtCidade.Location = new Point(25, 191);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(242, 26);
            txtCidade.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 173);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 18;
            label5.Text = "Cidade:";
            // 
            // txtUF
            // 
            txtUF.Font = new Font("Microsoft Sans Serif", 12F);
            txtUF.ForeColor = Color.FromArgb(64, 64, 64);
            txtUF.Location = new Point(289, 191);
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(65, 26);
            txtUF.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(289, 173);
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
            // button2
            // 
            button2.Location = new Point(94, 412);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 24;
            button2.Text = "Salvar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(507, 412);
            button3.Name = "button3";
            button3.Size = new Size(99, 23);
            button3.TabIndex = 25;
            button3.Text = "Editar Dados";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(660, 411);
            button4.Name = "button4";
            button4.Size = new Size(111, 23);
            button4.TabIndex = 26;
            button4.Text = "Apagar dados";
            button4.UseVisualStyleBackColor = true;
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Microsoft Sans Serif", 12F);
            txtNumero.ForeColor = Color.FromArgb(64, 64, 64);
            txtNumero.Location = new Point(289, 245);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(65, 26);
            txtNumero.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(289, 227);
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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(366, 157);
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
            // FrmDados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(962, 483);
            ControlBox = false;
            Controls.Add(dataGridView1);
            Controls.Add(txtNumero);
            Controls.Add(label8);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
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
        private Button button2;
        private Button button3;
        private Button button4;
        private Controles.ControlesTextBox txtNumero;
        private Label label8;
        private DataGridView dataGridView1;
    }
}