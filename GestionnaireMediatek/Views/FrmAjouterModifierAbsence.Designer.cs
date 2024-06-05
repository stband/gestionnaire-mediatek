namespace GestionnaireMediatek.Views
{
    partial class FrmAjouterModifierAbsence
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelCouleur = new Panel();
            lblInfo = new Label();
            lblGestionErreur = new Label();
            btnAnnuler = new Button();
            btnAjouter = new Button();
            cbxMotif = new ComboBox();
            dtpDebut = new DateTimePicker();
            dtpFin = new DateTimePicker();
            lblDateDebut = new Label();
            lblDateFin = new Label();
            lblMotif = new Label();
            panelCouleur.SuspendLayout();
            SuspendLayout();
            // 
            // panelCouleur
            // 
            panelCouleur.BackColor = Color.Tan;
            panelCouleur.Controls.Add(lblInfo);
            panelCouleur.Dock = DockStyle.Top;
            panelCouleur.Location = new Point(0, 0);
            panelCouleur.Name = "panelCouleur";
            panelCouleur.Size = new Size(376, 45);
            panelCouleur.TabIndex = 18;
            // 
            // lblInfo
            // 
            lblInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfo.Location = new Point(-4, 8);
            lblInfo.Margin = new Padding(4, 0, 4, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(377, 28);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "Ajouter une absence";
            lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGestionErreur
            // 
            lblGestionErreur.Anchor = AnchorStyles.None;
            lblGestionErreur.BackColor = Color.Transparent;
            lblGestionErreur.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGestionErreur.ForeColor = Color.Red;
            lblGestionErreur.Location = new Point(0, 209);
            lblGestionErreur.Margin = new Padding(4, 0, 4, 0);
            lblGestionErreur.Name = "lblGestionErreur";
            lblGestionErreur.Size = new Size(376, 13);
            lblGestionErreur.TabIndex = 17;
            lblGestionErreur.Text = "lbltext gestion des erreurs";
            lblGestionErreur.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAnnuler
            // 
            btnAnnuler.Location = new Point(190, 175);
            btnAnnuler.Margin = new Padding(4);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(166, 27);
            btnAnnuler.TabIndex = 16;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(21, 175);
            btnAjouter.Margin = new Padding(4);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(166, 27);
            btnAjouter.TabIndex = 15;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            // 
            // cbxMotif
            // 
            cbxMotif.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxMotif.ForeColor = SystemColors.GrayText;
            cbxMotif.FormattingEnabled = true;
            cbxMotif.Items.AddRange(new object[] { "Congé", "Maladie", "...", "..." });
            cbxMotif.Location = new Point(126, 129);
            cbxMotif.Margin = new Padding(4);
            cbxMotif.Name = "cbxMotif";
            cbxMotif.Size = new Size(230, 25);
            cbxMotif.TabIndex = 14;
            cbxMotif.Text = "Motif";
            // 
            // dtpDebut
            // 
            dtpDebut.Location = new Point(126, 58);
            dtpDebut.Name = "dtpDebut";
            dtpDebut.Size = new Size(230, 25);
            dtpDebut.TabIndex = 19;
            // 
            // dtpFin
            // 
            dtpFin.Location = new Point(126, 94);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(230, 25);
            dtpFin.TabIndex = 20;
            // 
            // lblDateDebut
            // 
            lblDateDebut.AutoSize = true;
            lblDateDebut.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateDebut.Location = new Point(18, 61);
            lblDateDebut.Name = "lblDateDebut";
            lblDateDebut.Size = new Size(102, 17);
            lblDateDebut.TabIndex = 21;
            lblDateDebut.Text = "Date de début :";
            // 
            // lblDateFin
            // 
            lblDateFin.AutoSize = true;
            lblDateFin.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateFin.Location = new Point(18, 96);
            lblDateFin.Name = "lblDateFin";
            lblDateFin.Size = new Size(81, 17);
            lblDateFin.TabIndex = 22;
            lblDateFin.Text = "Date de fin :";
            // 
            // lblMotif
            // 
            lblMotif.AutoSize = true;
            lblMotif.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMotif.Location = new Point(18, 132);
            lblMotif.Name = "lblMotif";
            lblMotif.Size = new Size(47, 17);
            lblMotif.TabIndex = 23;
            lblMotif.Text = "Motif :";
            // 
            // FrmAjouterModifierAbsence
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 229);
            Controls.Add(lblMotif);
            Controls.Add(lblDateFin);
            Controls.Add(lblDateDebut);
            Controls.Add(dtpFin);
            Controls.Add(dtpDebut);
            Controls.Add(panelCouleur);
            Controls.Add(lblGestionErreur);
            Controls.Add(btnAnnuler);
            Controls.Add(btnAjouter);
            Controls.Add(cbxMotif);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmAjouterModifierAbsence";
            Text = "Form1";
            panelCouleur.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelCouleur;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblGestionErreur;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ComboBox cbxMotif;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblMotif;
    }
}