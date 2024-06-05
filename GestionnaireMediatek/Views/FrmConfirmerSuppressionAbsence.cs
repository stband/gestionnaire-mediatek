using GestionnaireMediatek.Models;
using GestionnaireMediatek.Controllers;

namespace GestionnaireMediatek.Views
{
    public partial class FrmConfirmerSuppressionAbsence : Form
    {
        private readonly Absence absence;

        public FrmConfirmerSuppressionAbsence(Absence absence)
        {
            InitializeComponent();
            this.absence = absence;
            LoadAbsenceData();
            btnSupprimer.Click += BtnSupprimer_Click;
            btnAnnuler.Click += BtnAnnuler_Click;
        }

        private void LoadAbsenceData()
        {
            lblInfoDebut.Text = absence.DateDebut.ToString("yyyy-MM-dd");
            lblInfoFin.Text = absence.DateFin?.ToString("yyyy-MM-dd");
            lblInfoMotif.Text = PersonnelController.GetMotifs().FirstOrDefault(m => m.IdMotif == absence.IdMotif)?.Libelle ?? "Inconnu";
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            PersonnelController.DeleteAbsence(absence);
            this.Close();
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
