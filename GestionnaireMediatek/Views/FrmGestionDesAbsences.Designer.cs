namespace GestionnaireMediatek.Views
{
    partial class FrmGestionDesAbsences
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListeAbsence = new System.Windows.Forms.DataGridView();
            this.ColumnDateDeDebut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateDeFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMotif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModifier = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnSupprimer = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblAbsenceDe = new System.Windows.Forms.Label();
            this.lblNomPrenom = new System.Windows.Forms.Label();
            this.panelCouleur = new System.Windows.Forms.Panel();
            this.btnAjouterAbsence = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeAbsence)).BeginInit();
            this.panelCouleur.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListeAbsence
            // 
            this.dgvListeAbsence.AllowUserToDeleteRows = false;
            this.dgvListeAbsence.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListeAbsence.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvListeAbsence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListeAbsence.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListeAbsence.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListeAbsence.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListeAbsence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeAbsence.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDateDeDebut,
            this.ColumnDateDeFin,
            this.ColumnMotif,
            this.ColumnModifier,
            this.ColumnSupprimer});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListeAbsence.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListeAbsence.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvListeAbsence.Location = new System.Drawing.Point(0, 41);
            this.dgvListeAbsence.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListeAbsence.MultiSelect = false;
            this.dgvListeAbsence.Name = "dgvListeAbsence";
            this.dgvListeAbsence.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListeAbsence.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListeAbsence.RowHeadersVisible = false;
            this.dgvListeAbsence.RowHeadersWidth = 20;
            this.dgvListeAbsence.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListeAbsence.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListeAbsence.Size = new System.Drawing.Size(684, 374);
            this.dgvListeAbsence.TabIndex = 7;
            // 
            // ColumnDateDeDebut
            // 
            this.ColumnDateDeDebut.HeaderText = "Date de début";
            this.ColumnDateDeDebut.Name = "ColumnDateDeDebut";
            // 
            // ColumnDateDeFin
            // 
            this.ColumnDateDeFin.HeaderText = "Date de fin";
            this.ColumnDateDeFin.Name = "ColumnDateDeFin";
            // 
            // ColumnMotif
            // 
            this.ColumnMotif.HeaderText = "Motif";
            this.ColumnMotif.Name = "ColumnMotif";
            // 
            // ColumnModifier
            // 
            this.ColumnModifier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModifier.HeaderText = "";
            this.ColumnModifier.Name = "ColumnModifier";
            this.ColumnModifier.Width = 20;
            // 
            // ColumnSupprimer
            // 
            this.ColumnSupprimer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnSupprimer.HeaderText = "";
            this.ColumnSupprimer.Name = "ColumnSupprimer";
            this.ColumnSupprimer.Width = 20;
            // 
            // lblAbsenceDe
            // 
            this.lblAbsenceDe.AutoSize = true;
            this.lblAbsenceDe.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbsenceDe.Location = new System.Drawing.Point(9, 10);
            this.lblAbsenceDe.Name = "lblAbsenceDe";
            this.lblAbsenceDe.Size = new System.Drawing.Size(95, 20);
            this.lblAbsenceDe.TabIndex = 8;
            this.lblAbsenceDe.Text = "Absence de :";
            // 
            // lblNomPrenom
            // 
            this.lblNomPrenom.AutoSize = true;
            this.lblNomPrenom.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomPrenom.ForeColor = System.Drawing.Color.Navy;
            this.lblNomPrenom.Location = new System.Drawing.Point(100, 12);
            this.lblNomPrenom.Name = "lblNomPrenom";
            this.lblNomPrenom.Size = new System.Drawing.Size(126, 17);
            this.lblNomPrenom.TabIndex = 9;
            this.lblNomPrenom.Text = "<Nom> <Prenom>";
            // 
            // panelCouleur
            // 
            this.panelCouleur.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelCouleur.Controls.Add(this.btnAjouterAbsence);
            this.panelCouleur.Controls.Add(this.lblAbsenceDe);
            this.panelCouleur.Controls.Add(this.lblNomPrenom);
            this.panelCouleur.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCouleur.Location = new System.Drawing.Point(0, 0);
            this.panelCouleur.Name = "panelCouleur";
            this.panelCouleur.Size = new System.Drawing.Size(684, 41);
            this.panelCouleur.TabIndex = 10;
            // 
            // btnAjouterAbsence
            // 
            this.btnAjouterAbsence.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterAbsence.Location = new System.Drawing.Point(525, 7);
            this.btnAjouterAbsence.Name = "btnAjouterAbsence";
            this.btnAjouterAbsence.Size = new System.Drawing.Size(147, 27);
            this.btnAjouterAbsence.TabIndex = 10;
            this.btnAjouterAbsence.Text = "Ajouter une absence";
            this.btnAjouterAbsence.UseVisualStyleBackColor = true;
            // 
            // FrmGestionDesAbsences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 415);
            this.Controls.Add(this.dgvListeAbsence);
            this.Controls.Add(this.panelCouleur);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGestionDesAbsences";
            this.Text = "Gestion des absences";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeAbsence)).EndInit();
            this.panelCouleur.ResumeLayout(false);
            this.panelCouleur.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvListeAbsence;
        private System.Windows.Forms.Label lblAbsenceDe;
        private System.Windows.Forms.Label lblNomPrenom;
        private System.Windows.Forms.Panel panelCouleur;
        private System.Windows.Forms.Button btnAjouterAbsence;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateDeDebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateDeFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMotif;
        private System.Windows.Forms.DataGridViewImageColumn ColumnModifier;
        private System.Windows.Forms.DataGridViewImageColumn ColumnSupprimer;
    }
}