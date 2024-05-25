using BuscaCEP;
using System.Reflection;

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
            operando.Conexao();
        }
    }
}
