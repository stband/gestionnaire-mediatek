using System;
using System.Windows.Forms;
using GestionnaireMediatek.Controllers;
using GestionnaireMediatek.Models;

namespace GestionnaireMediatek.Views
{
    public partial class FrmAuthentification : Form
    {
        public FrmAuthentification()
        {
            InitializeComponent();

            // Ajouter des gestionnaires d'événements pour les champs de texte
            txtIdentifiant.Enter += TxtIdentifiant_Enter;
            txtIdentifiant.Leave += TxtIdentifiant_Leave;
            txtMotDePasse.Enter += TxtMotDePasse_Enter;
            txtMotDePasse.Leave += TxtMotDePasse_Leave;

            // Ajouter un gestionnaire d'événements pour le bouton SeConnecter
            btnSeConnecter.Click += btnSeConnecter_Click;

            // Gestionnaire d'événements pour lier la touche entrée au bouton seConnecter
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(FrmAuthentification_KeyPress);
        }

        private void TxtIdentifiant_Enter(object sender, EventArgs e)
        {
            if (txtIdentifiant.Text == "Identifiant")
            {
                txtIdentifiant.Text = "";
                txtIdentifiant.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }

        private void TxtIdentifiant_Leave(object sender, EventArgs e)
        {
            if (txtIdentifiant.Text == "")
            {
                txtIdentifiant.Text = "Identifiant";
                txtIdentifiant.ForeColor = System.Drawing.SystemColors.ScrollBar;
            }
        }

        private void TxtMotDePasse_Enter(object sender, EventArgs e)
        {
            if (txtMotDePasse.Text == "Mot de passe")
            {
                txtMotDePasse.Text = "";
                txtMotDePasse.ForeColor = System.Drawing.SystemColors.WindowText;
                txtMotDePasse.UseSystemPasswordChar = true;
            }
        }

        private void TxtMotDePasse_Leave(object sender, EventArgs e)
        {
            if (txtMotDePasse.Text == "")
            {
                txtMotDePasse.Text = "Mot de passe";
                txtMotDePasse.ForeColor = System.Drawing.SystemColors.ScrollBar;
                txtMotDePasse.UseSystemPasswordChar = false;
            }
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            // Réinitialiser le message d'erreur
            lblGestionErreur.Visible = false;

            // Vérifier si les champs ne sont pas vides
            if (txtIdentifiant.Text == "Identifiant" || txtMotDePasse.Text == "Mot de passe" ||
                string.IsNullOrEmpty(txtIdentifiant.Text) || string.IsNullOrEmpty(txtMotDePasse.Text))
            {
                lblGestionErreur.Text = "Veuillez remplir tous les champs.";
                lblGestionErreur.Visible = true;
                return;
            }

            // Vérifier les informations d'identification
            Responsable responsable = ResponsableController.Authentifier(txtIdentifiant.Text, txtMotDePasse.Text);

            if (responsable != null)
            {
                // Connexion réussie envoie du message au formulaire principal
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                // Afficher un message d'erreur
                lblGestionErreur.Text = "Identifiant ou mot de passe incorrect. Veuillez réessayer.";
                lblGestionErreur.Visible = true;
            }
        }

        // Liaison de la touche entrée au bouton seConnecter pour faciliter la connection
        private void FrmAuthentification_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSeConnecter_Click(sender, e);
            }
        }
    }
}
