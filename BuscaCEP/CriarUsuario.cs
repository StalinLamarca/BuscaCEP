using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaCEP
{
    internal class CriarUsuario
    {

        //string conexão banco de dados
        SqlCeConnection conexao = new SqlCeConnection("Data source=" + Variaveis.Db + "; Password=senhasenha;");
        // Objeto para inicializar buscas no sql
        SqlCeDataAdapter adap;

        //string padrão busca dados
        string busca = string.Empty;




        //Metódo encapsulado para receber comandos sql
        public void Executar(string argumentos)
        {

            conexao.Open();
            SqlCeCommand cmd = new SqlCeCommand(argumentos, conexao);
            cmd.ExecuteNonQuery();




            conexao.Close();

        }

        //Metodo para cusultar o  Usuario
        public void Consulta(string nome,string user, string senha)
        {


           

                conexao.Open();

                //busca o usuário correspondente ao txtbox
                string busca2 = "SELECT * FROM [usuarios] where [usuario] like '" + user +"'";
                //preencher campos internos caso houver
                DataTable dt = new DataTable();

                //faz a busca pelo critério da variavel busca no banco de dados
                adap = new SqlCeDataAdapter(busca2, conexao);

                //preenche o datatable
                adap.Fill(dt);

            try
            {
                //valida se o usuário existe
                if (user.ToLower().Equals(Convert.ToString(dt.Rows[0][2]).ToLower()))
                {


                    MessageBox.Show("Nome de usuário ja existe!");
                    return;
                }

            }
            catch (Exception)
            {

                try
                {// se não existir e não houver erros, cria o usuario
                    BancoDados dados = new BancoDados();
                    dados.Executar("INSERT INTO Usuarios (Nome,usuario,senha) VALUES" +
                     " ('" + nome + "','" + user + "','" + senha + "')");
                    Variaveis.sucess = false;
                    MessageBox.Show("Usuário Criado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexao.Close();
                }
                catch (Exception)
                {

                    return;
                }
                
                    





                
            }
               
               

            
        }
    }
}
