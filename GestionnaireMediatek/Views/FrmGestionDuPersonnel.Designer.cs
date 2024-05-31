namespace GestionnaireMediatek.Views
{
    partial class FrmGestionDuPersonnel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionDuPersonnel));
            txtRechercher = new TextBox();
            btnEffacerRecherche = new Button();
            dgvListePersonnel = new DataGridView();
            colonneNom = new DataGridViewTextBoxColumn();
            colonnePrenom = new DataGridViewTextBoxColumn();
            colonneService = new DataGridViewTextBoxColumn();
            colonneTel = new DataGridViewTextBoxColumn();
            colonneEmail = new DataGridViewTextBoxColumn();
            dataGridViewImageColumn1 = new DataGridViewImageColumn();
            pbxAjouterPersonnel = new PictureBox();
            dataGridViewImageColumn2 = new DataGridViewImageColumn();
            pbxModifierPersonnel = new PictureBox();
            pbxSupprimerPersonnel = new PictureBox();
            pbxGestionAbsence = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvListePersonnel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxAjouterPersonnel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxModifierPersonnel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxSupprimerPersonnel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxGestionAbsence).BeginInit();
            SuspendLayout();
            // 
            // txtRechercher
            // 
            txtRechercher.BackColor = SystemColors.Window;
            txtRechercher.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRechercher.ForeColor = SystemColors.GrayText;
            txtRechercher.Location = new Point(13, 13);
            txtRechercher.Margin = new Padding(4);
            txtRechercher.Name = "txtRechercher";
            txtRechercher.Size = new Size(424, 29);
            txtRechercher.TabIndex = 0;
            txtRechercher.Text = "Rechercher";
            // 
            // btnEffacerRecherche
            // 
            btnEffacerRecherche.BackColor = Color.Transparent;
            btnEffacerRecherche.FlatAppearance.BorderSize = 4;
            btnEffacerRecherche.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEffacerRecherche.Location = new Point(445, 13);
            btnEffacerRecherche.Margin = new Padding(4);
            btnEffacerRecherche.Name = "btnEffacerRecherche";
            btnEffacerRecherche.Size = new Size(135, 26);
            btnEffacerRecherche.TabIndex = 1;
            btnEffacerRecherche.Text = "Effacer la recherche";
            btnEffacerRecherche.UseVisualStyleBackColor = false;
            // 
            // dgvListePersonnel
            // 
            dgvListePersonnel.AllowUserToAddRows = false;
            dgvListePersonnel.AllowUserToDeleteRows = false;
            dgvListePersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListePersonnel.BorderStyle = BorderStyle.None;
            dgvListePersonnel.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvListePersonnel.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListePersonnel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListePersonnel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListePersonnel.Columns.AddRange(new DataGridViewColumn[] { colonneNom, colonnePrenom, colonneService, colonneTel, colonneEmail });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Menu;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Menu;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListePersonnel.DefaultCellStyle = dataGridViewCellStyle2;
            dgvListePersonnel.GridColor = SystemColors.ControlDarkDark;
            dgvListePersonnel.Location = new Point(-1, 64);
            dgvListePersonnel.Margin = new Padding(4);
            dgvListePersonnel.MultiSelect = false;
            dgvListePersonnel.Name = "dgvListePersonnel";
            dgvListePersonnel.RightToLeft = RightToLeft.No;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvListePersonnel.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvListePersonnel.RowHeadersVisible = false;
            dgvListePersonnel.RowHeadersWidth = 20;
            dgvListePersonnel.ScrollBars = ScrollBars.Vertical;
            dgvListePersonnel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListePersonnel.Size = new Size(685, 352);
            dgvListePersonnel.TabIndex = 2;
            // 
            // colonneNom
            // 
            colonneNom.FillWeight = 101.7259F;
            colonneNom.HeaderText = "Nom";
            colonneNom.MinimumWidth = 6;
            colonneNom.Name = "colonneNom";
            // 
            // colonnePrenom
            // 
            colonnePrenom.FillWeight = 101.7259F;
            colonnePrenom.HeaderText = "Prenom";
            colonnePrenom.MinimumWidth = 6;
            colonnePrenom.Name = "colonnePrenom";
            // 
            // colonneService
            // 
            colonneService.FillWeight = 101.7259F;
            colonneService.HeaderText = "Service";
            colonneService.MinimumWidth = 6;
            colonneService.Name = "colonneService";
            // 
            // colonneTel
            // 
            colonneTel.FillWeight = 101.7259F;
            colonneTel.HeaderText = "Tel";
            colonneTel.MinimumWidth = 6;
            colonneTel.Name = "colonneTel";
            // 
            // colonneEmail
            // 
            colonneEmail.FillWeight = 101.7259F;
            colonneEmail.HeaderText = "Email";
            colonneEmail.MinimumWidth = 6;
            colonneEmail.Name = "colonneEmail";
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewImageColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewImageColumn1.HeaderText = "";
            dataGridViewImageColumn1.Image = Properties.Resources.logo_mediatek;
            dataGridViewImageColumn1.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewImageColumn1.MinimumWidth = 6;
            dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            dataGridViewImageColumn1.ReadOnly = true;
            dataGridViewImageColumn1.Resizable = DataGridViewTriState.False;
            dataGridViewImageColumn1.Width = 125;
            // 
            // pbxAjouterPersonnel
            // 
            pbxAjouterPersonnel.BackgroundImageLayout = ImageLayout.None;
            pbxAjouterPersonnel.Image = Properties.Resources.icon_ajouter_personnel;
            pbxAjouterPersonnel.Location = new Point(634, 3);
            pbxAjouterPersonnel.Name = "pbxAjouterPersonnel";
            pbxAjouterPersonnel.Size = new Size(26, 24);
            pbxAjouterPersonnel.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxAjouterPersonnel.TabIndex = 3;
            pbxAjouterPersonnel.TabStop = false;
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewImageColumn2.HeaderText = "";
            dataGridViewImageColumn2.Image = (Image)resources.GetObject("dataGridViewImageColumn2.Image");
            dataGridViewImageColumn2.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewImageColumn2.MinimumWidth = 6;
            dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            dataGridViewImageColumn2.Width = 125;
            // 
            // pbxModifierPersonnel
            // 
            pbxModifierPersonnel.BackgroundImageLayout = ImageLayout.None;
            pbxModifierPersonnel.Image = Properties.Resources.icon_pen_edit;
            pbxModifierPersonnel.Location = new Point(602, 3);
            pbxModifierPersonnel.Name = "pbxModifierPersonnel";
            pbxModifierPersonnel.Size = new Size(26, 24);
            pbxModifierPersonnel.SizeMode = PictureBoxSizeMode.Zoom;
            pbxModifierPersonnel.TabIndex = 4;
            pbxModifierPersonnel.TabStop = false;
            pbxModifierPersonnel.Click += pbxModifierPersonnel_Click;
            // 
            // pbxSupprimerPersonnel
            // 
            pbxSupprimerPersonnel.BackgroundImageLayout = ImageLayout.None;
            pbxSupprimerPersonnel.Image = Properties.Resources.icon_trash_can;
            pbxSupprimerPersonnel.Location = new Point(634, 33);
            pbxSupprimerPersonnel.Name = "pbxSupprimerPersonnel";
            pbxSupprimerPersonnel.Size = new Size(26, 24);
            pbxSupprimerPersonnel.SizeMode = PictureBoxSizeMode.Zoom;
            pbxSupprimerPersonnel.TabIndex = 5;
            pbxSupprimerPersonnel.TabStop = false;
            // 
            // pbxGestionAbsence
            // 
            pbxGestionAbsence.BackgroundImageLayout = ImageLayout.None;
            pbxGestionAbsence.Image = Properties.Resources.Custom_Icon_Design_Pretty_Office_7_Calendar_256;
            pbxGestionAbsence.Location = new Point(602, 33);
            pbxGestionAbsence.Name = "pbxGestionAbsence";
            pbxGestionAbsence.Size = new Size(26, 24);
            pbxGestionAbsence.SizeMode = PictureBoxSizeMode.Zoom;
            pbxGestionAbsence.TabIndex = 6;
            pbxGestionAbsence.TabStop = false;
            // 
            // FrmGestionDuPersonnel
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(684, 415);
            Controls.Add(pbxGestionAbsence);
            Controls.Add(pbxSupprimerPersonnel);
            Controls.Add(pbxModifierPersonnel);
            Controls.Add(pbxAjouterPersonnel);
            Controls.Add(dgvListePersonnel);
            Controls.Add(btnEffacerRecherche);
            Controls.Add(txtRechercher);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FrmGestionDuPersonnel";
            RightToLeft = RightToLeft.No;
            Text = "Gestion du personnel";
            ((System.ComponentModel.ISupportInitialize)dgvListePersonnel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxAjouterPersonnel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxModifierPersonnel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxSupprimerPersonnel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxGestionAbsence).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtRechercher;
        private System.Windows.Forms.Button btnEffacerRecherche;
        private System.Windows.Forms.DataGridView dgvListePersonnel;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.PictureBox pbxAjouterPersonnel;
        private DataGridViewTextBoxColumn colonneNom;
        private DataGridViewTextBoxColumn colonnePrenom;
        private DataGridViewTextBoxColumn colonneService;
        private DataGridViewTextBoxColumn colonneTel;
        private DataGridViewTextBoxColumn colonneEmail;
        private PictureBox pbxModifierPersonnel;
        private PictureBox pbxSupprimerPersonnel;
        private PictureBox pbxGestionAbsence;
    }
}