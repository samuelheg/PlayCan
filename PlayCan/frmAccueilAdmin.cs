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
    public partial class frmAccueilAdmin : Form
    {
        private static frmAccueilAdmin accueilAdmin;
        private ControllerPlayCan controller = new ControllerPlayCan();
        private frmAccueilAdmin()
        {
            InitializeComponent();
        }

        public static frmAccueilAdmin getFrmAccueilAdmin() {
            if (accueilAdmin == null)
            {
                accueilAdmin = new frmAccueilAdmin();
            }
            return accueilAdmin;
        }

        private void dtgMusiques_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlInfosMusique_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmAccueilAdmin_Load(object sender, EventArgs e)
        {

        }

        private void frmAccueilAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            accueilAdmin = null;
        }

        private void lblDeconnexion_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void lbl_MouseHover(object sender, EventArgs e)
        {
            controller.lbl_MouseHover(sender,e);
        }

        private void lbl_MouseLeave(object sender, EventArgs e)
        {
            controller.lbl_MouseLeave(sender, e);
        }

        private void lblAccueil_Click(object sender, EventArgs e)
        {

        }

        private void lblAbonnements_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGestionAbonnements.getGestionnaireAbonnements().Show();
        }

        private void lblMusique_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGestionnaireMusique.getGestionnaireMusique().Show();
        }

        private void lblParametres_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmParametresAdmin.getFrmParametresAdmin().Show();
        }

        private void lblAPropos_Click(object sender, EventArgs e)
        {
            frmAPropos aPropos = new frmAPropos();
            aPropos.ShowDialog();
        }
    }
}
