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
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.btnSeConnecter = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.txtGestionErreur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdentifiant.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIdentifiant.Location = new System.Drawing.Point(93, 119);
            this.txtIdentifiant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(209, 25);
            this.txtIdentifiant.TabIndex = 0;
            this.txtIdentifiant.Text = "Identifiant";
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.BackColor = System.Drawing.SystemColors.Window;
            this.txtMotDePasse.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMotDePasse.Location = new System.Drawing.Point(93, 149);
            this.txtMotDePasse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.Size = new System.Drawing.Size(209, 25);
            this.txtMotDePasse.TabIndex = 1;
            this.txtMotDePasse.Text = "Mot de passe";
            // 
            // btnSeConnecter
            // 
            this.btnSeConnecter.Location = new System.Drawing.Point(93, 179);
            this.btnSeConnecter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSeConnecter.Name = "btnSeConnecter";
            this.btnSeConnecter.Size = new System.Drawing.Size(210, 30);
            this.btnSeConnecter.TabIndex = 2;
            this.btnSeConnecter.Text = "Se connecter";
            this.btnSeConnecter.UseVisualStyleBackColor = true;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::GestionnaireMediatek.Properties.Resources.logo_mediatek;
            this.pbxLogo.Location = new System.Drawing.Point(41, -97);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(296, 285);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 3;
            this.pbxLogo.TabStop = false;
            // 
            // txtGestionErreur
            // 
            this.txtGestionErreur.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGestionErreur.ForeColor = System.Drawing.Color.Red;
            this.txtGestionErreur.Location = new System.Drawing.Point(12, 219);
            this.txtGestionErreur.Name = "txtGestionErreur";
            this.txtGestionErreur.Size = new System.Drawing.Size(376, 13);
            this.txtGestionErreur.TabIndex = 4;
            this.txtGestionErreur.Text = "Identifiant ou mot de passe incorrect. Veuillez réessayer.";
            this.txtGestionErreur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtGestionErreur.Visible = false;
            // 
            // FrmAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(400, 247);
            this.Controls.Add(this.txtGestionErreur);
            this.Controls.Add(this.btnSeConnecter);
            this.Controls.Add(this.txtMotDePasse);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.pbxLogo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAuthentification";
            this.Text = "Authentification";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.Button btnSeConnecter;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label txtGestionErreur;
    }
}

