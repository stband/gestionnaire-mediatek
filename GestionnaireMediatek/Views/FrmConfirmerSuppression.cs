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
    public partial class FrmConfirmerSuppression : Form
    {
        private readonly Personnel personnel;

        public FrmConfirmerSuppression(Personnel personnel)
        {
            InitializeComponent();
            this.personnel = personnel;
            lblInfoPersonnel.Text = $"{personnel.Nom} {personnel.Prenom} - service {personnel.IdService}";
            btnSupprimer.Click += BtnSupprimer_Click;
            btnAnnuler.Click += BtnAnnuler_Click;
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            PersonnelController.DeletePersonnel(personnel.IdPersonnel);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
