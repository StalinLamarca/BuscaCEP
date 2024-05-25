using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViaCep;

namespace BuscaCEP
{
    public partial class FrmDados : Form
    {
        public FrmDados()
        {
            InitializeComponent();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDados_Load(object sender, EventArgs e)
        {

            //instancia objeto da Classe data
            BancoDados data = new BancoDados();
            //executa o metodo para carregar dados no datagridview
            data.FrmDaDOS();
        }

       
      
        //evento para validação  maskedtextbox sair de foco pelo usuário
        //caso o usuário digite a informação incorreta, ele não sai do foco
        private void mtxtCep_Validating(object sender, CancelEventArgs e)
        {

            try
            {
                //instancia objeto da api VIACEP para pesquisa de items
                ViaCepClient client = new ViaCepClient();

                //realiza a busca do cep digitado do usuário na maskedtextbox
                ViaCepResult s = client.Search(mtxtCep.Text);

                //retorna a busca nos campos correspondentes do FormDados
                txtRua.Text = s.Street.ToString();
                txtBairro.Text = s.Neighborhood.ToString();
                txtComplemento.Text = s.Complement.ToString();
                txtCidade.Text = s.City.ToString();
                txtUF.Text = s.StateInitials.ToString();
            }
            catch (Exception)
            {

                e.Cancel = true;
                MessageBox.Show("Gentileza verificar CEP!","CEP Não Localizado!",MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
           
        }
    }
}
