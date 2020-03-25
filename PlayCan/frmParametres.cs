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
    public partial class frmParametres : Form
    {
        private static frmParametres parametres;
        private ControllerPlayCan controller = new ControllerPlayCan();
        private frmParametres()
        {
            InitializeComponent();
        }

        public static frmParametres getFrmParametres() {
            if (parametres == null) {
                parametres = new frmParametres();
            }
            return parametres;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlFormulaire_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmParametres_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAccueilUtilisateur.getFrmAccueilUtilisateur().Show();
        }

        private void lblAccueil_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAccueilUtilisateur.getFrmAccueilUtilisateur().Show();
        }

        private void lblPlaylist_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAccueilUtilisateur.getFrmAccueilUtilisateur().Show();
        }

        private void lblAPropos_Click(object sender, EventArgs e)
        {
            var aPropos = new frmAPropos();
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

        private void lblFavoris_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAccueilUtilisateur.getFrmAccueilUtilisateur().Show();
        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
