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
            this.Close();

        }

        private void lbl_MouseHover(object sender, EventArgs e)
        {
            controller.lbl_MouseHover(sender, e);
        }

        private void lbl_MouseLeave(object sender, EventArgs e)
        {
            controller.lbl_MouseLeave(sender, e);
        }

        private void lblMusique_Click(object sender, EventArgs e)
        {
            gestionAbonnements = null;
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

        private void lblParametres_Click(object sender, EventArgs e)
        {
            gestionAbonnements = null;
            this.Dispose();
            frmParametresAdmin.getFrmParametresAdmin().Show();
        }

        private void lblAbonnements_Click(object sender, EventArgs e)
        {

        }

        private void frmGestionAbonnements_FormClosed(object sender, FormClosedEventArgs e)
        {
            gestionAbonnements = null;
            frmAccueilAdmin.getFrmAccueilAdmin().Show();
        }

        private void dtgAbonnements_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
