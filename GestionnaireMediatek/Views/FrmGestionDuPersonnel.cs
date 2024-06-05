using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GestionnaireMediatek.Controllers;
using GestionnaireMediatek.Models;

namespace GestionnaireMediatek.Views
{
    public partial class FrmGestionDuPersonnel : Form
    {
        private List<Personnel> personnelList;
        private const string placeholderText = "Rechercher";

        public FrmGestionDuPersonnel()
        {
            InitializeComponent();
            LoadPersonnelData();

            // Ajout des gestionnaires d'événements
            this.txtRechercher.TextChanged += txtRechercher_TextChanged;
            this.txtRechercher.Enter += txtRechercher_Enter;
            this.txtRechercher.Leave += txtRechercher_Leave;
            this.btnEffacerRecherche.Click += btnEffacerRecherche_Click;
            this.pbxAjouterPersonnel.Click += PbxAjouterPersonnel_Click;
            this.pbxModifierPersonnel.Click += PbxModifierPersonnel_Click;

            // Initialisation du texte placeholder
            SetPlaceholder();
        }

        private void LoadPersonnelData()
        {
            personnelList = PersonnelController.GetPersonnel();
            
            // Trier les personnels par IdPersonnel en ordre croissant
            personnelList = personnelList.OrderBy(p => p.IdPersonnel).ToList();
            
            DisplayPersonnelData(personnelList);
        }

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

        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtRechercher.Text.ToLower();
            var filteredList = personnelList
                .Where(p => p.Nom.ToLower().Contains(searchTerm) || p.Prenom.ToLower().Contains(searchTerm))
                .ToList();
            DisplayPersonnelData(filteredList);
        }

        private void btnEffacerRecherche_Click(object sender, EventArgs e)
        {
            txtRechercher.Text = string.Empty;
            SetPlaceholder();
            DisplayPersonnelData(personnelList);
        }

        private void txtRechercher_Enter(object sender, EventArgs e)
        {
            if (txtRechercher.Text == placeholderText)
            {
                txtRechercher.Text = string.Empty;
                txtRechercher.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }

        private void txtRechercher_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRechercher.Text))
            {
                SetPlaceholder();
            }
        }

        private void SetPlaceholder()
        {
            txtRechercher.Text = placeholderText;
            txtRechercher.ForeColor = System.Drawing.SystemColors.GrayText;
        }

        // Ouvre le FrmAjouterModifierPersonnel en mode Ajout
        private void PbxAjouterPersonnel_Click(object sender, EventArgs e)
        {
            FrmAjouterModifierPersonnel frm = new FrmAjouterModifierPersonnel();
            frm.ShowDialog();

            // Refresh le datagrid
            LoadPersonnelData();
        }

        // Ouvre le FrmAjouterModifierPersonnel en mode modification
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

                // Refresh le datagrid
                LoadPersonnelData();
            }
        }
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
                    LoadPersonnelData(); // Refresh le datagrid
                }
            }
        }

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