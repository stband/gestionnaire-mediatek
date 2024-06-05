using System;
using System.Windows.Forms;
using GestionnaireMediatek.Controllers;
using GestionnaireMediatek.Models;

namespace GestionnaireMediatek.Views
{
    /// <summary>
    /// Formulaire pour l'authentification du responsable.
    /// </summary>
    public partial class FrmAuthentification : Form
    {
        /// <summary>
        /// Initialise une nouvelle instance du formulaire d'authentification.
        /// </summary>
        public FrmAuthentification()
        {
            InitializeComponent();

            // Ajouter des gestionnaires d'événements pour les champs de texte.
            txtIdentifiant.Enter += TxtIdentifiant_Enter;
            txtIdentifiant.Leave += TxtIdentifiant_Leave;
            txtMotDePasse.Enter += TxtMotDePasse_Enter;
            txtMotDePasse.Leave += TxtMotDePasse_Leave;

            // Ajouter un gestionnaire d'événements pour le bouton SeConnecter.
            btnSeConnecter.Click += btnSeConnecter_Click;

            // Gestionnaire d'événements pour lier la touche entrée au bouton SeConnecter.
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(FrmAuthentification_KeyPress);
        }

        /// <summary>
        /// Événement déclenché lors de l'entrée dans le champ Identifiant.
        /// </summary>
        private void TxtIdentifiant_Enter(object sender, EventArgs e)
        {
            if (txtIdentifiant.Text == "Identifiant")
            {
                txtIdentifiant.Text = "";
                txtIdentifiant.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }

        /// <summary>
        /// Événement déclenché lors de la sortie du champ Identifiant.
        /// </summary>
        private void TxtIdentifiant_Leave(object sender, EventArgs e)
        {
            if (txtIdentifiant.Text == "")
            {
                txtIdentifiant.Text = "Identifiant";
                txtIdentifiant.ForeColor = System.Drawing.SystemColors.ScrollBar;
            }
        }

        /// <summary>
        /// Événement déclenché lors de l'entrée dans le champ Mot de Passe.
        /// </summary>
        private void TxtMotDePasse_Enter(object sender, EventArgs e)
        {
            if (txtMotDePasse.Text == "Mot de passe")
            {
                txtMotDePasse.Text = "";
                txtMotDePasse.ForeColor = System.Drawing.SystemColors.WindowText;
                txtMotDePasse.UseSystemPasswordChar = true;
            }
        }

        /// <summary>
        /// Événement déclenché lors de la sortie du champ Mot de Passe.
        /// </summary>
        private void TxtMotDePasse_Leave(object sender, EventArgs e)
        {
            if (txtMotDePasse.Text == "")
            {
                txtMotDePasse.Text = "Mot de passe";
                txtMotDePasse.ForeColor = System.Drawing.SystemColors.ScrollBar;
                txtMotDePasse.UseSystemPasswordChar = false;
            }
        }

        /// <summary>
        /// Gestionnaire d'événements pour le clic sur le bouton Se Connecter.
        /// </summary>
        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            // Réinitialiser le message d'erreur.
            lblGestionErreur.Visible = false;

            // Vérifier si les champs ne sont pas vides.
            if (txtIdentifiant.Text == "Identifiant" || txtMotDePasse.Text == "Mot de passe" ||
                string.IsNullOrEmpty(txtIdentifiant.Text) || string.IsNullOrEmpty(txtMotDePasse.Text))
            {
                lblGestionErreur.Text = "Veuillez remplir tous les champs.";
                lblGestionErreur.Visible = true;
                return;
            }

            // Vérifier les informations d'identification.
            Responsable responsable = ResponsableController.Authentifier(txtIdentifiant.Text, txtMotDePasse.Text);

            if (responsable != null)
            {
                // Connexion réussie envoie du message au formulaire principal.
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                // Sinon affiche un message d'erreur.
                lblGestionErreur.Text = "Identifiant ou mot de passe incorrect. Veuillez réessayer.";
                lblGestionErreur.Visible = true;
            }
        }

        /// <summary>
        /// Liaison de la touche entrée au bouton Se Connecter pour faciliter la connexion.
        /// </summary>
        private void FrmAuthentification_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSeConnecter_Click(sender, e);
            }
        }
    }
}
