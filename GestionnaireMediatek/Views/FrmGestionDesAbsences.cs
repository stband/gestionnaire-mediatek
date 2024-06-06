using GestionnaireMediatek.Models;
using GestionnaireMediatek.Controllers;
using System.Collections.Generic;

namespace GestionnaireMediatek.Views
{
    /// <summary>
    /// Formulaire de gestion des absences pour un personnel spécifique.
    /// </summary>
    public partial class FrmGestionDesAbsences : Form
    {
        private Personnel personnel;
        private List<Motif> motifs;

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="FrmGestionDesAbsences"/>.
        /// </summary>
        /// <param name="personnel">L'objet <see cref="Personnel"/> représentant le personnel dont les absences sont gérées.</param>
        public FrmGestionDesAbsences(Personnel personnel)
        {
            InitializeComponent();
            this.personnel = personnel;
            lblNomPrenom.Text = $"{personnel.Nom} {personnel.Prenom}";
            motifs = PersonnelController.GetMotifs();
            LoadAbsenceData();

            // Initialiser le DataGridView
            InitializeDataGridView();
        }

        /// <summary>
        /// Initialise le DataGridView en ajoutant un gestionnaire d'événements pour la sélection des lignes.
        /// Définit également les couleurs de sélection des lignes.
        /// </summary>
        private void InitializeDataGridView()
        {
            dgvListeAbsence.SelectionChanged += new EventHandler(dgvListeAbsence_SelectionChanged);
            dgvListeAbsence.DefaultCellStyle.SelectionBackColor = Color.LightBlue; // Couleur de fond
            dgvListeAbsence.DefaultCellStyle.SelectionForeColor = Color.Black; // Couleur du texte
        }

        /// <summary>
        /// Gère l'événement de changement de sélection dans le DataGridView.
        /// Change la couleur de fond et la couleur du texte de la ligne sélectionnée pour la rendre plus visible.
        /// </summary>
        /// <param name="sender">Objet source de l'événement</param>
        /// <param name="e">Arguments de l'événement</param>
        private void dgvListeAbsence_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvListeAbsence.Rows)
            {
                if (row.Selected)
                {
                    row.DefaultCellStyle.BackColor = Color.LightBlue; // Couleur de fond de la ligne sélectionnée
                    row.DefaultCellStyle.ForeColor = Color.Black; // Couleur du texte de la ligne sélectionnée
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White; // Couleur de fond par défaut
                    row.DefaultCellStyle.ForeColor = Color.Black; // Couleur du texte par défaut
                }
            }
        }

        /// <summary>
        /// Charge les données des absences du personnel et les affiche dans le DataGridView.
        /// </summary>
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

        /// <summary>
        /// Gestionnaire d'événements pour le clic sur l'image Ajouter Absence.
        /// Ouvre le formulaire d'ajout/modification d'absence en mode ajout.
        /// </summary>
        private void pbxAjouterAbsence_Click(object sender, EventArgs e)
        {
            FrmAjouterModifierAbsence frm = new FrmAjouterModifierAbsence(personnel);
            frm.ShowDialog();

            // Refresh le datagrid après l'ajout
            LoadAbsenceData();
        }

        /// <summary>
        /// Gestionnaire d'événements pour le clic sur l'image Modifier Absence.
        /// Ouvre le formulaire d'ajout/modification d'absence en mode modification.
        /// </summary>
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

        /// <summary>
        /// Récupère l'identifiant du motif à partir de son libellé.
        /// </summary>
        /// <param name="libelle">Le libellé du motif.</param>
        /// <returns>L'identifiant du motif, ou -1 si le motif n'est pas trouvé.</returns>
        private int GetMotifIdFromLibelle(string libelle)
        {
            var motif = motifs.FirstOrDefault(m => m.Libelle == libelle);
            return motif != null ? motif.IdMotif : -1;
        }

        /// <summary>
        /// Gestionnaire d'événements pour le clic sur l'image Supprimer Absence.
        /// Ouvre le formulaire de confirmation de suppression d'absence.
        /// </summary>
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

                    // Refresh le datagrid
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

