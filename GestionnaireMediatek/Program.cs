using System;
using System.Windows.Forms;
using GestionnaireMediatek.Views;
using GestionnaireMediatek.dal;

namespace GestionnaireMediatek
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            try
            {
                // Initialisation de Access pour gérer la connexion
                Access.GetInstance();
                Application.Run(new FrmAuthentification());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion à la base de données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }
    }
}
