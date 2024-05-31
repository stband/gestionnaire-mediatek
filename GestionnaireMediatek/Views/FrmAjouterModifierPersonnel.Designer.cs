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
            lblInfo = new Label();
            txtNom = new TextBox();
            txtPrenom = new TextBox();
            txtTel = new TextBox();
            txtMail = new TextBox();
            cbxServiceAffectation = new ComboBox();
            btnAjouter = new Button();
            btnAnnuler = new Button();
            lblGestionErreur = new Label();
            panelCouleur = new Panel();
            panelCouleur.SuspendLayout();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfo.Location = new Point(-4, 8);
            lblInfo.Margin = new Padding(4, 0, 4, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(377, 28);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "Informations du personnel à ajouter";
            lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNom
            // 
            txtNom.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNom.ForeColor = SystemColors.GrayText;
            txtNom.Location = new Point(21, 60);
            txtNom.Margin = new Padding(4);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(335, 25);
            txtNom.TabIndex = 1;
            txtNom.Text = "Nom";
            // 
            // txtPrenom
            // 
            txtPrenom.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrenom.ForeColor = SystemColors.GrayText;
            txtPrenom.Location = new Point(21, 93);
            txtPrenom.Margin = new Padding(4);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(335, 25);
            txtPrenom.TabIndex = 2;
            txtPrenom.Text = "Prenom";
            // 
            // txtTel
            // 
            txtTel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTel.ForeColor = SystemColors.GrayText;
            txtTel.Location = new Point(21, 126);
            txtTel.Margin = new Padding(4);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(335, 25);
            txtTel.TabIndex = 3;
            txtTel.Text = "Tel";
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMail.ForeColor = SystemColors.GrayText;
            txtMail.Location = new Point(21, 159);
            txtMail.Margin = new Padding(4);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(335, 25);
            txtMail.TabIndex = 4;
            txtMail.Text = "Mail";
            // 
            // cbxServiceAffectation
            // 
            cbxServiceAffectation.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxServiceAffectation.ForeColor = SystemColors.GrayText;
            cbxServiceAffectation.FormattingEnabled = true;
            cbxServiceAffectation.Items.AddRange(new object[] { "Administratif", "jsp", "autre", "" });
            cbxServiceAffectation.Location = new Point(21, 192);
            cbxServiceAffectation.Margin = new Padding(4);
            cbxServiceAffectation.Name = "cbxServiceAffectation";
            cbxServiceAffectation.Size = new Size(335, 25);
            cbxServiceAffectation.TabIndex = 5;
            cbxServiceAffectation.Text = "Service d'affectation";
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(21, 230);
            btnAjouter.Margin = new Padding(4);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(166, 27);
            btnAjouter.TabIndex = 6;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            btnAnnuler.Location = new Point(190, 230);
            btnAnnuler.Margin = new Padding(4);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(166, 27);
            btnAnnuler.TabIndex = 7;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = true;
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // lblGestionErreur
            // 
            lblGestionErreur.Anchor = AnchorStyles.None;
            lblGestionErreur.BackColor = Color.Transparent;
            lblGestionErreur.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGestionErreur.ForeColor = Color.Red;
            lblGestionErreur.Location = new Point(21, 267);
            lblGestionErreur.Margin = new Padding(4, 0, 4, 0);
            lblGestionErreur.Name = "lblGestionErreur";
            lblGestionErreur.Size = new Size(335, 13);
            lblGestionErreur.TabIndex = 8;
            lblGestionErreur.Text = "lbltext gestion des erreurs";
            lblGestionErreur.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelCouleur
            // 
            panelCouleur.BackColor = Color.Tan;
            panelCouleur.Controls.Add(lblInfo);
            panelCouleur.Dock = DockStyle.Top;
            panelCouleur.Location = new Point(0, 0);
            panelCouleur.Name = "panelCouleur";
            panelCouleur.Size = new Size(376, 45);
            panelCouleur.TabIndex = 9;
            // 
            // FrmAjouterModifierPersonnel
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(376, 298);
            Controls.Add(panelCouleur);
            Controls.Add(lblGestionErreur);
            Controls.Add(btnAnnuler);
            Controls.Add(btnAjouter);
            Controls.Add(cbxServiceAffectation);
            Controls.Add(txtMail);
            Controls.Add(txtTel);
            Controls.Add(txtPrenom);
            Controls.Add(txtNom);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmAjouterModifierPersonnel";
            Text = "Ajouter un nouveau personnel";
            panelCouleur.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
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