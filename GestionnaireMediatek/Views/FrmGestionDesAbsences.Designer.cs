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
            ColumnDateDeDebut = new DataGridViewTextBoxColumn();
            ColumnDateDeFin = new DataGridViewTextBoxColumn();
            ColumnMotif = new DataGridViewTextBoxColumn();
            lblAbsenceDe = new Label();
            lblNomPrenom = new Label();
            panelCouleur = new Panel();
            pbxAjouterAbsence = new PictureBox();
            pbxSupprimerAbsence = new PictureBox();
            pbxModifierAbsence = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvListeAbsence).BeginInit();
            panelCouleur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxAjouterAbsence).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxSupprimerAbsence).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxModifierAbsence).BeginInit();
            SuspendLayout();
            // 
            // dgvListeAbsence
            // 
            dgvListeAbsence.AllowUserToAddRows = false;
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
            dgvListeAbsence.Columns.AddRange(new DataGridViewColumn[] { ColumnDateDeDebut, ColumnDateDeFin, ColumnMotif });
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
            lblNomPrenom.ForeColor = Color.Blue;
            lblNomPrenom.Location = new Point(100, 12);
            lblNomPrenom.Name = "lblNomPrenom";
            lblNomPrenom.Size = new Size(126, 17);
            lblNomPrenom.TabIndex = 9;
            lblNomPrenom.Text = "<Nom> <Prenom>";
            // 
            // panelCouleur
            // 
            panelCouleur.BackColor = SystemColors.Window;
            panelCouleur.Controls.Add(pbxAjouterAbsence);
            panelCouleur.Controls.Add(pbxSupprimerAbsence);
            panelCouleur.Controls.Add(pbxModifierAbsence);
            panelCouleur.Controls.Add(lblAbsenceDe);
            panelCouleur.Controls.Add(lblNomPrenom);
            panelCouleur.Dock = DockStyle.Top;
            panelCouleur.Location = new Point(0, 0);
            panelCouleur.Name = "panelCouleur";
            panelCouleur.Size = new Size(684, 41);
            panelCouleur.TabIndex = 10;
            // 
            // pbxAjouterAbsence
            // 
            pbxAjouterAbsence.BackgroundImageLayout = ImageLayout.None;
            pbxAjouterAbsence.Image = Properties.Resources.plus;
            pbxAjouterAbsence.Location = new Point(565, 4);
            pbxAjouterAbsence.Name = "pbxAjouterAbsence";
            pbxAjouterAbsence.Size = new Size(33, 34);
            pbxAjouterAbsence.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxAjouterAbsence.TabIndex = 13;
            pbxAjouterAbsence.TabStop = false;
            pbxAjouterAbsence.Click += pbxAjouterAbsence_Click;
            // 
            // pbxSupprimerAbsence
            // 
            pbxSupprimerAbsence.BackgroundImageLayout = ImageLayout.None;
            pbxSupprimerAbsence.Image = Properties.Resources.icon_trash_can;
            pbxSupprimerAbsence.Location = new Point(643, 4);
            pbxSupprimerAbsence.Name = "pbxSupprimerAbsence";
            pbxSupprimerAbsence.Size = new Size(33, 34);
            pbxSupprimerAbsence.SizeMode = PictureBoxSizeMode.Zoom;
            pbxSupprimerAbsence.TabIndex = 12;
            pbxSupprimerAbsence.TabStop = false;
            // 
            // pbxModifierAbsence
            // 
            pbxModifierAbsence.BackgroundImageLayout = ImageLayout.None;
            pbxModifierAbsence.Image = Properties.Resources.icon_pen_edit;
            pbxModifierAbsence.Location = new Point(604, 4);
            pbxModifierAbsence.Name = "pbxModifierAbsence";
            pbxModifierAbsence.Size = new Size(33, 34);
            pbxModifierAbsence.SizeMode = PictureBoxSizeMode.Zoom;
            pbxModifierAbsence.TabIndex = 11;
            pbxModifierAbsence.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)pbxAjouterAbsence).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxSupprimerAbsence).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxModifierAbsence).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DataGridView dgvListeAbsence;
        private System.Windows.Forms.Label lblAbsenceDe;
        private System.Windows.Forms.Label lblNomPrenom;
        private System.Windows.Forms.Panel panelCouleur;
        private DataGridViewTextBoxColumn ColumnDateDeDebut;
        private DataGridViewTextBoxColumn ColumnDateDeFin;
        private DataGridViewTextBoxColumn ColumnMotif;
        private PictureBox pbxSupprimerAbsence;
        private PictureBox pbxModifierAbsence;
        private PictureBox pbxAjouterAbsence;
    }
}