using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayCan
{
    public partial class frmGestionAbonnements : Form
    {
        private static frmGestionAbonnements gestionAbonnements;
        private ControllerPlayCan controller = new ControllerPlayCan();

        private frmGestionAbonnements()
        {
            InitializeComponent();
        }
        public static frmGestionAbonnements getGestionnaireAbonnements()
        {
            if (gestionAbonnements == null)
            {
                gestionAbonnements = new frmGestionAbonnements();
            }
            return gestionAbonnements;
        }

        private void lblAccueil_Click(object sender, EventArgs e)
        {

        }

        private void lbl_MouseHover(object sender, EventArgs e)
        {
            controller.lbl_MouseHover(sender, e);
        }

        private void lbl_MouseLeave(object sender, EventArgs e)
        {
            controller.lbl_MouseLeave(sender, e);
        }
    }
}
