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
    public partial class frmGestionnaireMusique : Form
    {
        private static frmGestionnaireMusique gestionMusique;
        private ControllerPlayCan controller = new ControllerPlayCan();
        private frmGestionnaireMusique()
        {
            InitializeComponent();
        }

        public static frmGestionnaireMusique getGestionnaireMusique()
        {
            if (gestionMusique == null)
            {
                gestionMusique = new frmGestionnaireMusique();
            }
            return gestionMusique;
        }

        private void rbImpayes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblDeconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
            frmConnexion.getFrmConnexion().Show();
        }

        private void lbl_MouseHover(object sender, EventArgs e)
        {
            controller.lbl_MouseHover(sender, e);
        }

        private void lbl_MouseLeave(object sender, EventArgs e)
        {
            controller.lbl_MouseLeave(sender, e);
        }

        private void lblAccueil_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAccueilAdmin.getFrmAccueilAdmin().Show();
        }

        private void lblAbonnements_Click(object sender, EventArgs e)
        {
            this.Close();
            frmGestionAbonnements.getGestionnaireAbonnements().Show();
        }

        private void lblMusique_Click(object sender, EventArgs e)
        {

        }

        private void lblParametres_Click(object sender, EventArgs e)
        {

        }

        private void lblAPropos_Click(object sender, EventArgs e)
        {
            frmAPropos aPropos = new frmAPropos();
            aPropos.ShowDialog();
        }
    }
}
