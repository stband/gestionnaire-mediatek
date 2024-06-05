namespace GestionnaireMediatek.Views
{
    partial class FrmConfirmerSuppressionAbsence
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
            lblQuestion = new Label();
            lblInfoHeader = new Label();
            btnSupprimer = new Button();
            lblInfoDebut = new Label();
            lblInfoFin = new Label();
            lblInfoMotif = new Label();
            btnAnnuler = new Button();
            panelCouleur.SuspendLayout();
            SuspendLayout();
            // 
            // panelCouleur
            // 
            panelCouleur.BackColor = Color.LightCoral;
            panelCouleur.Controls.Add(lblQuestion);
            panelCouleur.Dock = DockStyle.Top;
            panelCouleur.Location = new Point(0, 0);
            panelCouleur.Name = "panelCouleur";
            panelCouleur.Size = new Size(392, 45);
            panelCouleur.TabIndex = 8;
            // 
            // lblQuestion
            // 
            lblQuestion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestion.Location = new Point(0, 11);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(392, 22);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "Êtes-vous sûr de vouloir supprimer cette absence ?";
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInfoHeader
            // 
            lblInfoHeader.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfoHeader.ForeColor = Color.Black;
            lblInfoHeader.Location = new Point(0, 62);
            lblInfoHeader.Name = "lblInfoHeader";
            lblInfoHeader.Size = new Size(392, 17);
            lblInfoHeader.TabIndex = 5;
            lblInfoHeader.Text = "Début                    Fin                    Motif";
            lblInfoHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSupprimer.Location = new Point(12, 114);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(185, 29);
            btnSupprimer.TabIndex = 9;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // lblInfoDebut
            // 
            lblInfoDebut.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfoDebut.ForeColor = Color.Red;
            lblInfoDebut.Location = new Point(40, 80);
            lblInfoDebut.Name = "lblInfoDebut";
            lblInfoDebut.Size = new Size(99, 17);
            lblInfoDebut.TabIndex = 10;
            lblInfoDebut.Text = "AAAA-MM-DD";
            lblInfoDebut.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInfoFin
            // 
            lblInfoFin.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfoFin.ForeColor = Color.Red;
            lblInfoFin.Location = new Point(147, 80);
            lblInfoFin.Name = "lblInfoFin";
            lblInfoFin.Size = new Size(99, 17);
            lblInfoFin.TabIndex = 11;
            lblInfoFin.Text = "AAAA-MM-DD";
            lblInfoFin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInfoMotif
            // 
            lblInfoMotif.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfoMotif.ForeColor = Color.Red;
            lblInfoMotif.Location = new Point(252, 80);
            lblInfoMotif.Name = "lblInfoMotif";
            lblInfoMotif.Size = new Size(99, 17);
            lblInfoMotif.TabIndex = 12;
            lblInfoMotif.Text = "Maladie";
            lblInfoMotif.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAnnuler
            // 
            btnAnnuler.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnnuler.Location = new Point(195, 114);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(185, 29);
            btnAnnuler.TabIndex = 13;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // FrmConfirmerSuppressionAbsence
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 153);
            Controls.Add(btnAnnuler);
            Controls.Add(lblInfoMotif);
            Controls.Add(lblInfoFin);
            Controls.Add(lblInfoDebut);
            Controls.Add(btnSupprimer);
            Controls.Add(panelCouleur);
            Controls.Add(lblInfoHeader);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmConfirmerSuppressionAbsence";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelCouleur.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelCouleur;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblInfoHeader;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label lblInfoDebut;
        private System.Windows.Forms.Label lblInfoFin;
        private System.Windows.Forms.Label lblInfoMotif;
        private System.Windows.Forms.Button btnAnnuler;
    }
}