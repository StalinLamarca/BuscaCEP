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
            maskedTextBox1 = new MaskedTextBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            controlesTextBox1 = new Controles.ControlesTextBox();
            controlesTextBox2 = new Controles.ControlesTextBox();
            controlesTextBox3 = new Controles.ControlesTextBox();
            label4 = new Label();
            controlesTextBox4 = new Controles.ControlesTextBox();
            label5 = new Label();
            controlesTextBox5 = new Controles.ControlesTextBox();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
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
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(25, 145);
            maskedTextBox1.Mask = "00000-000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.SteelBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(364, 144);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(586, 234);
            dataGridView1.TabIndex = 10;
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
            // controlesTextBox1
            // 
            controlesTextBox1.Font = new Font("Microsoft Sans Serif", 12F);
            controlesTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            controlesTextBox1.Location = new Point(25, 351);
            controlesTextBox1.Name = "controlesTextBox1";
            controlesTextBox1.Size = new Size(242, 26);
            controlesTextBox1.TabIndex = 14;
            // 
            // controlesTextBox2
            // 
            controlesTextBox2.Font = new Font("Microsoft Sans Serif", 12F);
            controlesTextBox2.ForeColor = Color.FromArgb(64, 64, 64);
            controlesTextBox2.Location = new Point(25, 245);
            controlesTextBox2.Name = "controlesTextBox2";
            controlesTextBox2.Size = new Size(242, 26);
            controlesTextBox2.TabIndex = 15;
            // 
            // controlesTextBox3
            // 
            controlesTextBox3.Font = new Font("Microsoft Sans Serif", 12F);
            controlesTextBox3.ForeColor = Color.FromArgb(64, 64, 64);
            controlesTextBox3.Location = new Point(25, 300);
            controlesTextBox3.Name = "controlesTextBox3";
            controlesTextBox3.Size = new Size(242, 26);
            controlesTextBox3.TabIndex = 17;
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
            // controlesTextBox4
            // 
            controlesTextBox4.Font = new Font("Microsoft Sans Serif", 12F);
            controlesTextBox4.ForeColor = Color.FromArgb(64, 64, 64);
            controlesTextBox4.Location = new Point(25, 191);
            controlesTextBox4.Name = "controlesTextBox4";
            controlesTextBox4.Size = new Size(242, 26);
            controlesTextBox4.TabIndex = 19;
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
            // controlesTextBox5
            // 
            controlesTextBox5.Font = new Font("Microsoft Sans Serif", 12F);
            controlesTextBox5.ForeColor = Color.FromArgb(64, 64, 64);
            controlesTextBox5.Location = new Point(289, 191);
            controlesTextBox5.Name = "controlesTextBox5";
            controlesTextBox5.Size = new Size(65, 26);
            controlesTextBox5.TabIndex = 21;
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
            // 
            // button3
            // 
            button3.Location = new Point(507, 412);
            button3.Name = "button3";
            button3.Size = new Size(99, 23);
            button3.TabIndex = 25;
            button3.Text = "Editar Dados";
            button3.UseVisualStyleBackColor = true;
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
            // FrmDados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(962, 483);
            ControlBox = false;
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(controlesTextBox5);
            Controls.Add(label6);
            Controls.Add(controlesTextBox4);
            Controls.Add(label5);
            Controls.Add(controlesTextBox3);
            Controls.Add(label4);
            Controls.Add(controlesTextBox2);
            Controls.Add(controlesTextBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(maskedTextBox1);
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
        private MaskedTextBox maskedTextBox1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Controles.ControlesTextBox controlesTextBox1;
        private Controles.ControlesTextBox controlesTextBox2;
        private Controles.ControlesTextBox controlesTextBox3;
        private Label label4;
        private Controles.ControlesTextBox controlesTextBox4;
        private Label label5;
        private Controles.ControlesTextBox controlesTextBox5;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}