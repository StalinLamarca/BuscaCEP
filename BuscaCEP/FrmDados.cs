using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaCEP
{
    public partial class FrmDados : Form
    {
        public FrmDados()
        {
            InitializeComponent();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDados_Load(object sender, EventArgs e)
        {

            //instancia objeto da Classe data
            BancoDados data = new BancoDados();
            //executa o metodo para carregar dados no datagridview
            data.FrmDaDOS();
        }
    }
}
