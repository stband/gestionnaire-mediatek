using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GestionnaireMediatek.Controllers;
using GestionnaireMediatek.Models;

namespace GestionnaireMediatek.Views
{
    /// <summary>
    /// Formulaire de gestion du personnel.
    /// </summary>
    public partial class FrmGestionDuPersonnel : Form
    {
        private List<Personnel> personnelList;
        private const string placeholderText = "Rechercher";

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="FrmGestionDuPersonnel"/>.
        /// </summary>
        public FrmGestionDuPersonnel()
        {
            InitializeComponent();
            LoadPersonnelData();

            this.txtRechercher.TextChanged += txtRechercher_TextChanged;
            this.txtRechercher.Enter += txtRechercher_Enter;
            this.txtRechercher.Leave += txtRechercher_Leave;
            this.btnEffacerRecherche.Click += btnEffacerRecherche_Click;
            this.pbxAjouterPersonnel.Click += PbxAjouterPersonnel_Click;
            this.pbxModifierPersonnel.Click += PbxModifierPersonnel_Click;

            SetPlaceholder();

            // Initialiser le DataGridView
            InitializeDataGridView();
        }

        /// <summary>
        /// Initialise le DataGridView en ajoutant un gestionnaire d'événements pour la sélection des lignes.
        /// Définit également les couleurs de sélection des lignes.
        /// </summary>
        private void InitializeDataGridView()
        {
            dgvListePersonnel.SelectionChanged += new EventHandler(dgvListePersonnel_SelectionChanged);
            dgvListePersonnel.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgvListePersonnel.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        /// <summary>
        /// Gère l'événement de changement de sélection dans le DataGridView.
        /// Change la couleur de fond et la couleur du texte de la ligne sélectionnée pour la rendre plus visible.
        /// </summary>
        /// <param name="sender">Objet source de l'événement</param>
        /// <param name="e">Arguments de l'événement</param>
        private void dgvListePersonnel_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvListePersonnel.Rows)
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
        /// Charge les données du personnel depuis le contrôleur et les affiche dans le DataGridView.
        /// </summary>
        private void LoadPersonnelData()
        {
            personnelList = PersonnelController.GetPersonnel();
            
            // Trier les personnels par IdPersonnel en ordre croissant.
            personnelList = personnelList.OrderBy(p => p.IdPersonnel).ToList();
            
            DisplayPersonnelData(personnelList);
        }

        /// <summary>
        /// Affiche les données du personnel dans le DataGridView.
        /// </summary>
        /// <param name="list">Liste du personnel à afficher.</param>
        private void DisplayPersonnelData(List<Personnel> list)
        {
            dgvListePersonnel.Rows.Clear();

            foreach (var personnel in list)
            {
                dgvListePersonnel.Rows.Add(
                    personnel.IdPersonnel,
                    personnel.Nom,
                    personnel.Prenom,
                    personnel.IdService,
                    personnel.Tel,
                    personnel.Mail
                );
            }
        }

        /// <summary>
        /// Gestionnaire d'événements pour la modification du texte de recherche.
        /// Filtre les résultats affichés en fonction du terme recherché.
        /// </summary>
        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtRechercher.Text.ToLower();
            var filteredList = personnelList
                .Where(p => p.Nom.ToLower().Contains(searchTerm) || p.Prenom.ToLower().Contains(searchTerm))
                .ToList();
            DisplayPersonnelData(filteredList);
        }

        /// <summary>
        /// Gestionnaire d'événements pour le clic sur le bouton Effacer Recherche.
        /// Réinitialise le champ de recherche et affiche toutes les données du personnel.
        /// </summary>
        private void btnEffacerRecherche_Click(object sender, EventArgs e)
        {
            txtRechercher.Text = string.Empty;
            SetPlaceholder();
            DisplayPersonnelData(personnelList);
        }

