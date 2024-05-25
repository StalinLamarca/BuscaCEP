using Cadastro_CEP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaCEP
{
    public class BancoDados
    {

       
        //string conexão banco de dados
        SQLiteConnection conexao = new SQLiteConnection("Data source =" + Variaveis.Db + "; Version = 3;");
        // Objeto para inicializar buscas no sql
        SQLiteDataAdapter adap;


        string busca = string.Empty;




        //Metódo encapsulado para receber comandos sql
        public void Executar(string argumentos)
        {
            
            conexao.Open();
            SQLiteCommand cmd = new SQLiteCommand(argumentos, conexao);
            cmd.ExecuteNonQuery();
            
            conexao.Close();

          
            

        }

        //Metodo para cusultar Usuario e senha no banco de dados
        public void Consulta(string user, string senha)
        {


            try
            {


               
                    //busca o usuário e senha correspondente ao txtbox
                    busca = "SELECT * FROM [usuarios] where [usuario] like '" + user + "' AND [senha] like '" + senha + "'";

                    //faz a busca pelo critério da variavel busca no banco de dados
                    adap = new SQLiteDataAdapter(busca, conexao);

                    //preenche o datatable
                    adap.Fill(Variaveis.dadosCarregados);


                    //valida se a senha  digitada corresponde a senha digitada em case sensistive
                    if (senha.Equals(Convert.ToString(Variaveis.dadosCarregados.Rows[0][3])))
                    {


                        Variaveis.sucess = true;
                        MessageBox.Show("Bem vindo " + Convert.ToString(Variaveis.dadosCarregados.Rows[0][1]), "Login efetuado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    } else
                     {
                        Variaveis.sucess = false;
                        MessageBox.Show("Usuário ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                      }

                
            }




            catch (Exception)
            {
                //se não retornar nada, mostra a mensagem abaixo

                Variaveis.sucess = false;
                MessageBox.Show("Usuário ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }









        }

        //metodo para consultar dados da database
        public void FrmDaDOS()
        {
            try
            {
                string busca = "SELECT [ENDERECOS] , [CEP],[LOGRADOURO],[COMPLEMENTO],[BAIRRO],[CIDADE],[UF],[ID_USUARIO]";
                adap = new SQLiteDataAdapter(busca, conexao);

                //preenche o datatable
                adap.Fill(Variaveis.dadosCarregados);
            }
            catch (Exception)
            {

                MessageBox.Show("Não há dados na planilha","Sem dados",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

          
           
        }

    }
}
