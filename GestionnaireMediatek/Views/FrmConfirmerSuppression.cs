using GestionnaireMediatek.Controllers;
using GestionnaireMediatek.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionnaireMediatek.Views
{
    /// <summary>
    /// Formulaire de confirmation pour la suppression d'un personnel.
    /// </summary>
    public partial class FrmConfirmerSuppression : Form
    {
        private readonly Personnel personnel;

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="FrmConfirmerSuppression"/>.
        /// </summary>
        /// <param name="personnel">L'objet <see cref="Personnel"/> représentant le personnel à supprimer.</param>
        public FrmConfirmerSuppression(Personnel personnel)
        {
            InitializeComponent();
            this.personnel = personnel;
            lblInfoPersonnel.Text = $"{personnel.Nom} {personnel.Prenom} - service {personnel.IdService}";
            btnSupprimer.Click += BtnSupprimer_Click;
            btnAnnuler.Click += BtnAnnuler_Click;
        }

        /// <summary>
        /// Gestionnaire d'événements pour le clic sur le bouton Supprimer.
        /// </summary>
        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            PersonnelController.DeletePersonnel(personnel.IdPersonnel);
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
