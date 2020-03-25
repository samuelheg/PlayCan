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
    public partial class frmAccueilUtilisateur : Form
    {
        private static frmAccueilUtilisateur accueilUtilisateur;
        private ControllerPlayCan controller = new ControllerPlayCan();
        private frmAccueilUtilisateur()
        {
            InitializeComponent();
        }

        public static frmAccueilUtilisateur getFrmAccueilUtilisateur()
        {
            if (accueilUtilisateur == null) {
                accueilUtilisateur = new frmAccueilUtilisateur();
            }
            return accueilUtilisateur;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblAccueil_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dtgMusiques_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblAccueil_Click_1(object sender, EventArgs e)
        {

        }

        private void lblPlaylist_Click(object sender, EventArgs e)
        {

        }

        private void lblParametres_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmParametres.getFrmParametres().ShowDialog();
        }

        private void lblAPropos_Click(object sender, EventArgs e)
        {
            var aPropos = new frmAPropos();
            aPropos.ShowDialog();
        }

        private void lblDeconnexion_Click(object sender, EventArgs e)
        {
            //this.Close();
            //frmConnexion.getFrmConnexion().Show();
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
    }
}
