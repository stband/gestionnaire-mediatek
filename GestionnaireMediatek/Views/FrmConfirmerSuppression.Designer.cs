namespace GestionnaireMediatek.Views
{
    partial class FrmConfirmerSuppression
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
            lblQuestion = new Label();
            lblInfoPersonnel = new Label();
            btnSupprimer = new Button();
            panelCouleur = new Panel();
            btnAnnuler = new Button();
            panelCouleur.SuspendLayout();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestion.Location = new Point(-12, 12);
            lblQuestion.Margin = new Padding(4, 0, 4, 0);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(485, 25);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "Êtes-vous sûr de vouloir supprimer ce personnel ?";
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInfoPersonnel
            // 
            lblInfoPersonnel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblInfoPersonnel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfoPersonnel.ForeColor = Color.Black;
            lblInfoPersonnel.Location = new Point(0, 68);
            lblInfoPersonnel.Margin = new Padding(4, 0, 4, 0);
            lblInfoPersonnel.Name = "lblInfoPersonnel";
            lblInfoPersonnel.Size = new Size(457, 17);
            lblInfoPersonnel.TabIndex = 1;
            lblInfoPersonnel.Text = "Nom Prenom - service <nom_service>";
            lblInfoPersonnel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSupprimer.Location = new Point(15, 101);
            btnSupprimer.Margin = new Padding(4, 3, 4, 3);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(216, 29);
            btnSupprimer.TabIndex = 2;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // panelCouleur
            // 
            panelCouleur.BackColor = Color.LightCoral;
            panelCouleur.Controls.Add(lblQuestion);
            panelCouleur.Dock = DockStyle.Top;
            panelCouleur.Location = new Point(0, 0);
            panelCouleur.Margin = new Padding(4, 3, 4, 3);
            panelCouleur.Name = "panelCouleur";
            panelCouleur.Size = new Size(457, 52);
            panelCouleur.TabIndex = 4;
            // 
            // btnAnnuler
            // 
            btnAnnuler.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnnuler.Location = new Point(228, 101);
            btnAnnuler.Margin = new Padding(4, 3, 4, 3);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(216, 29);
            btnAnnuler.TabIndex = 5;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // FrmConfirmerSuppression
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(457, 141);
            ControlBox = false;
            Controls.Add(btnAnnuler);
            Controls.Add(panelCouleur);
            Controls.Add(btnSupprimer);
            Controls.Add(lblInfoPersonnel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmConfirmerSuppression";
            StartPosition = FormStartPosition.CenterScreen;
            TopMost = true;
            panelCouleur.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblInfoPersonnel;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Panel panelCouleur;
        private System.Windows.Forms.Button btnAnnuler;
    }
}