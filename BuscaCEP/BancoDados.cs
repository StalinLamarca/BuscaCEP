using System;
using System.Collections.Generic;
using System.Data.SQLite;
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

        //Metódo encapsulado para receber comandos sql
        public void Executar(string argumentos)
        {
            
            conexao.Open();
            SQLiteCommand cmd = new SQLiteCommand(argumentos, conexao);
            cmd.ExecuteNonQuery();
            
            conexao.Close();
           

            

        }

       

       
     
    }
}
