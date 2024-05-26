using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BuscaCEP
{
    public class Exportar
    {
         //metodo para chamar o dialog box no evento do botão "Exportar para excel"
        public void Dialog(DataGridView tabela)
        {
            
            //inicializa o objeto para abrir aquela caixa de dialogo padrão do windows
            SaveFileDialog dialogo = new SaveFileDialog();

            //salva apenas em .CSV
            dialogo.Filter = "Arquivos Excel (*.CSV)|*CSV";
            
            //consulta se o usuário escolheu o caminho e nome para salvar
            if(DialogResult.OK == dialogo.ShowDialog())
            {
                try
                {
                    //Objeto para pegar o diretório do arquivo e nome + .CSV
                    StreamWriter salvarArq = new StreamWriter(dialogo.FileName + ".csv");
                    
                    //Varre todas tabelas da coluna atpe chegar ao limite
                    for (int i = 0; i < tabela.Columns.Count; i++)
                    {
                        //escreve todos cabeçalhos e delimita por virgula
                        salvarArq.Write(tabela.Columns[i].HeaderText);
                       salvarArq.Write(",");
                    }
                    //após salvar oo cabeçalhos, cria uma linha para preencher as linhas
                    salvarArq.Write(salvarArq.NewLine,Encoding.UTF8);

                    foreach (DataGridViewRow dr in tabela.Rows)
                    {
                        for (int i = 0; i < tabela.Columns.Count; i++)
                        {
                            salvarArq.Write(dr.Cells[i].Value);
                            salvarArq.Write(",");
                        }
                        // salva o arquivo no direório com nome selecionado

                        //agora vai salvando todas linhas da tabela
                        //o UTF8 serve pra expotar também caracteres especiais
                        salvarArq.Write(salvarArq.NewLine,Encoding.UTF8);
                    }
                    salvarArq.Close();
                    MessageBox.Show("Arquivo Exportado com sucesso!");
                }
                catch (Exception)
                {

                   MessageBox.Show("Erro ao salvar, Gentileza verificar se o arquivo está em uso ou se possui permissão suficiente!","Erro ao exportar",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
               
              

               
                
                
            }
            else
            {
                return;
            }
            
        }
        
    }
}
