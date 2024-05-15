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
            this.panelCouleur = new System.Windows.Forms.Panel();
            this.txtInfo = new System.Windows.Forms.Label();
            this.lblGestionErreur = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.cbxMotif = new System.Windows.Forms.ComboBox();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            this.panelCouleur.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCouleur
            // 
            this.panelCouleur.BackColor = System.Drawing.Color.Tan;
            this.panelCouleur.Controls.Add(this.txtInfo);
            this.panelCouleur.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCouleur.Location = new System.Drawing.Point(0, 0);
            this.panelCouleur.Name = "panelCouleur";
            this.panelCouleur.Size = new System.Drawing.Size(376, 45);
            this.panelCouleur.TabIndex = 18;
            // 
            // txtInfo
            // 
            this.txtInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.Location = new System.Drawing.Point(-4, 8);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(377, 28);
            this.txtInfo.TabIndex = 0;
            this.txtInfo.Text = "Ajouter une absence";
            this.txtInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGestionErreur
            // 
            this.lblGestionErreur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGestionErreur.BackColor = System.Drawing.Color.Transparent;
            this.lblGestionErreur.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionErreur.ForeColor = System.Drawing.Color.Red;
            this.lblGestionErreur.Location = new System.Drawing.Point(0, 216);
            this.lblGestionErreur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGestionErreur.Name = "lblGestionErreur";
            this.lblGestionErreur.Size = new System.Drawing.Size(376, 13);
            this.lblGestionErreur.TabIndex = 17;
            this.lblGestionErreur.Text = "lbltext gestion des erreurs";
            this.lblGestionErreur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(190, 175);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(166, 27);
            this.btnAnnuler.TabIndex = 16;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(21, 175);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(166, 27);
            this.btnAjouter.TabIndex = 15;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // cbxMotif
            // 
            this.cbxMotif.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMotif.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbxMotif.FormattingEnabled = true;
            this.cbxMotif.Items.AddRange(new object[] {
            "Congé",
            "Maladie",
            "...",
            "..."});
            this.cbxMotif.Location = new System.Drawing.Point(126, 129);
            this.cbxMotif.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMotif.Name = "cbxMotif";
            this.cbxMotif.Size = new System.Drawing.Size(230, 25);
            this.cbxMotif.TabIndex = 14;
            this.cbxMotif.Text = "Motif";
            // 
            // dtpDebut
            // 
            this.dtpDebut.Location = new System.Drawing.Point(126, 58);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(230, 25);
            this.dtpDebut.TabIndex = 19;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(126, 94);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(230, 25);
            this.dtpFin.TabIndex = 20;
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDebut.Location = new System.Drawing.Point(18, 61);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(102, 17);
            this.lblDateDebut.TabIndex = 21;
            this.lblDateDebut.Text = "Date de début :";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFin.Location = new System.Drawing.Point(18, 96);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(81, 17);
            this.lblDateFin.TabIndex = 22;
            this.lblDateFin.Text = "Date de fin :";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotif.Location = new System.Drawing.Point(18, 132);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(47, 17);
            this.lblMotif.TabIndex = 23;
            this.lblMotif.Text = "Motif :";
            // 
            // FrmAjouterModifierAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 243);
            this.Controls.Add(this.lblMotif);
            this.Controls.Add(this.lblDateFin);
            this.Controls.Add(this.lblDateDebut);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpDebut);
            this.Controls.Add(this.panelCouleur);
            this.Controls.Add(this.lblGestionErreur);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cbxMotif);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAjouterModifierAbsence";
            this.Text = "Form1";
            this.panelCouleur.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCouleur;
        private System.Windows.Forms.Label txtInfo;
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