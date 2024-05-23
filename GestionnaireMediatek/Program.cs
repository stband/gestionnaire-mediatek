using GestionnaireMediatek.Views;

namespace GestionnaireMediatek
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            try
            {
                BddManager.GetInstance().TestConnection();
                Application.Run(new Form1());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion a la base de donnees : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }
    }
}
