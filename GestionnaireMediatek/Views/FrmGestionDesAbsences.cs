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

        private void pbxModifierAbsence_Click(object sender, EventArgs e)
        {
            if (dgvListeAbsence.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvListeAbsence.SelectedRows[0];

                try
                {
                    DateTime dateDebut = DateTime.Parse(selectedRow.Cells["ColumnDateDeDebut"].Value.ToString());
                    DateTime? dateFin = selectedRow.Cells["ColumnDateDeFin"].Value != null && selectedRow.Cells["ColumnDateDeFin"].Value.ToString() != ""
                        ? DateTime.Parse(selectedRow.Cells["ColumnDateDeFin"].Value.ToString())
                        : (DateTime?)null;
                    string motifLibelle = selectedRow.Cells["ColumnMotif"].Value.ToString();
                    int idMotif = GetMotifIdFromLibelle(motifLibelle);

                    Absence selectedAbsence = new Absence
                    {
                        IdPersonnel = personnel.IdPersonnel,
                        DateDebut = dateDebut,
                        DateFin = dateFin,
                        IdMotif = idMotif
                    };

                    FrmAjouterModifierAbsence frm = new FrmAjouterModifierAbsence(personnel, selectedAbsence);
                    frm.ShowDialog();

                    // Refresh le datagrid après la modification
                    LoadAbsenceData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur de conversion des données de l'absence. Veuillez vérifier les données.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private int GetMotifIdFromLibelle(string libelle)
        {
            var motif = motifs.FirstOrDefault(m => m.Libelle == libelle);
            return motif != null ? motif.IdMotif : -1; // Renvoie -1 si le motif n'est pas trouvé
        }

        private void pbxSupprimerAbsence_Click(object sender, EventArgs e)
        {
            if (dgvListeAbsence.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvListeAbsence.SelectedRows[0];

                try
                {
                    DateTime dateDebut = DateTime.Parse(selectedRow.Cells["ColumnDateDeDebut"].Value.ToString());
                    DateTime? dateFin = selectedRow.Cells["ColumnDateDeFin"].Value != null && selectedRow.Cells["ColumnDateDeFin"].Value.ToString() != ""
                        ? DateTime.Parse(selectedRow.Cells["ColumnDateDeFin"].Value.ToString())
                        : (DateTime?)null;
                    string motifLibelle = selectedRow.Cells["ColumnMotif"].Value.ToString();

                    Absence selectedAbsence = new Absence
                    {
                        IdPersonnel = personnel.IdPersonnel,
                        DateDebut = dateDebut,
                        DateFin = dateFin,
                        IdMotif = GetMotifIdFromLibelle(motifLibelle)
                    };

                    FrmConfirmerSuppressionAbsence frm = new FrmConfirmerSuppressionAbsence(selectedAbsence);
                    frm.ShowDialog();

                    // Refresh le datagrid après la suppression
                    LoadAbsenceData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur de conversion des données de l'absence. Veuillez vérifier les données.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
