using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayCan
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmConnexion.getFrmConnexion().ShowDialog();
            if (frmConnexion.getFrmConnexion().role == 1)
            {
                frmAccueilUtilisateur accueil = frmAccueilUtilisateur.getFrmAccueilUtilisateur();
                accueil.Hide();
                Application.Run(accueil);
            }
            else if (frmConnexion.getFrmConnexion().role == 2)
            {
                frmAccueilAdmin accueil = frmAccueilAdmin.getFrmAccueilAdmin();
                accueil.Hide();
                Application.Run(accueil);
            }
            else {
                
            }



        }
    }
}
