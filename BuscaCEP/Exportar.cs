using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaCEP
{
   public class Exportar
    {
       
        //metodo para chamar o dialog box no evento do botão "Exportar para excel"
        public void Dialog()
        {
            SaveFileDialog dialogo = new SaveFileDialog();

            //salva apenas em .CSV
            dialogo.Filter = "Arquivos Excel (*.CSV)|*CSV";
            
            //consulta se o usuário escolheu o caminho e nome para salvar
            if(DialogResult.OK == dialogo.ShowDialog())
            {
               //Objeto para pegar o diretório do arquivo e nome + .CSV
              StreamWriter salvarArq = new StreamWriter(dialogo.FileName+".csv");

                // salva o arquivo no direório com nome selecionado
                salvarArq.Write(salvarArq.ToString());
            }
            
        }
    }
}
