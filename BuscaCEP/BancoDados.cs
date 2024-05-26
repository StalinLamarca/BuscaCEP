using Cadastro_CEP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaCEP
{
    public class BancoDados
    {


        //string conexão banco de dados
        SQLiteConnection conexao = new SQLiteConnection("Data source =" + Variaveis.Db + "; Version = 3;");
        // Objeto para inicializar buscas no sql
        SQLiteDataAdapter adap;

        //string padrão busca dados
        string busca= string.Empty;




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
             
                conexao.Open();

                //busca o usuário e senha correspondente ao txtbox
              string  busca2 = "SELECT * FROM [usuarios] where [usuario] like '" + user + "' AND [senha] like '" + senha + "'";
                //preencher campos internos caso houver
                DataTable dt = new DataTable();

                //faz a busca pelo critério da variavel busca no banco de dados
                adap = new SQLiteDataAdapter(busca2, conexao);

                //preenche o datatable
                adap.Fill(dt);


                //valida se a senha  digitada corresponde a senha digitada em case sensistive
                if (senha.Equals(Convert.ToString(dt.Rows[0][3])))
                {


                    Variaveis.sucess = true;
                    Variaveis.nome = Convert.ToString(dt.Rows[0][2]);
                    Variaveis.id = Convert.ToInt16(dt.Rows[0][0]);

                    MessageBox.Show("Bem vindo " + Convert.ToString(dt.Rows[0][1]), "Login bem sucedido", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    conexao.Close();
                }
                else
                {
                    Variaveis.sucess = false;
                    MessageBox.Show("Usuário ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conexao.Close();
                    return;




                }



            }
            catch (Exception)
            {
                //se não retornar nada, mostra a mensagem abaixo
                
                Variaveis.sucess = false;
                MessageBox.Show("Usuário ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conexao.Close();
                return;
            }









        }
    
        //metodo para consultar dados da database
        public void FrmDaDOS()
        {
            
            try
            {
                

               conexao.Open();

                 busca= "SELECT [ID], [CEP],[LOGRADOURO],[COMPLEMENTO],[BAIRRO],[NUMERO], [CIDADE],[UF] FROM [ENDERECOS] WHERE [ID_USUARIO] = '" + Variaveis.id+ "' ORDER BY [ID]";
              
                adap = new SQLiteDataAdapter(busca, conexao);

              
                adap.Fill(Variaveis.dadosCarregados);

                //preenche o datatable


                conexao.Close();
               
            }
            catch (Exception)
            {
                MessageBox.Show("Não há dados na planilha", "Sem dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
                return;
            }
               

            
           

                
               
               
            

          
           
        }
       

    }
}