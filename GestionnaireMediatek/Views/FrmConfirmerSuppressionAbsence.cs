using GestionnaireMediatek.Models;
using GestionnaireMediatek.Controllers;

namespace GestionnaireMediatek.Views
{
    /// <summary>
    /// Formulaire de confirmation pour la suppression d'une absence.
    /// </summary>
    public partial class FrmConfirmerSuppressionAbsence : Form
    {
        private readonly Absence absence;

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="FrmConfirmerSuppressionAbsence"/>.
        /// </summary>
        /// <param name="absence">L'objet <see cref="Absence"/> représentant l'absence à supprimer.</param>
        public FrmConfirmerSuppressionAbsence(Absence absence)
        {
            InitializeComponent();
            this.absence = absence;
            LoadAbsenceData();
            btnSupprimer.Click += BtnSupprimer_Click;
            btnAnnuler.Click += BtnAnnuler_Click;
        }

        /// <summary>
        /// Charge les données de l'absence dans les labels du formulaire.
        /// </summary>
        private void LoadAbsenceData()
        {
            lblInfoDebut.Text = absence.DateDebut.ToString("yyyy-MM-dd");
            lblInfoFin.Text = absence.DateFin?.ToString("yyyy-MM-dd");
            lblInfoMotif.Text = PersonnelController.GetMotifs().FirstOrDefault(m => m.IdMotif == absence.IdMotif)?.Libelle ?? "Inconnu";
        }

        /// <summary>
        /// Gestionnaire d'événements pour le clic sur le bouton Supprimer.
        /// </summary>
        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            PersonnelController.DeleteAbsence(absence);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Gestionnaire d'événements pour le clic sur le bouton Annuler.
        /// </summary>
        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
