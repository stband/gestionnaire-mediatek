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
            this.dgvListePersonnel = new System.Windows.Forms.DataGridView();
            this.lblAbsenceDe = new System.Windows.Forms.Label();
            this.lblNomPrenom = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ColumnDateDeDebut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateDeFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMotif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModifier = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnSupprimer = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListePersonnel)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListePersonnel
            // 
            this.dgvListePersonnel.AllowUserToDeleteRows = false;
            this.dgvListePersonnel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListePersonnel.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvListePersonnel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListePersonnel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListePersonnel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListePersonnel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListePersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListePersonnel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvListePersonnel.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListePersonnel.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvListePersonnel.Location = new System.Drawing.Point(0, 41);
            this.dgvListePersonnel.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListePersonnel.MultiSelect = false;
            this.dgvListePersonnel.Name = "dgvListePersonnel";
            this.dgvListePersonnel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListePersonnel.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListePersonnel.RowHeadersVisible = false;
            this.dgvListePersonnel.RowHeadersWidth = 20;
            this.dgvListePersonnel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListePersonnel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListePersonnel.Size = new System.Drawing.Size(684, 374);
            this.dgvListePersonnel.TabIndex = 7;
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
            this.lblNomPrenom.ForeColor = System.Drawing.Color.Blue;
            this.lblNomPrenom.Location = new System.Drawing.Point(100, 12);
            this.lblNomPrenom.Name = "lblNomPrenom";
            this.lblNomPrenom.Size = new System.Drawing.Size(126, 17);
            this.lblNomPrenom.TabIndex = 9;
            this.lblNomPrenom.Text = "<Nom> <Prenom>";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblAbsenceDe);
            this.panel1.Controls.Add(this.lblNomPrenom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 41);
            this.panel1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(525, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ajouter une absence";
            this.button1.UseVisualStyleBackColor = true;
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
            // FrmGestionDesAbsences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 415);
            this.Controls.Add(this.dgvListePersonnel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGestionDesAbsences";
            this.Text = "Gestion des absences";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListePersonnel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvListePersonnel;
        private System.Windows.Forms.Label lblAbsenceDe;
        private System.Windows.Forms.Label lblNomPrenom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateDeDebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateDeFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMotif;
        private System.Windows.Forms.DataGridViewImageColumn ColumnModifier;
        private System.Windows.Forms.DataGridViewImageColumn ColumnSupprimer;
    }
}