using GestionnaireMediatek.Controllers;
using GestionnaireMediatek.Models;

namespace GestionnaireMediatek.Views
{
    public partial class FrmAjouterModifierAbsence : Form
    {
        private readonly Personnel personnel;
        private readonly Absence absence;
        private readonly bool isEditMode;

        public FrmAjouterModifierAbsence(Personnel personnel)
        {
            InitializeComponent();
            this.personnel = personnel;
            isEditMode = false;
            SetupForm();
        }

        public FrmAjouterModifierAbsence(Personnel personnel, Absence absence)
        {
            InitializeComponent();
            this.personnel = personnel;
            this.absence = absence;
            isEditMode = true;
            SetupForm();
            LoadAbsenceData();
        }

        private void SetupForm()
        {
            lblInfo.Text = isEditMode ? "Modifier une absence" : "Ajouter une absence";
            btnAjouter.Text = isEditMode ? "Enregistrer" : "Ajouter";
            LoadMotifs();
            btnAjouter.Click += BtnAjouter_Click;
            btnAnnuler.Click += BtnAnnuler_Click;
            lblGestionErreur.Visible = false; // Masquer le label d'erreur par défaut
        }

        private void LoadAbsenceData()
        {
            if (absence != null)
            {
                dtpDebut.Value = absence.DateDebut;
                dtpFin.Value = absence.DateFin ?? DateTime.Now;
                cbxMotif.SelectedValue = absence.IdMotif;
            }
        }

        private void LoadMotifs()
        {
            var motifs = PersonnelController.GetMotifs();
            cbxMotif.DataSource = motifs;
            cbxMotif.DisplayMember = "Libelle";
            cbxMotif.ValueMember = "IdMotif";
        }

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

            // Vérifier les conflits d'absences
            if (HasConflictingAbsence())
            {
                return "Une absence est déjà programmée dans ce créneau.";
            }

            return null;
        }

        private bool HasConflictingAbsence()
        {
            var absences = PersonnelController.GetAbsences(personnel.IdPersonnel);
            foreach (var abs in absences)
            {
                if (isEditMode && abs.DateDebut == absence.DateDebut && abs.IdPersonnel == absence.IdPersonnel)
                {
                    continue; // Ignorer l'absence en cours de modification
                }

                if ((dtpDebut.Value >= abs.DateDebut && dtpDebut.Value <= abs.DateFin) ||
                    (dtpFin.Value >= abs.DateDebut && dtpFin.Value <= abs.DateFin) ||
                    (dtpDebut.Value <= abs.DateDebut && dtpFin.Value >= abs.DateFin))
                {
                    return true;
                }
            }
            return false;
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            Logger.Log("BtnAjouter_Click invoked");

            string validationError = ValidateFields();
            if (validationError != null)
            {
                Logger.Log("Validation failed: " + validationError);
                lblGestionErreur.Text = validationError;
                lblGestionErreur.Visible = true;
                return;
            }

            Logger.Log("Validation successful");

            FrmConfirmerModification confirmationForm = new FrmConfirmerModification();
            if (confirmationForm.ShowDialog() == DialogResult.OK)
            {
                if (isEditMode)
                {
                    DateTime oldDateDebut = absence.DateDebut;
                    Logger.Log($"Old DateDebut: {oldDateDebut}");

                    absence.DateDebut = dtpDebut.Value;
                    absence.DateFin = dtpFin.Value;
                    absence.IdMotif = (int)cbxMotif.SelectedValue;

                    Logger.Log($"New DateDebut: {absence.DateDebut}, New DateFin: {absence.DateFin}, New IdMotif: {absence.IdMotif}");
                    PersonnelController.UpdateAbsence(absence, oldDateDebut);
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

                    Logger.Log($"Adding new absence: DateDebut: {newAbsence.DateDebut}, DateFin: {newAbsence.DateFin}, IdMotif: {newAbsence.IdMotif}");
                    PersonnelController.AddAbsence(newAbsence);
                }
                this.Close();
            }
            else if (confirmationForm.DialogResult == DialogResult.Cancel)
            {
                this.Close();
            }
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
