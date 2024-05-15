namespace GestionnaireMediatek.Views
{
    partial class FrmConfirmerSuppressionOuModificationAbsence
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
            this.panelRouge = new System.Windows.Forms.Panel();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblInfoHeader = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.lblInfoDebut = new System.Windows.Forms.Label();
            this.lblInfoFin = new System.Windows.Forms.Label();
            this.lblInfoMotif = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.panelRouge.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRouge
            // 
            this.panelRouge.BackColor = System.Drawing.Color.LightCoral;
            this.panelRouge.Controls.Add(this.lblQuestion);
            this.panelRouge.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRouge.Location = new System.Drawing.Point(0, 0);
            this.panelRouge.Name = "panelRouge";
            this.panelRouge.Size = new System.Drawing.Size(392, 45);
            this.panelRouge.TabIndex = 8;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(0, 11);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(392, 22);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Êtes-vous sûr de vouloir supprimer cette absence ?";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfoHeader
            // 
            this.lblInfoHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoHeader.ForeColor = System.Drawing.Color.Black;
            this.lblInfoHeader.Location = new System.Drawing.Point(0, 62);
            this.lblInfoHeader.Name = "lblInfoHeader";
            this.lblInfoHeader.Size = new System.Drawing.Size(392, 17);
            this.lblInfoHeader.TabIndex = 5;
            this.lblInfoHeader.Text = "Début                    Fin                    Motif";
            this.lblInfoHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(12, 115);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(185, 25);
            this.btnSupprimer.TabIndex = 9;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // lblInfoDebut
            // 
            this.lblInfoDebut.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoDebut.ForeColor = System.Drawing.Color.Red;
            this.lblInfoDebut.Location = new System.Drawing.Point(40, 81);
            this.lblInfoDebut.Name = "lblInfoDebut";
            this.lblInfoDebut.Size = new System.Drawing.Size(99, 17);
            this.lblInfoDebut.TabIndex = 10;
            this.lblInfoDebut.Text = "AAAA-MM-DD";
            this.lblInfoDebut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfoFin
            // 
            this.lblInfoFin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoFin.ForeColor = System.Drawing.Color.Red;
            this.lblInfoFin.Location = new System.Drawing.Point(147, 81);
            this.lblInfoFin.Name = "lblInfoFin";
            this.lblInfoFin.Size = new System.Drawing.Size(99, 17);
            this.lblInfoFin.TabIndex = 11;
            this.lblInfoFin.Text = "AAAA-MM-DD";
            this.lblInfoFin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfoMotif
            // 
            this.lblInfoMotif.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoMotif.ForeColor = System.Drawing.Color.Red;
            this.lblInfoMotif.Location = new System.Drawing.Point(252, 81);
            this.lblInfoMotif.Name = "lblInfoMotif";
            this.lblInfoMotif.Size = new System.Drawing.Size(99, 17);
            this.lblInfoMotif.TabIndex = 12;
            this.lblInfoMotif.Text = "Maladie";
            this.lblInfoMotif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(195, 115);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(185, 25);
            this.btnAnnuler.TabIndex = 13;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // FrmConfirmerSuppressionOuModificationAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 153);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.lblInfoMotif);
            this.Controls.Add(this.lblInfoFin);
            this.Controls.Add(this.lblInfoDebut);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.panelRouge);
            this.Controls.Add(this.lblInfoHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmConfirmerSuppressionOuModificationAbsence";
            this.Text = "Form1";
            this.panelRouge.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRouge;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblInfoHeader;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label lblInfoDebut;
        private System.Windows.Forms.Label lblInfoFin;
        private System.Windows.Forms.Label lblInfoMotif;
        private System.Windows.Forms.Button btnAnnuler;
    }
}