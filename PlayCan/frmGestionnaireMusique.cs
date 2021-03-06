﻿using System;
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

        private void lblAccueil_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void lblAbonnements_Click(object sender, EventArgs e)
        {
            gestionMusique = null;
            this.Dispose();
            frmGestionAbonnements.getGestionnaireAbonnements().Show();
        }

        private void lblMusique_Click(object sender, EventArgs e)
        {

        }

        private void lblParametres_Click(object sender, EventArgs e)
        {
            gestionMusique = null;
            this.Dispose();
            frmParametresAdmin.getFrmParametresAdmin().Show();
        }

        private void lblAPropos_Click(object sender, EventArgs e)
        {
            frmAPropos aPropos = new frmAPropos();
            aPropos.ShowDialog();
        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmGestionnaireMusique_FormClosed(object sender, FormClosedEventArgs e)
        {
            gestionMusique = null;
            frmAccueilAdmin.getFrmAccueilAdmin().Show();
        }

        private void dtgMusiques_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
