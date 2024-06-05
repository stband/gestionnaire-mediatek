using GestionnaireMediatek.Models;
using GestionnaireMediatek.Controllers;
using System.Collections.Generic;

namespace GestionnaireMediatek.Views
{
    public partial class FrmGestionDesAbsences : Form
    {
        private Personnel personnel;
        private List<Motif> motifs;

        public FrmGestionDesAbsences(Personnel personnel)
        {
            InitializeComponent();
            this.personnel = personnel;
            lblNomPrenom.Text = $"{personnel.Nom} {personnel.Prenom}";
            motifs = PersonnelController.GetMotifs();
            LoadAbsenceData();
        }

        private void LoadAbsenceData()
        {
            List<Absence> absences = PersonnelController.GetAbsences(personnel.IdPersonnel);

            // Trier les absences par DateDebut en ordre décroissant
            absences = absences.OrderByDescending(a => a.DateDebut).ToList();

            dgvListeAbsence.Rows.Clear();

            foreach (var absence in absences)
            {
                string motifLibelle = motifs.FirstOrDefault(m => m.IdMotif == absence.IdMotif)?.Libelle ?? "Inconnu";
                dgvListeAbsence.Rows.Add(
                    absence.DateDebut.ToString("yyyy-MM-dd"),
                    absence.DateFin?.ToString("yyyy-MM-dd"),
                    motifLibelle
                );
            }
        }

        private void pbxAjouterAbsence_Click(object sender, EventArgs e)
        {
            FrmAjouterModifierAbsence frm = new FrmAjouterModifierAbsence(personnel);
            frm.ShowDialog();

            // Refresh le datagrid après l'ajout
            LoadAbsenceData();
        }
    }
}
