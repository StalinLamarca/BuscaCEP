using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Diagnostics.Eventing.Reader;
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
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            //desabilita os cabeçalhos contar como index
            dataGridView1.EnableHeadersVisualStyles = false;


            SQLiteConnection conexao = new SQLiteConnection("Data source =" + Variaveis.Db + "; Version = 3;");
            // Objeto para inicializar buscas no sql

            //instancia objeto da Classe data
            BancoDados data = new BancoDados();
            //executa o metodo para carregar dados no datagridview



            data.FrmDaDOS();

            //joga dados carregados da variavel para o dataGrid
            dataGridView1.DataSource = Variaveis.dadosCarregados;




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
                MessageBox.Show("Gentileza verificar CEP!", "CEP Não Localizado!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //para cada caixa de texto no formulario atual (dados)
            foreach (TextBox vazio in Controls.OfType<TextBox>())
            {
                //se algum estivar vazio
                if (vazio.Text.Equals(string.Empty))
                {
                    //retorna essa mensagem e o campo vazio fica em foco
                    MessageBox.Show("Campos vazios, gentileza verificar!");
                    vazio.Focus();

                    return;
                }

            }



            //pega os dados e joga nas variaveis pra salvar no sql
            Variaveis.cep = mtxtCep.Text;
            Variaveis.logradouro = txtRua.Text;
            Variaveis.complemento = txtComplemento.Text;
            Variaveis.bairro = txtBairro.Text;
            Variaveis.numero = Convert.ToInt16(txtNumero.Text);
            Variaveis.cidade = txtCidade.Text;
            Variaveis.uf = txtUF.Text;

            //instancia do objeto edita da classe EditaDB, pega todos valores e injeta no sql
            EditaDB edita = new EditaDB();
            edita.Editar();

            //apos injetar o dados, o metodo abaixo atualiza a planilha
            BancoDados bancoDados = new BancoDados();
            bancoDados.FrmDaDOS();
            MessageBox.Show("Dados Salvos com sucesso!");



        }

        
    }
}
