using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaCEP
{
    // Classe estática responsável por salvar as váriaveis utilizaveis do programa
    public static class Variaveis
    {

        public static int cep { get; set; }
        public static string nome { get; set; }
        public static string usuario { get; set; }
        public static string senha { get; set; }
        public static int id { get; set; }
        public static int numero { get; set; }
        public static string logradouro { get; set; }
        public static string complemento { get; set; }
        public static string bairro { get; set; }
        public static string cidade { get; set; }
        public static bool sucess = false; 
        public static string uf { get; set; }
        public static string Db  = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Dados.db";


    }
}


