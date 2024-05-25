namespace Cadastro_CEP
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtNomeUser = new TextBox();
            txtSenhaUser = new TextBox();
            label3 = new Label();
            btnEntrar = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.LightSkyBlue;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Yu Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(531, 60);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(24, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 180);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(311, 100);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome de Usuário:";
            // 
            // txtNomeUser
            // 
            txtNomeUser.BackColor = Color.White;
            txtNomeUser.ForeColor = Color.Black;
            txtNomeUser.Location = new Point(294, 118);
            txtNomeUser.MaxLength = 12;
            txtNomeUser.Name = "txtNomeUser";
            txtNomeUser.Size = new Size(137, 23);
            txtNomeUser.TabIndex = 1;
            // 
            // txtSenhaUser
            // 
            txtSenhaUser.Location = new Point(294, 171);
            txtSenhaUser.MaxLength = 12;
            txtSenhaUser.Name = "txtSenhaUser";
            txtSenhaUser.Size = new Size(137, 23);
            txtSenhaUser.TabIndex = 2;
            txtSenhaUser.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(336, 153);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 4;
            label3.Text = "Senha:";
            // 
            // btnEntrar
            // 
            btnEntrar.FlatStyle = FlatStyle.Popup;
            btnEntrar.Location = new Point(322, 200);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 3;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.Red;
            button1.Location = new Point(495, 0);
            button1.Name = "button1";
            button1.Size = new Size(36, 21);
            button1.TabIndex = 5;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(528, 280);
            Controls.Add(button1);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenhaUser);
            Controls.Add(label3);
            Controls.Add(txtNomeUser);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtNomeUser;
        private TextBox txtSenhaUser;
        private Label label3;
        private Button btnEntrar;
        private Button button1;
    }
}
