using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaCEP
{
    public class Operando
    {

      

        //metodo para realizar conexão ao banco de dados
        public void Conexao()
        {
            BancoDados dados = new BancoDados();
            //Checka se existe o banco de dados
            if (!File.Exists(Variaveis.Db))
            {
                //Se não existir, ele cria o "Dados.db" no appdata do user
                SQLiteConnection.CreateFile(Variaveis.Db);

                
                //cria a tabela "usuários" com campos ID, NOME USUARIO E SENHA
                string valores = "CREATE TABLE Usuarios"
                  + "( " +
                  "[ID] INTEGER PRIMARY KEY AUTOINCREMENT, " +
                  "[NOME] varchar(50), " +
                  "[USUARIO] varchar(1)," +
                  "[SENHA] varchar(11))";
                dados.Executar(valores);

              
                //string para inserir o usuario adm na tabela criada
                dados.Executar("INSERT INTO Usuarios (Nome,usuario,senha) VALUES" +
                     " ('Administrador', 'admin', 'admin1234' )");
               

                //senha de criptografia tabela
                dados.Executar( "PRAGMA KEY = 'senha1234*'");
                


                // cria tabela de Endereços
                valores = "CREATE TABLE Enderecos"
                + "( " +
                "[ID] INTEGER PRIMARY KEY AUTOINCREMENT, " +
                "[CEP] varchar(50)," +
                "[LOGRADOURO] varchar(12)," +
                "[complemento] varchar(11), " +
                "[BAIRRO] varchar(11), " +
                "[CIDADE]varchar(11), " +
                "[UF] varchar(11), " +
                "[ID_USUARIO] varchar(11), FOREIGN KEY([ID_USUARIO]) REFERENCES enderecos(ID)); ";

                dados.Executar(valores);

              
            }

        }
    }
}