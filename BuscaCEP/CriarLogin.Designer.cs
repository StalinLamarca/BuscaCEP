namespace BuscaCEP
{
    partial class CriarLogin
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
            label2 = new Label();
            txtNomeUser = new Controles.ControlesTextBox();
            txtLogin = new Controles.ControlesTextBox();
            label3 = new Label();
            txtSenha = new Controles.ControlesTextBox();
            label4 = new Label();
            btnCriar = new Button();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.LightSkyBlue;
            label1.Font = new Font("Arial", 26.25F, FontStyle.Bold);
            label1.Location = new Point(-2, -2);
            label1.Name = "label1";
            label1.Size = new Size(521, 72);
            label1.TabIndex = 0;
            label1.Text = "Criar Usuário:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SteelBlue;
            label2.Location = new Point(109, 87);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // txtNomeUser
            // 
            txtNomeUser.Font = new Font("Century Gothic", 12F);
            txtNomeUser.ForeColor = Color.FromArgb(64, 64, 64);
            txtNomeUser.Location = new Point(109, 105);
            txtNomeUser.MaxLength = 50;
            txtNomeUser.Name = "txtNomeUser";
            txtNomeUser.Size = new Size(288, 27);
            txtNomeUser.TabIndex = 2;
            // 
            // txtLogin
            // 
            txtLogin.Font = new Font("Century Gothic", 12F);
            txtLogin.ForeColor = Color.FromArgb(64, 64, 64);
            txtLogin.Location = new Point(177, 154);
            txtLogin.MaxLength = 15;
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(132, 27);
            txtLogin.TabIndex = 4;
            txtLogin.KeyPress += txtLogin_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SteelBlue;
            label3.Location = new Point(177, 136);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 3;
            label3.Text = "Login:";
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Century Gothic", 12F);
            txtSenha.ForeColor = Color.FromArgb(64, 64, 64);
            txtSenha.Location = new Point(177, 202);
            txtSenha.MaxLength = 11;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(132, 27);
            txtSenha.TabIndex = 6;
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.KeyPress += txtSenha_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SteelBlue;
            label4.Location = new Point(177, 184);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 5;
            label4.Text = "Senha:";
            // 
            // btnCriar
            // 
            btnCriar.BackgroundImageLayout = ImageLayout.None;
            btnCriar.FlatStyle = FlatStyle.Popup;
            btnCriar.ForeColor = Color.Black;
            btnCriar.Location = new Point(199, 244);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(75, 23);
            btnCriar.TabIndex = 7;
            btnCriar.Text = "Criar";
            btnCriar.UseVisualStyleBackColor = true;
            btnCriar.Click += btnCriar_Click;
            // 
            // btnFechar
            // 
            btnFechar.FlatStyle = FlatStyle.Popup;
            btnFechar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = Color.Red;
            btnFechar.Location = new Point(469, -2);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(50, 24);
            btnFechar.TabIndex = 24;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // CriarLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(517, 289);
            Controls.Add(btnFechar);
            Controls.Add(btnCriar);
            Controls.Add(txtSenha);
            Controls.Add(label4);
            Controls.Add(txtLogin);
            Controls.Add(label3);
            Controls.Add(txtNomeUser);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CriarLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CriarLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Controles.ControlesTextBox txtNomeUser;
        private Controles.ControlesTextBox txtLogin;
        private Label label3;
        private Controles.ControlesTextBox txtSenha;
        private Label label4;
        private Button btnCriar;
        private Button btnFechar;
    }
}