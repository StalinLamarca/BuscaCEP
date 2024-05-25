using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaCEP.Controles
{
    public class ControlesTextBox : TextBox
    {
        protected override void OnCreateControl()
        {

            base.OnCreateControl();
            ForeColor = Color.FromArgb(64, 64, 64);
            Font = new Font("Century Gothic", 12f);
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            BackColor = Color.White;
        }
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            BackColor = Color.SteelBlue;
        }
    }
}
