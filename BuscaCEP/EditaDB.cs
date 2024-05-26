using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaCEP
{
    public class EditaDB

    {
        public void Editar() 
        {
         BancoDados manipular = new BancoDados();

            
            
            //Insere os valores na tabela endereço
            string Insere = "INSERT INTO [enderecos] (CEP,LOGRADOURO,COMPLEMENTO,BAIRRO,NUMERO,CIDADE,UF,ID_USUARIO)" +
               "SELECT " +
               "'" + Variaveis.Cep + "'," +
               " '" + Variaveis.logradouro + "'," +
               " '" + Variaveis.complemento + "', " +
               " '" + Variaveis.bairro + "', " +
               " '" + Variaveis.numero + "', " +
               " '" + Variaveis.cidade + "', " +
               " '" + Variaveis.uf + "',ID " +
               //em referncia a tabela usuarios
               "FROM  USUARIOS " +
               //em referencia ao usuario atual logado
               " WHERE [USUARIO] ='" + Variaveis.nome + "'";

            //atualiza os valores de acordo com o usuario logado
            string Update = "UPDATE [enderecos] SET [CEP]= '" + Variaveis.Cep + "'," +
                "[LOGRADOURO] ='" + Variaveis.logradouro + "'," +
                "[COMPLEMENTO] ='" + Variaveis.complemento + "'," +
                "[BAIRRO] = '" + Variaveis.bairro + "'," +
                "[NUMERO] = '" + Variaveis.numero + "'," +
                "[CIDADE] = '" + Variaveis.cidade + "'," +
                "[UF] = '" + Variaveis.uf + "'" +
                //consulta a id da linha atual + a referncia id do usuario atual logado para atualizar
                 " WHERE [ENDERECOS].id ="+Variaveis.idSelecionados+" AND [ENDERECOS].[id_usuario] = "+Variaveis.id;



            //valida se o modo edição está ativo
            if (!Variaveis.Editar)
            {
                manipular.Executar(Insere);
            }
            else
            {
                manipular.Executar(Update);
                Variaveis.Editar = false;
            }
              
               



        }
    }
}
