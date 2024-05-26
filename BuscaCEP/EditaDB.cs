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
                " WHERE [ENDERECOS].id = " + Variaveis.idSelecionados+"  AND [ENDERECOS].[id_usuario] = "+Variaveis.id;
           












            string Deletar = "DELETE FROM [enderecos] "+
                          "WHERE [enderecos].[ID] ="+ Variaveis.idSelecionados+
                          " AND [enderecos].[id_usuario] ="+ Variaveis.id;

            //valida se o modo edição está ativo
            if (Variaveis.Editar.Equals(Insere))
            {
                manipular.Executar(Insere);
            }
            //valida se o editar está ativo
            else if(Variaveis.Editar.Equals("Update"))
            {
                manipular.Executar(Update);

            }
            else
            {
                //pergunta se quer deletar e pega o resultado
               if(MessageBox.Show("Deseja mesmo deletar essa linha de valores?","Apagar",MessageBoxButtons.YesNo)== DialogResult.No) 
                {
                    return;
                }
                else

                {
                    
                    //se for sim, executa o delete
                    manipular.Executar(Deletar);
                    BancoDados bancoDados = new BancoDados();
                    //limpa a tabela e atualiza
                    Variaveis.dadosCarregados.Clear();
                    bancoDados.FrmDaDOS();
                    MessageBox.Show("Dados deletados com sucesso!");
                   
                   
                    Variaveis.Editar = string.Empty;
                }
               
            }
              
               



        }
    }
}
