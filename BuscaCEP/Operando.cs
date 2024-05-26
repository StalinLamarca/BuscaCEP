using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaCEP
{
    public class Operando
    {

      

        //metodo para realizar criação do banco de dados
        public void Criar()
        {
            BancoDados dados = new BancoDados();
            //Checka se existe o banco de dados
            if (!File.Exists(Variaveis.Db))
            {
                //Se não existir, ele cria o "Dados.sdf" no appdataLocal do user
                
                //Cria o banco de dados com a senha "senhasenha" e a criptografa
                SqlCeEngine criar = new SqlCeEngine("Data source="+Variaveis.Db+ "; Password=senhasenha; Encrypt Database=True");
                criar.CreateDatabase();

                
                //cria a tabela "usuários" com campos ID, NOME USUARIO E SENHA
                //ID DE INTEIRO E SE AUTO INCREMENTA
                string valores = "CREATE TABLE [Usuarios]"
                  + "( " +
                  "[ID] INT PRIMARY KEY IDENTITY(1,1), " +
                  "[NOME] nvarchar(100), " +
                  "[USUARIO] nvarchar(20)," +
                  "[SENHA] nvarchar(11))";
                dados.Executar(valores);

              
                //string para inserir o usuario padrão na tabela criada
                dados.Executar("INSERT INTO Usuarios (Nome,usuario,senha) VALUES" +
                     " ('Administrador', 'admin', 'admin1234' )");
               

               
                


                // cria tabela de Endereços
                //a chave ID_USUÁRIO É a chave estrangeira, isso faz ela ter relação com a chave ID da tabeça usuário
                //isso controla o que o usuário pode ver na tabela sendo de acordo com seu ID
                valores = "CREATE TABLE [Enderecos]"
                + "( " +
                "[ID] INT PRIMARY KEY IDENTITY(1,1), " +
                "[CEP] nvarchar(10)," +
                "[LOGRADOURO] nvarchar(50)," +
                "[COMPLEMENTO] nvarchar(30), " +
                "[BAIRRO] nvarchar(50), " +
                "[NUMERO] INT, " +
                "[CIDADE] nvarchar(50), " +
                "[UF] nvarchar(2), " +
                "[ID_USUARIO] int, " +
                "FOREIGN KEY([ID_USUARIO]) REFERENCES Usuarios([ID]));";

                dados.Executar(valores);

              
            }

        }
    }
}