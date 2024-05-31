using GestionnaireMediatek.Controllers;
using GestionnaireMediatek.Models;

namespace GestionnaireMediatek.Views
{
    public partial class FrmAjouterModifierPersonnel : Form
    {
        private Personnel personnel;

        public FrmAjouterModifierPersonnel(Personnel personnel)
        {
            InitializeComponent();
            this.personnel = personnel;
            LoadPersonnelData();
        }

        private void LoadPersonnelData()
        {
            // Charger les données du personnel dans les contrôles de votre formulaire
            txtNom.Text = personnel.Nom;
            txtPrenom.Text = personnel.Prenom;
            cbxServiceAffectation.SelectedItem = personnel.IdService.ToString(); // Adaptez cela pour afficher le nom du service
            txtTel.Text = personnel.Tel;
            txtMail.Text = personnel.Mail;

            // Mettre à jour le libellé du formulaire
            lblInfo.Text = "Modifier les informations du personnel";
            btnAjouter.Text = "Modifier";
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Mettre à jour les informations du personnel avec les nouvelles valeurs
            personnel.Nom = txtNom.Text;
            personnel.Prenom = txtPrenom.Text;
            personnel.IdService = int.Parse(cbxServiceAffectation.SelectedItem.ToString()); // Adaptez cela pour le nom du service
            personnel.Tel = txtTel.Text;
            personnel.Mail = txtMail.Text;

            // Sauvegarder les modifications
            PersonnelController.UpdatePersonnel(personnel);

            // Fermer le formulaire de modification
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
