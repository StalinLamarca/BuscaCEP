using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlServerCe;
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

            Variaveis.dadosCarregados.Clear();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            //limpa o id do usuario ao fechar o form
            Variaveis.id = 0;
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


            SqlCeConnection conexao = new SqlCeConnection("Data source =" + Variaveis.Db + "; password=senhasenha;");
            // Objeto para inicializar buscas no sql

            //instancia objeto da Classe data
            BancoDados data = new BancoDados();
            //executa o metodo para carregar dados no datagridview



            data.FrmDaDOS();

            //joga dados carregados da variavel para o dataGrid
            dataGridView1.DataSource = Variaveis.dadosCarregados;
            //oculta a coluna ID pra ficar bonitinho pro usuário
            try
            {
                dataGridView1.Columns[0].Visible = false;
                
            }
            catch (Exception)
            {
               

            }





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
                if (vazio.Text.Equals(string.Empty) || mtxtCep.Text.Equals(string.Empty))
                {
                    //retorna essa mensagem e o campo vazio fica em foco
                    MessageBox.Show("Campos vazios, gentileza verificar!");
                    vazio.Focus();

                    return;
                }
                else
                {

                }

            }
            Variaveis.dadosCarregados.Clear();
            if (Variaveis.Editar.Equals(string.Empty))
            {
                Variaveis.Editar = "Novo";
            }

            //pega os dados e joga nas variaveis pra salvar no sql
            Variaveis.Cep = mtxtCep.Text;
            Variaveis.logradouro = txtRua.Text;
            Variaveis.complemento = txtComplemento.Text;
            Variaveis.bairro = txtBairro.Text;
            Variaveis.numero = Convert.ToInt32(txtNumero.Text);
            Variaveis.cidade = txtCidade.Text;
            Variaveis.uf = txtUF.Text;

            //instancia do objeto edita da classe EditaDB, pega todos valores e injeta no sql
            EditaDB edita = new EditaDB();
            edita.Editar();

            //apos injetar o dados, o metodo abaixo atualiza a planilha
            BancoDados bancoDados = new BancoDados();
            bancoDados.FrmDaDOS();
            MessageBox.Show("Dados modificados com sucesso!");
            Variaveis.Editar = string.Empty;
            //após salvar, limpa todos campos para o usuario não duplicar,fazer edições excessivas
            foreach (TextBox textBox in Controls.OfType<TextBox>())
            {
                textBox.Text = string.Empty;
                mtxtCep.Text = string.Empty;
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            //habilita somente a edição no metódo EditaDB;
            Variaveis.Editar = "Update";

            // pega o ID da tabela em que o usuário está selecionado
            //por questão de estética, o valor está oculto
            try
            {
                //valida se há dados na tabela, caso não tenha, exibe a mensagem e retorna o bloco de código
                Variaveis.idSelecionados = Convert.ToInt16(dataGridView1.SelectedCells[0].Value.ToString());
            }
            catch (Exception)
            {

                MessageBox.Show("Não há dados a serem modificados!");
                return;
            }



            //pega todos valores das linhas selecionadas e joga no data grid
            mtxtCep.Text = dataGridView1.SelectedCells[1].Value.ToString();
            txtRua.Text = dataGridView1.SelectedCells[2].Value.ToString();
            txtComplemento.Text = dataGridView1.SelectedCells[3].Value.ToString();
            txtBairro.Text = dataGridView1.SelectedCells[4].Value.ToString();
            txtNumero.Text = dataGridView1.SelectedCells[5].Value.ToString();
            txtCidade.Text = dataGridView1.SelectedCells[6].Value.ToString();
            txtUF.Text = dataGridView1.SelectedCells[7].Value.ToString();

        }

        private void btApagar_Click(object sender, EventArgs e)
        {
            //habilita somente o deletar no metódo EditaDB;
            Variaveis.Editar = "Deletar";
            EditaDB edita = new EditaDB();
            try
            {
                //valida se há dados na tabela, caso não tenha, exibe a mensagem e retorna o bloco de código
                Variaveis.idSelecionados = Convert.ToInt16(dataGridView1.SelectedCells[0].Value.ToString());
            }
            catch (Exception)
            {

                MessageBox.Show("Não há dados a serem modificados!");
                //havia um bug que mesmo com a planilha vazia, ele aparecia o Messagebox questionando se deseja deletar dados
                Variaveis.Editar = string.Empty;
                return;
            }


            edita.Editar();
            Variaveis.Editar = string.Empty;

        }
        //botão responsável por exportar dados para o Excel
        private void btnExportar_Click(object sender, EventArgs e)
        {


            // carrega dados da classe Exportar.cs
            Exportar exportar = new Exportar();

            exportar.Dialog(dataGridView1);


        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            //só permite que seja digitado números no campo N°
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))

            {
                //se a condição for verdadeira,segura o evento da tecla e não digita
                e.Handled = true;

            }
        }

        private void txtUF_KeyPress(object sender, KeyPressEventArgs e)
        {
            //só permite digitar texto no campo UF
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                //se a condição for verdadeira,segura o evento da tecla e não digita
                e.Handled = true;
            }

              
               
                
                
        }
    }
}
