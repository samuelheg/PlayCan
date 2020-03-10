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
    public partial class frmInscription : Form
    {
        private static frmInscription inscription;
        private frmInscription()
        {
            InitializeComponent();
        }

        public static frmInscription getFrmInscription() {
            if (inscription ==null) {
                inscription = new frmInscription();
            }
            return inscription;
        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            this.Close();
            frmConnexion.getFrmConnexion().Show();
        }

        private void frmInscription_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmConnexion.getFrmConnexion().Show();
        }
    }
}
