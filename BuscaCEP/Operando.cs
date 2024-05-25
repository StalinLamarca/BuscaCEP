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

        //string de apontamento para o direótio do banco de dados, por padrão essa linha pega o %appdata% do usuário atual

        string con = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Dados.db";


        //metodo para realizar conexão ao banco de dados
        public void Conexao()
        {

            //Checka se existe o banco de dados
            if (!File.Exists(con))
            {
                //Se não existir, ele cria o "Dados.db" no appdata do user
                SQLiteConnection.CreateFile(con);

                //Após criar, conecta ao banco e abre a conexão (O "data source" é um comando padrão para apontar para o sql de onde ele deve carregar o banco de dados
                SQLiteConnection conexao = new SQLiteConnection("Data source =" + con + "; Version = 3;");

                conexao.Open();

                //cria a tabela "usuários" com campos ID, NOME USUARIO E SENHA
                string valores = "CREATE TABLE Usuarios"
                  + "( " +
                  "[ID] INTEGER PRIMARY KEY AUTOINCREMENT, " +
                  "[NOME] varchar(50), " +
                  "[USUARIO] varchar(1)," +
                  "[SENHA] varchar(11))";

                SQLiteCommand cmd = new SQLiteCommand(valores, conexao);
                //executa o comando de criar a tabela
                cmd.ExecuteNonQuery();
                //string para inserir o usuario adm na tabela criada
                cmd.CommandText = "INSERT INTO Usuarios (Nome,usuario,senha) VALUES" +
                     " ('Administrador', 'admin', 'admin1234' )";
                cmd.ExecuteNonQuery();

                //senha da tabela
                cmd.CommandText = "PRAGMA KEY = 'senha1234*'";
                // cmd.ExecuteNonQuery();


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

                cmd.CommandText = valores;

                cmd.ExecuteNonQuery();
                //fechar a conexão após executar os comandos
                conexao.Close();
                //livrar a memória
                conexao.Dispose();

            }

        }
    }
}