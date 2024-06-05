using System;
using System.Windows.Forms;

namespace GestionnaireMediatek.Views
{
    public partial class FrmConfirmerModification : Form
    {
        public FrmConfirmerModification()
        {
            InitializeComponent();
            btnConfirmer.Click += BtnConfirmer_Click;
            btnAnnuler.Click += BtnAnnuler_Click;
        }

        private void BtnConfirmer_Click(object sender, EventArgs e)
        {
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
