namespace GestionnaireMediatek.Views
{
    partial class FrmConfirmerSuppressionOuModification
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblInfoPersonnel = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.panelCouleur = new System.Windows.Forms.Panel();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.panelCouleur.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(-10, 10);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(416, 22);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Êtes-vous sûr de vouloir supprimer cette personne ?";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfoPersonnel
            // 
            this.lblInfoPersonnel.AutoSize = true;
            this.lblInfoPersonnel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoPersonnel.ForeColor = System.Drawing.Color.Black;
            this.lblInfoPersonnel.Location = new System.Drawing.Point(12, 61);
            this.lblInfoPersonnel.Name = "lblInfoPersonnel";
            this.lblInfoPersonnel.Size = new System.Drawing.Size(242, 17);
            this.lblInfoPersonnel.TabIndex = 1;
            this.lblInfoPersonnel.Text = "Nom Prenom - service <nom_service>";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(12, 95);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(185, 25);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // panelCouleur
            // 
            this.panelCouleur.BackColor = System.Drawing.Color.LightCoral;
            this.panelCouleur.Controls.Add(this.lblQuestion);
            this.panelCouleur.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCouleur.Location = new System.Drawing.Point(0, 0);
            this.panelCouleur.Name = "panelCouleur";
            this.panelCouleur.Size = new System.Drawing.Size(392, 45);
            this.panelCouleur.TabIndex = 4;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(195, 95);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(185, 25);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // FrmConfirmerSuppressionOuModification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(392, 132);
            this.ControlBox = false;
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.panelCouleur);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.lblInfoPersonnel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConfirmerSuppressionOuModification";
            this.Text = "Confirmer la suppression";
            this.TopMost = true;
            this.panelCouleur.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblInfoPersonnel;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Panel panelCouleur;
        private System.Windows.Forms.Button btnAnnuler;
    }
}