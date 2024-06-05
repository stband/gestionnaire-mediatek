using GestionnaireMediatek.Controllers;
using GestionnaireMediatek.Models;

namespace GestionnaireMediatek.Views
{
    public partial class FrmAjouterModifierPersonnel : Form
    {
        private Personnel personnel;
        private bool isEditMode;

        // Constructeur pour le mode ajout
        public FrmAjouterModifierPersonnel()
        {
            InitializeComponent();
            isEditMode = false;
            SetupForm();
            
            // Ajouter les gestionnaires d'événements pour chaque TextBox seulement pour le constructeur du mode ajout
            AddPlaceholderEvents();

            // Ajout des gestionnaires d'événements
            btnAjouter.Click += btnAjouter_Click;
            btnAnnuler.Click += btnAnnuler_Click;

            // Masquer le label d'erreur au démarrage
            lblGestionErreur.Visible = false;
        }

        // Constructeur pour le mode modification
        public FrmAjouterModifierPersonnel(Personnel personnel)
        {
            InitializeComponent();
            this.personnel = personnel;
            isEditMode = true;
            SetupForm();
            LoadPersonnelData();

            // Ajout des gestionnaires d'événements
            btnAjouter.Click += btnAjouter_Click;
            btnAnnuler.Click += btnAnnuler_Click;

            // Masquer le label d'erreur au démarrage
            lblGestionErreur.Visible = false;
        }

        // Setup visuel du form qui change en fonction du mode ajout ou modification
        private void SetupForm()
        {
            if (isEditMode)
            {
                lblInfo.Text = "Modifier les informations du personnel";
                btnAjouter.Text = "Enregistrer";
            }
            else
            {
                lblInfo.Text = "Ajouter un nouveau personnel";
                btnAjouter.Text = "Ajouter";
            }

            var services = PersonnelController.GetServices();
            cbxServiceAffectation.DataSource = services;
            cbxServiceAffectation.DisplayMember = "Libelle";
            cbxServiceAffectation.ValueMember = "IdService";
        }

        private void LoadPersonnelData()
        {
            if (personnel != null)
            {
                // Charger les données du personnel dans le formulaire de modification
                txtNom.Text = personnel.Nom;
                txtPrenom.Text = personnel.Prenom;
                cbxServiceAffectation.SelectedValue = personnel.IdService;
                txtTel.Text = personnel.Tel;
                txtMail.Text = personnel.Mail;
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }

            int selectedServiceId = (int)cbxServiceAffectation.SelectedValue;

            if (isEditMode)
            {
                if (!HasModifications())
                {
                    lblGestionErreur.Text = "Aucune modification n'a été faite.";
                    lblGestionErreur.ForeColor = Color.Red;
                    lblGestionErreur.Visible = true;
                    return;
                }

                // Ouvrir le formulaire de confirmation
                FrmConfirmerModification frm = new FrmConfirmerModification();

                if (frm.ShowDialog() == DialogResult.OK) // si l'utilisateur confirme les modifications
                {
                    // Mettre à jour les informations du personnel avec les nouvelles valeurs
                    personnel.Nom = txtNom.Text;
                    personnel.Prenom = txtPrenom.Text;
                    personnel.IdService = selectedServiceId;
                    personnel.Tel = txtTel.Text;
                    personnel.Mail = txtMail.Text;

                    Logger.Log($"Updating personnel: Nom={personnel.Nom}, Prenom={personnel.Prenom}, IdService={personnel.IdService}, Tel={personnel.Tel}, Mail={personnel.Mail}");

                    // Sauvegarder les modifications
                    PersonnelController.UpdatePersonnel(personnel);
                }

            }
            else
            {
                // Ajouter un nouveau personnel
                Personnel newPersonnel = new Personnel
                {
                    Nom = txtNom.Text == "Nom" ? string.Empty : txtNom.Text,
                    Prenom = txtPrenom.Text == "Prénom" ? string.Empty : txtPrenom.Text,
                    IdService = selectedServiceId,
                    Tel = txtTel.Text == "Téléphone" ? string.Empty : txtTel.Text,
                    Mail = txtMail.Text == "Email" ? string.Empty : txtMail.Text
                };

                PersonnelController.AddPersonnel(newPersonnel);
            }

            // Fermer le formulaire
            this.Close();
        }

        private bool ValidateFields()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(txtNom.Text) || txtNom.Text == "Nom" ||
                string.IsNullOrWhiteSpace(txtPrenom.Text) || txtPrenom.Text == "Prénom" ||
                string.IsNullOrWhiteSpace(txtTel.Text) || txtTel.Text == "Téléphone" ||
                string.IsNullOrWhiteSpace(txtMail.Text) || txtMail.Text == "Email" ||
                cbxServiceAffectation.SelectedItem == null)
            {
                lblGestionErreur.Text = "Tous les champs doivent être remplis.";
                lblGestionErreur.ForeColor = Color.Red;
                lblGestionErreur.Visible = true; // Afficher le label d'erreur
                isValid = false;
            }
            else
            {
                lblGestionErreur.Visible = false; // Masquer le label d'erreur
            }

            return isValid;
        }

        private bool HasModifications()
        {
            int selectedServiceId = (int)cbxServiceAffectation.SelectedValue;
            return personnel.Nom != txtNom.Text ||
                   personnel.Prenom != txtPrenom.Text ||
                   personnel.IdService != selectedServiceId ||
                   personnel.Tel != txtTel.Text ||
                   personnel.Mail != txtMail.Text;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPlaceholderEvents()
        {
            if (!isEditMode)
            {
                AddPlaceholderEvent(txtNom, "Nom");
                AddPlaceholderEvent(txtPrenom, "Prénom");
                AddPlaceholderEvent(txtTel, "Téléphone");
                AddPlaceholderEvent(txtMail, "Email");
            }
        }

        private void AddPlaceholderEvent(TextBox textBox, string placeholderText)
        {
            textBox.Text = placeholderText;
            textBox.ForeColor = System.Drawing.SystemColors.GrayText;

            textBox.Enter += (sender, e) => {
                if (textBox.Text == placeholderText)
                {
                    textBox.Text = string.Empty;
                    textBox.ForeColor = System.Drawing.SystemColors.WindowText;
                }
            };

            textBox.Leave += (sender, e) => {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholderText;
                    textBox.ForeColor = System.Drawing.SystemColors.GrayText;
                }
            };
        }
    }
}
