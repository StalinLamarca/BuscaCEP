﻿using Cadastro_CEP;
using System;
using System.Collections.Generic;
using System.Data;
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

        public void Consulta(string user,string senha) {
            string busca = "SELECT * FROM [usuarios] where [usuario] like '" + user + "' AND [senha] like '" + senha + "'";

            try
            {
                //realiza a consulta pelos campos usuário e senha
                SQLiteDataAdapter adap = new SQLiteDataAdapter(busca, conexao);
                DataTable tabela = new DataTable();

                //retorna o nome do usuário no Messagebox
                adap.Fill(tabela);
              
                if (senha.Equals(Convert.ToString(tabela.Rows[0][3]))){
                    Variaveis.sucess = true;
                    MessageBox.Show("Bem vindo " + Convert.ToString(tabela.Rows[0][1]), "Login efetuado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                else
                {
                    Variaveis.sucess = false;
                    MessageBox.Show("Usuário ou senha incorretos!","Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                
               


            }
            catch (Exception)
            {
                //se não retornar nada, mostra a mensagem abaixo

                Variaveis.sucess = false;
                MessageBox.Show("Usuário ou senha incorretos!","Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
               
                
            
            



        }




    }
}
