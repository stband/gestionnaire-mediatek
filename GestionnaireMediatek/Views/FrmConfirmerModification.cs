using System;
using System.Windows.Forms;

namespace GestionnaireMediatek.Views
{
    /// <summary>
    /// Formulaire de confirmation pour les modifications.
    /// S'applique à : FrmAjouterModifierPersonnel et FrmAjouterModifierAbsence.
    /// </summary>
    public partial class FrmConfirmerModification : Form
    {
        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="FrmConfirmerModification"/>.
        /// </summary>
        public FrmConfirmerModification()
        {
            InitializeComponent();
            btnConfirmer.Click += BtnConfirmer_Click;
            btnAnnuler.Click += BtnAnnuler_Click;
        }

        /// <summary>
        /// Gestionnaire d'événements pour le clic sur le bouton Confirmer.
        /// </summary>
        private void BtnConfirmer_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Gestionnaire d'événements pour le clic sur le bouton Annuler.
        /// </summary>
        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
