using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaCEP
{
    public partial class CriarLogin : Form
    {
        public CriarLogin()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //fecha o formulário atual
            this.Close();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            CriarUsuario criarUsuario = new CriarUsuario();
            //manda o encapsulamento pra CriarUsuario.cs
            criarUsuario.Consulta(txtNomeUser.Text, txtLogin.Text, txtSenha.Text);
            //após ativar o objeto, limpa o campo senha
            txtSenha.Text = string.Empty;

        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            //imposibilita espaço no login e numeros
            if (char.IsDigit(e.KeyChar) && (e.KeyChar != '.') || (char.IsWhiteSpace(e.KeyChar) || (char.IsSymbol(e.KeyChar))))

            {

                e.Handled = true;

            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            //bloqueia espaço na senha
            if (char.IsWhiteSpace(e.KeyChar))

            {

                e.Handled = true;

            }

        }
    }
}
