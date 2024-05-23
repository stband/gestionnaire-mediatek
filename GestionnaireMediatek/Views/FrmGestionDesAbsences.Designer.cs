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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvListeAbsence = new DataGridView();
            lblAbsenceDe = new Label();
            lblNomPrenom = new Label();
            panelCouleur = new Panel();
            btnAjouterAbsence = new Button();
            ColumnDateDeDebut = new DataGridViewTextBoxColumn();
            ColumnDateDeFin = new DataGridViewTextBoxColumn();
            ColumnMotif = new DataGridViewTextBoxColumn();
            ColumnModifier = new DataGridViewImageColumn();
            ColumnSupprimer = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dgvListeAbsence).BeginInit();
            panelCouleur.SuspendLayout();
            SuspendLayout();
            // 
            // dgvListeAbsence
            // 
            dgvListeAbsence.AllowUserToDeleteRows = false;
            dgvListeAbsence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListeAbsence.BorderStyle = BorderStyle.None;
            dgvListeAbsence.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvListeAbsence.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListeAbsence.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListeAbsence.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListeAbsence.Columns.AddRange(new DataGridViewColumn[] { ColumnDateDeDebut, ColumnDateDeFin, ColumnMotif, ColumnModifier, ColumnSupprimer });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Menu;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Menu;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListeAbsence.DefaultCellStyle = dataGridViewCellStyle2;
            dgvListeAbsence.GridColor = SystemColors.ControlDarkDark;
            dgvListeAbsence.Location = new Point(0, 41);
            dgvListeAbsence.Margin = new Padding(4);
            dgvListeAbsence.MultiSelect = false;
            dgvListeAbsence.Name = "dgvListeAbsence";
            dgvListeAbsence.RightToLeft = RightToLeft.No;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvListeAbsence.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvListeAbsence.RowHeadersVisible = false;
            dgvListeAbsence.RowHeadersWidth = 20;
            dgvListeAbsence.ScrollBars = ScrollBars.Vertical;
            dgvListeAbsence.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListeAbsence.Size = new Size(684, 374);
            dgvListeAbsence.TabIndex = 7;
            // 
            // lblAbsenceDe
            // 
            lblAbsenceDe.AutoSize = true;
            lblAbsenceDe.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAbsenceDe.Location = new Point(9, 10);
            lblAbsenceDe.Name = "lblAbsenceDe";
            lblAbsenceDe.Size = new Size(95, 20);
            lblAbsenceDe.TabIndex = 8;
            lblAbsenceDe.Text = "Absence de :";
            // 
            // lblNomPrenom
            // 
            lblNomPrenom.AutoSize = true;
            lblNomPrenom.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomPrenom.ForeColor = Color.Navy;
            lblNomPrenom.Location = new Point(100, 12);
            lblNomPrenom.Name = "lblNomPrenom";
            lblNomPrenom.Size = new Size(126, 17);
            lblNomPrenom.TabIndex = 9;
            lblNomPrenom.Text = "<Nom> <Prenom>";
            // 
            // panelCouleur
            // 
            panelCouleur.BackColor = SystemColors.GradientActiveCaption;
            panelCouleur.Controls.Add(btnAjouterAbsence);
            panelCouleur.Controls.Add(lblAbsenceDe);
            panelCouleur.Controls.Add(lblNomPrenom);
            panelCouleur.Dock = DockStyle.Top;
            panelCouleur.Location = new Point(0, 0);
            panelCouleur.Name = "panelCouleur";
            panelCouleur.Size = new Size(684, 41);
            panelCouleur.TabIndex = 10;
            // 
            // btnAjouterAbsence
            // 
            btnAjouterAbsence.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAjouterAbsence.Location = new Point(525, 7);
            btnAjouterAbsence.Name = "btnAjouterAbsence";
            btnAjouterAbsence.Size = new Size(147, 27);
            btnAjouterAbsence.TabIndex = 10;
            btnAjouterAbsence.Text = "Ajouter une absence";
            btnAjouterAbsence.UseVisualStyleBackColor = true;
            // 
            // ColumnDateDeDebut
            // 
            ColumnDateDeDebut.HeaderText = "Date de début";
            ColumnDateDeDebut.Name = "ColumnDateDeDebut";
            // 
            // ColumnDateDeFin
            // 
            ColumnDateDeFin.HeaderText = "Date de fin";
            ColumnDateDeFin.Name = "ColumnDateDeFin";
            // 
            // ColumnMotif
            // 
            ColumnMotif.HeaderText = "Motif";
            ColumnMotif.Name = "ColumnMotif";
            // 
            // ColumnModifier
            // 
            ColumnModifier.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColumnModifier.HeaderText = "";
            ColumnModifier.Image = Properties.Resources.icon_pen_edit;
            ColumnModifier.ImageLayout = DataGridViewImageCellLayout.Stretch;
            ColumnModifier.Name = "ColumnModifier";
            ColumnModifier.Width = 20;
            // 
            // ColumnSupprimer
            // 
            ColumnSupprimer.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColumnSupprimer.HeaderText = "";
            ColumnSupprimer.Name = "ColumnSupprimer";
            ColumnSupprimer.Width = 20;
            // 
            // FrmGestionDesAbsences
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 415);
            Controls.Add(dgvListeAbsence);
            Controls.Add(panelCouleur);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FrmGestionDesAbsences";
            Text = "Gestion des absences";
            ((System.ComponentModel.ISupportInitialize)dgvListeAbsence).EndInit();
            panelCouleur.ResumeLayout(false);
            panelCouleur.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DataGridView dgvListeAbsence;
        private System.Windows.Forms.Label lblAbsenceDe;
        private System.Windows.Forms.Label lblNomPrenom;
        private System.Windows.Forms.Panel panelCouleur;
        private System.Windows.Forms.Button btnAjouterAbsence;
        private DataGridViewTextBoxColumn ColumnDateDeDebut;
        private DataGridViewTextBoxColumn ColumnDateDeFin;
        private DataGridViewTextBoxColumn ColumnMotif;
        private DataGridViewImageColumn ColumnModifier;
        private DataGridViewImageColumn ColumnSupprimer;
    }
}