using GestionnaireMediatek.Controllers;
using GestionnaireMediatek.Models;

namespace GestionnaireMediatek.Views
{
    public partial class FrmAjouterModifierAbsence : Form
    {
        private readonly Personnel personnel;

        public FrmAjouterModifierAbsence(Personnel personnel)
        {
            InitializeComponent();
            this.personnel = personnel;
            lblInfo.Text = $"Ajouter une absence pour {personnel.Nom} {personnel.Prenom}";
            LoadMotifs();
            btnAjouter.Click += BtnAjouter_Click;
            btnAnnuler.Click += BtnAnnuler_Click;
        }

        private void LoadMotifs()
        {
            var motifs = PersonnelController.GetMotifs();
            cbxMotif.DataSource = motifs;
            cbxMotif.DisplayMember = "Libelle";
            cbxMotif.ValueMember = "IdMotif";
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                var absence = new Absence
                {
                    IdPersonnel = personnel.IdPersonnel,
                    DateDebut = dtpDebut.Value,
                    DateFin = dtpFin.Value,
                    IdMotif = (int)cbxMotif.SelectedValue
                };

                PersonnelController.AddAbsence(absence);
                this.Close();
            }
            else
            {
                lblGestionErreur.Text = "Tous les champs doivent être remplis.";
                lblGestionErreur.Visible = true;
            }
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateFields()
        {
            return dtpDebut.Value != null && dtpFin.Value != null && cbxMotif.SelectedValue != null;
        }
    }
}
