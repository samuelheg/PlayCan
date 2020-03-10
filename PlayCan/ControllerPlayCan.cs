using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace PlayCan
{
    class ControllerPlayCan
    {
        public ControllerPlayCan()
        {
        
        }


        public void lbl_MouseHover(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.ForeColor = Color.FromArgb(155, 92, 155);
        }

        public void lbl_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.ForeColor = Color.FromArgb(255, 192, 255);
        }
    }
}
