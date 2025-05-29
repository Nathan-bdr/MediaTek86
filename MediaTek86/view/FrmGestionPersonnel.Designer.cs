namespace MediaTek86.view
{
    partial class FrmGestionPersonnel
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
            this.grpPersonnel = new System.Windows.Forms.GroupBox();
            this.btnAfficherAbsences = new System.Windows.Forms.Button();
            this.btnSupprPerso = new System.Windows.Forms.Button();
            this.btnModifPerso = new System.Windows.Forms.Button();
            this.btnAjouterPerso = new System.Windows.Forms.Button();
            this.dgvPerso = new System.Windows.Forms.DataGridView();
            this.grpAjouterPerso = new System.Windows.Forms.GroupBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.cmbService = new System.Windows.Forms.ComboBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblService = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.grpPersonnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerso)).BeginInit();
            this.grpAjouterPerso.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPersonnel
            // 
            this.grpPersonnel.Controls.Add(this.btnAfficherAbsences);
            this.grpPersonnel.Controls.Add(this.btnSupprPerso);
            this.grpPersonnel.Controls.Add(this.btnModifPerso);
            this.grpPersonnel.Controls.Add(this.btnAjouterPerso);
            this.grpPersonnel.Controls.Add(this.dgvPerso);
            this.grpPersonnel.Location = new System.Drawing.Point(12, 12);
            this.grpPersonnel.Name = "grpPersonnel";
            this.grpPersonnel.Size = new System.Drawing.Size(692, 396);
            this.grpPersonnel.TabIndex = 0;
            this.grpPersonnel.TabStop = false;
            this.grpPersonnel.Text = "Personnel";
            // 
            // btnAfficherAbsences
            // 
            this.btnAfficherAbsences.Location = new System.Drawing.Point(543, 359);
            this.btnAfficherAbsences.Name = "btnAfficherAbsences";
            this.btnAfficherAbsences.Size = new System.Drawing.Size(143, 23);
            this.btnAfficherAbsences.TabIndex = 2;
            this.btnAfficherAbsences.Text = "Afficher absences";
            this.btnAfficherAbsences.UseVisualStyleBackColor = true;
            this.btnAfficherAbsences.Click += new System.EventHandler(this.btnAfficherAbsences_Click);
            // 
            // btnSupprPerso
            // 
            this.btnSupprPerso.Location = new System.Drawing.Point(364, 359);
            this.btnSupprPerso.Name = "btnSupprPerso";
            this.btnSupprPerso.Size = new System.Drawing.Size(143, 23);
            this.btnSupprPerso.TabIndex = 2;
            this.btnSupprPerso.Text = "Supprimer personnel";
            this.btnSupprPerso.UseVisualStyleBackColor = true;
            this.btnSupprPerso.Click += new System.EventHandler(this.btnSupprPerso_Click);
            // 
            // btnModifPerso
            // 
            this.btnModifPerso.Location = new System.Drawing.Point(185, 359);
            this.btnModifPerso.Name = "btnModifPerso";
            this.btnModifPerso.Size = new System.Drawing.Size(143, 23);
            this.btnModifPerso.TabIndex = 2;
            this.btnModifPerso.Text = "Modifier personnel";
            this.btnModifPerso.UseVisualStyleBackColor = true;
            this.btnModifPerso.Click += new System.EventHandler(this.btnModifPerso_Click);
            // 
            // btnAjouterPerso
            // 
            this.btnAjouterPerso.Location = new System.Drawing.Point(6, 359);
            this.btnAjouterPerso.Name = "btnAjouterPerso";
            this.btnAjouterPerso.Size = new System.Drawing.Size(143, 23);
            this.btnAjouterPerso.TabIndex = 1;
            this.btnAjouterPerso.Text = "Ajouter personnel";
            this.btnAjouterPerso.UseVisualStyleBackColor = true;
            this.btnAjouterPerso.Click += new System.EventHandler(this.btnAjouterPerso_Click);
            // 
            // dgvPerso
            // 
            this.dgvPerso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerso.Location = new System.Drawing.Point(6, 19);
            this.dgvPerso.Name = "dgvPerso";
            this.dgvPerso.Size = new System.Drawing.Size(680, 329);
            this.dgvPerso.TabIndex = 0;
            // 
            // grpAjouterPerso
            // 
            this.grpAjouterPerso.Controls.Add(this.btnEnregistrer);
            this.grpAjouterPerso.Controls.Add(this.btnAnnuler);
            this.grpAjouterPerso.Controls.Add(this.cmbService);
            this.grpAjouterPerso.Controls.Add(this.txtMail);
            this.grpAjouterPerso.Controls.Add(this.txtTel);
            this.grpAjouterPerso.Controls.Add(this.txtPrenom);
            this.grpAjouterPerso.Controls.Add(this.txtNom);
            this.grpAjouterPerso.Controls.Add(this.lblService);
            this.grpAjouterPerso.Controls.Add(this.lblMail);
            this.grpAjouterPerso.Controls.Add(this.lblTel);
            this.grpAjouterPerso.Controls.Add(this.lblPrenom);
            this.grpAjouterPerso.Controls.Add(this.lblNom);
            this.grpAjouterPerso.Enabled = false;
            this.grpAjouterPerso.Location = new System.Drawing.Point(12, 429);
            this.grpAjouterPerso.Name = "grpAjouterPerso";
            this.grpAjouterPerso.Size = new System.Drawing.Size(692, 151);
            this.grpAjouterPerso.TabIndex = 1;
            this.grpAjouterPerso.TabStop = false;
            this.grpAjouterPerso.Text = "Ajouter personnel";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(364, 108);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(121, 23);
            this.btnEnregistrer.TabIndex = 11;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(508, 108);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(121, 23);
            this.btnAnnuler.TabIndex = 10;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // cmbService
            // 
            this.cmbService.FormattingEnabled = true;
            this.cmbService.Location = new System.Drawing.Point(438, 71);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(191, 21);
            this.cmbService.TabIndex = 9;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(438, 32);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(191, 20);
            this.txtMail.TabIndex = 8;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(95, 110);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(191, 20);
            this.txtTel.TabIndex = 7;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(95, 71);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(191, 20);
            this.txtPrenom.TabIndex = 6;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(95, 32);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(191, 20);
            this.txtNom.TabIndex = 5;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(361, 74);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(49, 13);
            this.lblService.TabIndex = 4;
            this.lblService.Text = "Service :";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(361, 35);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(32, 13);
            this.lblMail.TabIndex = 3;
            this.lblMail.Text = "Mail :";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(19, 113);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(28, 13);
            this.lblTel.TabIndex = 2;
            this.lblTel.Text = "Tel :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(19, 74);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(19, 35);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom :";
            // 
            // FrmGestionPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 590);
            this.Controls.Add(this.grpAjouterPerso);
            this.Controls.Add(this.grpPersonnel);
            this.Name = "FrmGestionPersonnel";
            this.Text = "Gestion du personnel";
            this.grpPersonnel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerso)).EndInit();
            this.grpAjouterPerso.ResumeLayout(false);
            this.grpAjouterPerso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPersonnel;
        private System.Windows.Forms.Button btnAfficherAbsences;
        private System.Windows.Forms.Button btnSupprPerso;
        private System.Windows.Forms.Button btnModifPerso;
        private System.Windows.Forms.Button btnAjouterPerso;
        private System.Windows.Forms.DataGridView dgvPerso;
        private System.Windows.Forms.GroupBox grpAjouterPerso;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.ComboBox cmbService;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblMail;
    }
}