using BuscaCEP;
using System.Reflection;
using System.Threading;

namespace Cadastro_CEP
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            BancoDados validaLogin = new BancoDados();
            //Joga os valores pro encapsulamento da classe BancoDados
            validaLogin.Consulta(txtNomeUser.Text, txtSenhaUser.Text);
            //esvazia o campo senha
            txtSenhaUser.Text = string.Empty;
            if (Variaveis.sucess)
            {//se tiver sucsso no logon, abre o frame de cadastro/consulta
               
                FrmDados dados = new FrmDados();
                this.Hide();
                dados.ShowDialog();

                this.Show();

            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Fecha a aplicação ao clicar no "X" do frame login
            this.Close();

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //instancia operando para verificar se existe o banco de dados e se caso não existir, cria um novo com as tabelas.
            Operando operando = new Operando();
            operando.Criar();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //abre o frame de criar login
            CriarLogin criar = new CriarLogin();
            criar.ShowDialog();

        }
    }
}
