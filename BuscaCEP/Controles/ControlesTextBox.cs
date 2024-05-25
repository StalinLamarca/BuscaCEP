using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaCEP.Controles
{
    public class ControlesTextBox : TextBox
    {
        //evento no criar do TextBox
        protected override void OnCreateControl()
        {
          
            base.OnCreateControl();
            //muda a cor da fonte para cinza claro
            ForeColor = Color.FromArgb(64, 64, 64);
            //muda a fonte
            Font = new Font("Century Gothic", 12f);
        }

        //evento de quando textbox sair do foco
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            //cor de fundo recebe branco
            BackColor = Color.White;
        }
        //evento quando a text box estiver em foco
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            //cor de fundo recebe azul claro
            BackColor = Color.FromName("GradientInactiveCaption");
        }
    }
}
