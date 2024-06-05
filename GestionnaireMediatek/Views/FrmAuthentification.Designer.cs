namespace GestionnaireMediatek.Views
{
    partial class FrmAuthentification
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            txtIdentifiant = new TextBox();
            txtMotDePasse = new TextBox();
            btnSeConnecter = new Button();
            pbxLogo = new PictureBox();
            lblGestionErreur = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            SuspendLayout();
            // 
            // txtIdentifiant
            // 
            txtIdentifiant.BackColor = SystemColors.Window;
            txtIdentifiant.ForeColor = SystemColors.ScrollBar;
            txtIdentifiant.Location = new Point(93, 119);
            txtIdentifiant.Margin = new Padding(4);
            txtIdentifiant.Name = "txtIdentifiant";
            txtIdentifiant.Size = new Size(209, 25);
            txtIdentifiant.TabIndex = 0;
            txtIdentifiant.Text = "Identifiant";
            // 
            // txtMotDePasse
            // 
            txtMotDePasse.BackColor = SystemColors.Window;
            txtMotDePasse.ForeColor = SystemColors.ScrollBar;
            txtMotDePasse.Location = new Point(93, 149);
            txtMotDePasse.Margin = new Padding(4);
            txtMotDePasse.Name = "txtMotDePasse";
            txtMotDePasse.Size = new Size(209, 25);
            txtMotDePasse.TabIndex = 1;
            txtMotDePasse.Text = "Mot de passe";
            // 
            // btnSeConnecter
            // 
            btnSeConnecter.Location = new Point(93, 179);
            btnSeConnecter.Margin = new Padding(4);
            btnSeConnecter.Name = "btnSeConnecter";
            btnSeConnecter.Size = new Size(210, 30);
            btnSeConnecter.TabIndex = 2;
            btnSeConnecter.Text = "Se connecter";
            btnSeConnecter.UseVisualStyleBackColor = true;
            btnSeConnecter.Click += btnSeConnecter_Click;
            // 
            // pbxLogo
            // 
            pbxLogo.Image = Properties.Resources.logo_mediatek;
            pbxLogo.Location = new Point(41, -97);
            pbxLogo.Margin = new Padding(4);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new Size(296, 285);
            pbxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxLogo.TabIndex = 3;
            pbxLogo.TabStop = false;
            // 
            // lblGestionErreur
            // 
            lblGestionErreur.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGestionErreur.ForeColor = Color.Red;
            lblGestionErreur.Location = new Point(12, 219);
            lblGestionErreur.Name = "lblGestionErreur";
            lblGestionErreur.Size = new Size(376, 13);
            lblGestionErreur.TabIndex = 4;
            lblGestionErreur.Text = "Identifiant ou mot de passe incorrect. Veuillez réessayer.";
            lblGestionErreur.TextAlign = ContentAlignment.MiddleCenter;
            lblGestionErreur.Visible = false;
            // 
            // FrmAuthentification
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(400, 247);
            Controls.Add(lblGestionErreur);
            Controls.Add(btnSeConnecter);
            Controls.Add(txtMotDePasse);
            Controls.Add(txtIdentifiant);
            Controls.Add(pbxLogo);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FrmAuthentification";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Authentification";
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.Button btnSeConnecter;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lblGestionErreur;
    }
}

