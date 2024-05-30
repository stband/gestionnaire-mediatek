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

            // Initialisation du texte placeholder
            SetPlaceholder();
        }

        private void LoadPersonnelData()
        {
            personnelList = PersonnelController.GetPersonnel();
            DisplayPersonnelData(personnelList);
        }

        private void DisplayPersonnelData(List<Personnel> list)
        {
            dgvListePersonnel.Rows.Clear();

            foreach (var personnel in list)
            {
                dgvListePersonnel.Rows.Add(
                    personnel.Nom,
                    personnel.Prenom,
                    personnel.IdService, // Affichez le nom du service si nécessaire
                    personnel.Tel,
                    personnel.Mail
                // Ajoutez des images ou des icônes pour les actions de modification/suppression si nécessaire
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
    }
}