        /// <summary>
        /// Gestionnaire d'événements pour l'entrée dans le champ de recherche.
        /// Supprime le placeholder lorsque l'utilisateur clique dans le champ de recherche.
        /// </summary>
        private void txtRechercher_Enter(object sender, EventArgs e)
        {
            if (txtRechercher.Text == placeholderText)
            {
                txtRechercher.Text = string.Empty;
                txtRechercher.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }

        /// <summary>
        /// Gestionnaire d'événements pour la sortie du champ de recherche.
        /// Réinitialise le placeholder lorsque le champ de recherche est vide.
        /// </summary>
        private void txtRechercher_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRechercher.Text))
            {
                SetPlaceholder();
            }
        }

        /// <summary>
        /// Initialise le texte placeholder dans le champ de recherche.
        /// </summary>
        private void SetPlaceholder()
        {
            txtRechercher.Text = placeholderText;
            txtRechercher.ForeColor = System.Drawing.SystemColors.GrayText;
        }

        /// <summary>
        /// Ouvre le formulaire FrmAjouterModifierPersonnel en mode ajout.
        /// </summary>
        private void PbxAjouterPersonnel_Click(object sender, EventArgs e)
        {
            FrmAjouterModifierPersonnel frm = new FrmAjouterModifierPersonnel();
            frm.ShowDialog();

            // Refresh le datagrid
            LoadPersonnelData();
        }

        /// <summary>
        /// Ouvre le formulaire FrmAjouterModifierPersonnel en mode modification.
        /// </summary>
        private void PbxModifierPersonnel_Click(object sender, EventArgs e)
        {
            if (dgvListePersonnel.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvListePersonnel.SelectedRows[0];
                Personnel selectedPersonnel = new Personnel

                {
                    IdPersonnel = (int)selectedRow.Cells["colonneIdPersonnel"].Value,
                    Nom = selectedRow.Cells["colonneNom"].Value.ToString(),
                    Prenom = selectedRow.Cells["colonnePrenom"].Value.ToString(),
                    IdService = (int)selectedRow.Cells["colonneService"].Value,
                    Tel = selectedRow.Cells["colonneTel"].Value.ToString(),
                    Mail = selectedRow.Cells["colonneEmail"].Value.ToString()
                };

                FrmAjouterModifierPersonnel frm = new FrmAjouterModifierPersonnel(selectedPersonnel);
                frm.ShowDialog();

                LoadPersonnelData();
            }
        }

        /// <summary>
        /// Ouvre le formulaire de confirmation de suppression de personnel.
        /// </summary>
        private void pbxSupprimerPersonnel_Click(object sender, EventArgs e)
        {
            if (dgvListePersonnel.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvListePersonnel.SelectedRows[0];
                Personnel selectedPersonnel = new Personnel
                {
                    IdPersonnel = (int)selectedRow.Cells["colonneIdPersonnel"].Value,
                    Nom = selectedRow.Cells["colonneNom"].Value.ToString(),
                    Prenom = selectedRow.Cells["colonnePrenom"].Value.ToString(),
                    IdService = (int)selectedRow.Cells["colonneService"].Value,
                    Tel = selectedRow.Cells["colonneTel"].Value.ToString(),
                    Mail = selectedRow.Cells["colonneEmail"].Value.ToString()
                };

                FrmConfirmerSuppression frm = new FrmConfirmerSuppression(selectedPersonnel);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadPersonnelData();
                }
            }
        }

        /// <summary>
        /// Ouvre le formulaire de gestion des absences pour le personnel sélectionné.
        /// </summary>
        private void pbxGestionAbsence_Click(object sender, EventArgs e)
        {
            if (dgvListePersonnel.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvListePersonnel.SelectedRows[0];
                Personnel selectedPersonnel = new Personnel
                {
                    IdPersonnel = (int)selectedRow.Cells["colonneIdPersonnel"].Value,
                    Nom = selectedRow.Cells["colonneNom"].Value.ToString(),
                    Prenom = selectedRow.Cells["colonnePrenom"].Value.ToString(),
                    IdService = (int)selectedRow.Cells["colonneService"].Value,
                    Tel = selectedRow.Cells["colonneTel"].Value.ToString(),
                    Mail = selectedRow.Cells["colonneEmail"].Value.ToString()
                };

                FrmGestionDesAbsences frm = new FrmGestionDesAbsences(selectedPersonnel);
                frm.ShowDialog();
            }
        }
    }
}
