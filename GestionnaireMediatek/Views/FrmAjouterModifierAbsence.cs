using GestionnaireMediatek.Controllers;
using GestionnaireMediatek.Models;

namespace GestionnaireMediatek.Views
{
    /// <summary>
    /// Formulaire pour ajouter ou modifier une absence.
    /// Important : ce formulaire est utilisé pour gérer les parties ajout et modification d'une absence.
    /// En fonction de son "mode", certains comportements et visuels changent.
    /// </summary>
    public partial class FrmAjouterModifierAbsence : Form
    {
        private readonly Personnel personnel;
        private readonly Absence absence;
        private readonly bool isEditMode;

        /// <summary>
        /// Initialise une nouvelle instance de <see cref="FrmAjouterModifierAbsence"/> en mode ajout.
        /// </summary>
        /// <param name="personnel">Le personnel pour lequel l'absence est ajoutée.</param>
        public FrmAjouterModifierAbsence(Personnel personnel)
        {
            InitializeComponent();
            this.personnel = personnel;
            isEditMode = false;
            SetupForm();
        }

        /// <summary>
        /// Initialise une nouvelle instance de <see cref="FrmAjouterModifierAbsence"/> en mode modification.
        /// </summary>
        /// <param name="personnel">Le personnel pour lequel l'absence est modifiée.</param>
        /// <param name="absence">L'absence à modifier.</param>
        public FrmAjouterModifierAbsence(Personnel personnel, Absence absence)
        {
            InitializeComponent();
            this.personnel = personnel;
            this.absence = absence;
            isEditMode = true;
            SetupForm();
            LoadAbsenceData();
        }

        /// <summary>
        /// Configure le formulaire en fonction du mode (ajout ou modification).
        /// </summary>
        private void SetupForm()
        {
            lblInfo.Text = isEditMode ? "Modifier une absence" : "Ajouter une absence";
            btnAjouter.Text = isEditMode ? "Enregistrer" : "Ajouter";
            LoadMotifs();
            btnAjouter.Click += BtnAjouter_Click;
            btnAnnuler.Click += BtnAnnuler_Click;
            lblGestionErreur.Visible = false; // Masquer le label d'erreur par défaut
        }

        /// <summary>
        /// Charge les données de l'absence dans les champs du formulaire en mode modification.
        /// </summary>
        private void LoadAbsenceData()
        {
            if (absence != null)
            {
                dtpDebut.Value = absence.DateDebut;
                dtpFin.Value = absence.DateFin ?? DateTime.Now;
                cbxMotif.SelectedValue = absence.IdMotif;
            }
        }

        /// <summary>
        /// Charge les motifs d'absence dans la liste déroulante.
        /// </summary>
        private void LoadMotifs()
        {
            var motifs = PersonnelController.GetMotifs();
            cbxMotif.DataSource = motifs;
            cbxMotif.DisplayMember = "Libelle";
            cbxMotif.ValueMember = "IdMotif";
        }

        /// <summary>
        /// Valide les champs du formulaire.
        /// </summary>
        /// <returns>Un message d'erreur si la validation échoue, sinon null.</returns>
        private string ValidateFields()
        {
            if (dtpDebut.Value == null || dtpFin.Value == null || cbxMotif.SelectedValue == null)
            {
                return "Tous les champs doivent être remplis.";
            }

            if (dtpFin.Value < dtpDebut.Value)
            {
                return "La date de fin ne peut pas être antérieure à la date de début.";
            }

            if (isEditMode && dtpDebut.Value == absence.DateDebut && dtpFin.Value == absence.DateFin && (int)cbxMotif.SelectedValue == absence.IdMotif)
            {
                return "Aucune modification n'a été réalisée.";
            }

            // Vérifier les conflits d'absences uniquement en mode ajout
            if (!isEditMode && HasConflictingAbsence())
            {
                return "Une absence est déjà programmée dans ce créneau.";
            }

            return null;
        }

        /// <summary>
        /// Vérifie s'il existe une absence en conflit avec les dates saisies.
        /// </summary>
        /// <returns>True s'il existe une absence en conflit, sinon false.</returns>
        private bool HasConflictingAbsence()
        {
            var absences = PersonnelController.GetAbsences(personnel.IdPersonnel);
            foreach (var abs in absences)
            {
                if ((dtpDebut.Value >= abs.DateDebut && dtpDebut.Value <= abs.DateFin) ||
                    (dtpFin.Value >= abs.DateDebut && dtpFin.Value <= abs.DateFin) ||
                    (dtpDebut.Value <= abs.DateDebut && dtpFin.Value >= abs.DateFin))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Gestionnaire d'événements pour le clic sur le bouton Ajouter/Enregistrer.
        /// </summary>
        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            string validationError = ValidateFields();
            if (validationError != null)
            {
                lblGestionErreur.Text = validationError;
                lblGestionErreur.Visible = true;
                return;
            }

            if (isEditMode)
            {
                FrmConfirmerModification confirmationForm = new FrmConfirmerModification();
                if (confirmationForm.ShowDialog() == DialogResult.OK)
                {
                    DateTime oldDateDebut = absence.DateDebut;

                    absence.DateDebut = dtpDebut.Value;
                    absence.DateFin = dtpFin.Value;
                    absence.IdMotif = (int)cbxMotif.SelectedValue;

                    PersonnelController.UpdateAbsence(absence, oldDateDebut);
                    this.Close();
                }
                else if (confirmationForm.DialogResult == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
            else
            {
                var newAbsence = new Absence
                {
                    IdPersonnel = personnel.IdPersonnel,
                    DateDebut = dtpDebut.Value,
                    DateFin = dtpFin.Value,
                    IdMotif = (int)cbxMotif.SelectedValue
                };

                PersonnelController.AddAbsence(newAbsence);
                this.Close();
            }
        }

        /// <summary>
        /// Gestionnaire d'événements pour le clic sur le bouton Annuler.
        /// Fonctionne de la même manière en mode ajout ou modification.
        /// </summary>
        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
