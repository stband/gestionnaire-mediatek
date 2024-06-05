namespace GestionnaireMediatek.Views
{
    partial class FrmConfirmerModification
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
            btnAnnuler = new Button();
            panelCouleur = new Panel();
            lblQuestion = new Label();
            btnConfirmer = new Button();
            panelCouleur.SuspendLayout();
            SuspendLayout();
            // 
            // btnAnnuler
            // 
            btnAnnuler.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnnuler.Location = new Point(219, 56);
            btnAnnuler.Margin = new Padding(4, 3, 4, 3);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(209, 29);
            btnAnnuler.TabIndex = 9;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // panelCouleur
            // 
            panelCouleur.BackColor = Color.Tan;
            panelCouleur.Controls.Add(lblQuestion);
            panelCouleur.Dock = DockStyle.Top;
            panelCouleur.Location = new Point(0, 0);
            panelCouleur.Margin = new Padding(4, 3, 4, 3);
            panelCouleur.Name = "panelCouleur";
            panelCouleur.Size = new Size(441, 43);
            panelCouleur.TabIndex = 8;
            // 
            // lblQuestion
            // 
            lblQuestion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestion.Location = new Point(-19, 9);
            lblQuestion.Margin = new Padding(4, 0, 4, 0);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(485, 25);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "Souhaitez-vous confirmer les modifications apportées ?";
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnConfirmer
            // 
            btnConfirmer.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmer.Location = new Point(13, 56);
            btnConfirmer.Margin = new Padding(4, 3, 4, 3);
            btnConfirmer.Name = "btnConfirmer";
            btnConfirmer.Size = new Size(209, 29);
            btnConfirmer.TabIndex = 7;
            btnConfirmer.Text = "Confirmer";
            btnConfirmer.UseVisualStyleBackColor = true;
            // 
            // FrmConfirmerModification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(441, 97);
            ControlBox = false;
            Controls.Add(btnAnnuler);
            Controls.Add(panelCouleur);
            Controls.Add(btnConfirmer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmConfirmerModification";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelCouleur.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnAnnuler;
        private Panel panelCouleur;
        private Label lblQuestion;
        private Button btnConfirmer;
    }
}