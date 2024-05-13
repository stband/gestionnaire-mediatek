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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionDuPersonnel));
            this.txtRechercher = new System.Windows.Forms.TextBox();
            this.btnEffacerRecherche = new System.Windows.Forms.Button();
            this.dgvListePersonnel = new System.Windows.Forms.DataGridView();
            this.rowNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pbxOuvrirGestionAbsence = new System.Windows.Forms.PictureBox();
            this.pbxAjouterPersonnel = new System.Windows.Forms.PictureBox();
            this.columnEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListePersonnel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOuvrirGestionAbsence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAjouterPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRechercher
            // 
            this.txtRechercher.BackColor = System.Drawing.SystemColors.Window;
            this.txtRechercher.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRechercher.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtRechercher.Location = new System.Drawing.Point(14, 15);
            this.txtRechercher.Margin = new System.Windows.Forms.Padding(4);
            this.txtRechercher.Name = "txtRechercher";
            this.txtRechercher.Size = new System.Drawing.Size(424, 24);
            this.txtRechercher.TabIndex = 0;
            this.txtRechercher.Text = "Rechercher";
            // 
            // btnEffacerRecherche
            // 
            this.btnEffacerRecherche.BackColor = System.Drawing.Color.Transparent;
            this.btnEffacerRecherche.FlatAppearance.BorderSize = 4;
            this.btnEffacerRecherche.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEffacerRecherche.Location = new System.Drawing.Point(446, 15);
            this.btnEffacerRecherche.Margin = new System.Windows.Forms.Padding(4);
            this.btnEffacerRecherche.Name = "btnEffacerRecherche";
            this.btnEffacerRecherche.Size = new System.Drawing.Size(135, 24);
            this.btnEffacerRecherche.TabIndex = 1;
            this.btnEffacerRecherche.Text = "Effacer la recherche";
            this.btnEffacerRecherche.UseVisualStyleBackColor = false;
            // 
            // dgvListePersonnel
            // 
            this.dgvListePersonnel.AllowUserToAddRows = false;
            this.dgvListePersonnel.AllowUserToDeleteRows = false;
            this.dgvListePersonnel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListePersonnel.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dgvListePersonnel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListePersonnel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListePersonnel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListePersonnel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListePersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListePersonnel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowNom,
            this.rowPrenom,
            this.rowService,
            this.rowTel,
            this.rowEmail,
            this.columnEdit,
            this.columnDelete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListePersonnel.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListePersonnel.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvListePersonnel.Location = new System.Drawing.Point(-1, 56);
            this.dgvListePersonnel.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListePersonnel.MultiSelect = false;
            this.dgvListePersonnel.Name = "dgvListePersonnel";
            this.dgvListePersonnel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListePersonnel.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListePersonnel.RowHeadersVisible = false;
            this.dgvListePersonnel.RowHeadersWidth = 20;
            this.dgvListePersonnel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListePersonnel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListePersonnel.Size = new System.Drawing.Size(685, 335);
            this.dgvListePersonnel.TabIndex = 2;
            // 
            // rowNom
            // 
            this.rowNom.FillWeight = 101.7259F;
            this.rowNom.HeaderText = "Nom";
            this.rowNom.Name = "rowNom";
            // 
            // rowPrenom
            // 
            this.rowPrenom.FillWeight = 101.7259F;
            this.rowPrenom.HeaderText = "Prenom";
            this.rowPrenom.Name = "rowPrenom";
            // 
            // rowService
            // 
            this.rowService.FillWeight = 101.7259F;
            this.rowService.HeaderText = "Service";
            this.rowService.Name = "rowService";
            // 
            // rowTel
            // 
            this.rowTel.FillWeight = 101.7259F;
            this.rowTel.HeaderText = "Tel";
            this.rowTel.Name = "rowTel";
            // 
            // rowEmail
            // 
            this.rowEmail.FillWeight = 101.7259F;
            this.rowEmail.HeaderText = "Email";
            this.rowEmail.Name = "rowEmail";
            // 
            // columnDelete
            // 
            this.columnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.columnDelete.HeaderText = "";
            this.columnDelete.Name = "columnDelete";
            this.columnDelete.Width = 5;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::GestionnaireMediatek.Properties.Resources.logo_mediatek;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 5;
            // 
            // pbxOuvrirGestionAbsence
            // 
            this.pbxOuvrirGestionAbsence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxOuvrirGestionAbsence.Image = global::GestionnaireMediatek.Properties.Resources.Custom_Icon_Design_Pretty_Office_7_Calendar_256;
            this.pbxOuvrirGestionAbsence.Location = new System.Drawing.Point(633, 15);
            this.pbxOuvrirGestionAbsence.Name = "pbxOuvrirGestionAbsence";
            this.pbxOuvrirGestionAbsence.Size = new System.Drawing.Size(30, 24);
            this.pbxOuvrirGestionAbsence.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxOuvrirGestionAbsence.TabIndex = 4;
            this.pbxOuvrirGestionAbsence.TabStop = false;
            // 
            // pbxAjouterPersonnel
            // 
            this.pbxAjouterPersonnel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxAjouterPersonnel.Image = global::GestionnaireMediatek.Properties.Resources.ajouter_personnel;
            this.pbxAjouterPersonnel.Location = new System.Drawing.Point(597, 15);
            this.pbxAjouterPersonnel.Name = "pbxAjouterPersonnel";
            this.pbxAjouterPersonnel.Size = new System.Drawing.Size(30, 24);
            this.pbxAjouterPersonnel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAjouterPersonnel.TabIndex = 3;
            this.pbxAjouterPersonnel.TabStop = false;
            // 
            // columnEdit
            // 
            this.columnEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.columnEdit.HeaderText = "";
            this.columnEdit.Image = ((System.Drawing.Image)(resources.GetObject("columnEdit.Image")));
            this.columnEdit.Name = "columnEdit";
            this.columnEdit.Width = 5;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // FrmGestionDuPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(684, 391);
            this.Controls.Add(this.pbxOuvrirGestionAbsence);
            this.Controls.Add(this.pbxAjouterPersonnel);
            this.Controls.Add(this.dgvListePersonnel);
            this.Controls.Add(this.btnEffacerRecherche);
            this.Controls.Add(this.txtRechercher);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGestionDuPersonnel";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Gestion du personnel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListePersonnel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOuvrirGestionAbsence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAjouterPersonnel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRechercher;
        private System.Windows.Forms.Button btnEffacerRecherche;
        private System.Windows.Forms.DataGridView dgvListePersonnel;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowService;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowEmail;
        private System.Windows.Forms.DataGridViewImageColumn columnEdit;
        private System.Windows.Forms.DataGridViewImageColumn columnDelete;
        private System.Windows.Forms.PictureBox pbxAjouterPersonnel;
        private System.Windows.Forms.PictureBox pbxOuvrirGestionAbsence;
    }
}