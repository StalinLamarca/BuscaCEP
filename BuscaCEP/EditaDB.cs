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
               "'" + Variaveis.cep + "'," +
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
            manipular.Executar(Insere);

           


        }
    }
}
