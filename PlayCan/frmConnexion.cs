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
    public partial class frmConnexion : Form
    {
        public int role = 0;
        private static frmConnexion connexion;
        private frmConnexion()
        {
            InitializeComponent();
        }

        public static frmConnexion getFrmConnexion() {
            if (connexion == null) {
                connexion = new frmConnexion();
            }
            return connexion;
        }

        private void lblAccueil_Click(object sender, EventArgs e)
        {

        }

        private void frmConnexion_Load(object sender, EventArgs e)
        {

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (tbxId.Text.Equals(""))
            {
                this.Close();
                role = 1;
        
            }
            else {
                this.Close();
                frmAccueilAdmin accueil = frmAccueilAdmin.getFrmAccueilAdmin();
                role = 2;
            }
            
        }

        private void lblInscription_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInscription.getFrmInscription().ShowDialog();
        }

        private void frmConnexion_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (role == 0) {
                Application.Exit();
            }
        }
    }
}
