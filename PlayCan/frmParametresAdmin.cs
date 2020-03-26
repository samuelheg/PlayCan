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
    public partial class frmParametresAdmin : Form
    {
        private static frmParametresAdmin parametres;
        private ControllerPlayCan controller = new ControllerPlayCan();
        private frmParametresAdmin()
        {
            InitializeComponent();
        }

        public static frmParametresAdmin getFrmParametresAdmin()
        {
            if (parametres == null)
            {
                parametres = new frmParametresAdmin();
            }
            return parametres;
        }

        private void lblAccueil_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblAbonnements_Click(object sender, EventArgs e)
        {
            parametres = null;
            this.Dispose();
            frmGestionAbonnements.getGestionnaireAbonnements().Show();
        }

        private void lblMusique_Click(object sender, EventArgs e)
        {
            parametres = null;
            this.Dispose();
            frmGestionnaireMusique.getGestionnaireMusique().Show();
        }

        private void lblAPropos_Click(object sender, EventArgs e)
        {
            frmAPropos aPropos = new frmAPropos();
            aPropos.ShowDialog();
        }

        private void lblDeconnexion_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void lbl_MouseHover(object sender, EventArgs e)
        {
            controller.lbl_MouseHover(sender, e);
        }

        private void lbl_MouseLeave(object sender, EventArgs e)
        {
            controller.lbl_MouseLeave(sender, e);
        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmParametresAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            parametres = null;
            frmAccueilAdmin.getFrmAccueilAdmin().Show();

        }

        private void pnlFormulaire_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
