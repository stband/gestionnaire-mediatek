namespace GestionnaireMediatek.Views
{
    partial class FrmAjouterModifierPersonnel
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
            this.txtInfo = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.cbxServiceAffectation = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblGestionErreur = new System.Windows.Forms.Label();
            this.panelCouleur = new System.Windows.Forms.Panel();
            this.panelCouleur.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInfo
            // 
            this.txtInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.Location = new System.Drawing.Point(-4, 8);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(377, 28);
            this.txtInfo.TabIndex = 0;
            this.txtInfo.Text = "Informations du personnel à ajouter";
            this.txtInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtNom.Location = new System.Drawing.Point(21, 60);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(335, 25);
            this.txtNom.TabIndex = 1;
            this.txtNom.Text = "Nom";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtPrenom.Location = new System.Drawing.Point(21, 93);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(335, 25);
            this.txtPrenom.TabIndex = 2;
            this.txtPrenom.Text = "Prenom";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtTel.Location = new System.Drawing.Point(21, 126);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(335, 25);
            this.txtTel.TabIndex = 3;
            this.txtTel.Text = "Tel";
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtMail.Location = new System.Drawing.Point(21, 159);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(335, 25);
            this.txtMail.TabIndex = 4;
            this.txtMail.Text = "Mail";
            // 
            // cbxServiceAffectation
            // 
            this.cbxServiceAffectation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxServiceAffectation.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbxServiceAffectation.FormattingEnabled = true;
            this.cbxServiceAffectation.Items.AddRange(new object[] {
            "Administratif",
            "jsp",
            "autre",
            ""});
            this.cbxServiceAffectation.Location = new System.Drawing.Point(21, 192);
            this.cbxServiceAffectation.Margin = new System.Windows.Forms.Padding(4);
            this.cbxServiceAffectation.Name = "cbxServiceAffectation";
            this.cbxServiceAffectation.Size = new System.Drawing.Size(335, 25);
            this.cbxServiceAffectation.TabIndex = 5;
            this.cbxServiceAffectation.Text = "Service d\'affectation";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(21, 230);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(166, 27);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(190, 230);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(166, 27);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // lblGestionErreur
            // 
            this.lblGestionErreur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGestionErreur.BackColor = System.Drawing.Color.Transparent;
            this.lblGestionErreur.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionErreur.ForeColor = System.Drawing.Color.Red;
            this.lblGestionErreur.Location = new System.Drawing.Point(21, 267);
            this.lblGestionErreur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGestionErreur.Name = "lblGestionErreur";
            this.lblGestionErreur.Size = new System.Drawing.Size(335, 13);
            this.lblGestionErreur.TabIndex = 8;
            this.lblGestionErreur.Text = "lbltext gestion des erreurs";
            this.lblGestionErreur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCouleur
            // 
            this.panelCouleur.BackColor = System.Drawing.Color.Tan;
            this.panelCouleur.Controls.Add(this.txtInfo);
            this.panelCouleur.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCouleur.Location = new System.Drawing.Point(0, 0);
            this.panelCouleur.Name = "panelCouleur";
            this.panelCouleur.Size = new System.Drawing.Size(376, 45);
            this.panelCouleur.TabIndex = 9;
            // 
            // FrmAjouterModifierPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(376, 298);
            this.Controls.Add(this.panelCouleur);
            this.Controls.Add(this.lblGestionErreur);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cbxServiceAffectation);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAjouterModifierPersonnel";
            this.Text = "Ajouter un nouveau personnel";
            this.panelCouleur.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtInfo;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.ComboBox cbxServiceAffectation;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblGestionErreur;
        private System.Windows.Forms.Panel panelCouleur;
    }
}