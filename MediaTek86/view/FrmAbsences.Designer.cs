namespace MediaTek86.view
{
    partial class FrmAbsences
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
            this.grpAbsences = new System.Windows.Forms.GroupBox();
            this.btnModifAbsence = new System.Windows.Forms.Button();
            this.btnSupprAbsence = new System.Windows.Forms.Button();
            this.btnAjouterAbsence = new System.Windows.Forms.Button();
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.grpAjouterAbsence = new System.Windows.Forms.GroupBox();
            this.btnEnregistrerAbs = new System.Windows.Forms.Button();
            this.btnAnnulerAbs = new System.Windows.Forms.Button();
            this.cmbMotif = new System.Windows.Forms.ComboBox();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.grpAbsences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.grpAjouterAbsence.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAbsences
            // 
            this.grpAbsences.Controls.Add(this.btnModifAbsence);
            this.grpAbsences.Controls.Add(this.btnSupprAbsence);
            this.grpAbsences.Controls.Add(this.btnAjouterAbsence);
            this.grpAbsences.Controls.Add(this.dgvAbsences);
            this.grpAbsences.Location = new System.Drawing.Point(12, 12);
            this.grpAbsences.Name = "grpAbsences";
            this.grpAbsences.Size = new System.Drawing.Size(692, 409);
            this.grpAbsences.TabIndex = 0;
            this.grpAbsences.TabStop = false;
            this.grpAbsences.Text = "Absences";
            // 
            // btnModifAbsence
            // 
            this.btnModifAbsence.Location = new System.Drawing.Point(287, 367);
            this.btnModifAbsence.Name = "btnModifAbsence";
            this.btnModifAbsence.Size = new System.Drawing.Size(117, 23);
            this.btnModifAbsence.TabIndex = 5;
            this.btnModifAbsence.Text = "Modifier absence";
            this.btnModifAbsence.UseVisualStyleBackColor = true;
            this.btnModifAbsence.Click += new System.EventHandler(this.btnModifierAbsence_Click);
            // 
            // btnSupprAbsence
            // 
            this.btnSupprAbsence.Location = new System.Drawing.Point(479, 367);
            this.btnSupprAbsence.Name = "btnSupprAbsence";
            this.btnSupprAbsence.Size = new System.Drawing.Size(117, 23);
            this.btnSupprAbsence.TabIndex = 4;
            this.btnSupprAbsence.Text = "Supprimer absence";
            this.btnSupprAbsence.UseVisualStyleBackColor = true;
            this.btnSupprAbsence.Click += new System.EventHandler(this.btnSupprAbsence_Click);
            // 
            // btnAjouterAbsence
            // 
            this.btnAjouterAbsence.Location = new System.Drawing.Point(95, 367);
            this.btnAjouterAbsence.Name = "btnAjouterAbsence";
            this.btnAjouterAbsence.Size = new System.Drawing.Size(117, 23);
            this.btnAjouterAbsence.TabIndex = 3;
            this.btnAjouterAbsence.Text = "Ajouter absence";
            this.btnAjouterAbsence.UseVisualStyleBackColor = true;
            this.btnAjouterAbsence.Click += new System.EventHandler(this.btnAjouterAbsence_Click);
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(6, 19);
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.Size = new System.Drawing.Size(680, 330);
            this.dgvAbsences.TabIndex = 0;
            // 
            // grpAjouterAbsence
            // 
            this.grpAjouterAbsence.Controls.Add(this.dtpDateFin);
            this.grpAjouterAbsence.Controls.Add(this.dtpDateDebut);
            this.grpAjouterAbsence.Controls.Add(this.btnEnregistrerAbs);
            this.grpAjouterAbsence.Controls.Add(this.btnAnnulerAbs);
            this.grpAjouterAbsence.Controls.Add(this.cmbMotif);
            this.grpAjouterAbsence.Controls.Add(this.lblMotif);
            this.grpAjouterAbsence.Controls.Add(this.lblDateFin);
            this.grpAjouterAbsence.Controls.Add(this.lblDateDebut);
            this.grpAjouterAbsence.Location = new System.Drawing.Point(12, 438);
            this.grpAjouterAbsence.Name = "grpAjouterAbsence";
            this.grpAjouterAbsence.Size = new System.Drawing.Size(692, 110);
            this.grpAjouterAbsence.TabIndex = 1;
            this.grpAjouterAbsence.TabStop = false;
            this.grpAjouterAbsence.Text = "Ajouter absence";
            // 
            // btnEnregistrerAbs
            // 
            this.btnEnregistrerAbs.Location = new System.Drawing.Point(371, 66);
            this.btnEnregistrerAbs.Name = "btnEnregistrerAbs";
            this.btnEnregistrerAbs.Size = new System.Drawing.Size(115, 23);
            this.btnEnregistrerAbs.TabIndex = 7;
            this.btnEnregistrerAbs.Text = "Enregistrer";
            this.btnEnregistrerAbs.UseVisualStyleBackColor = true;
            this.btnEnregistrerAbs.Click += new System.EventHandler(this.btnEnregistrerAbs_Click);
            // 
            // btnAnnulerAbs
            // 
            this.btnAnnulerAbs.Location = new System.Drawing.Point(492, 66);
            this.btnAnnulerAbs.Name = "btnAnnulerAbs";
            this.btnAnnulerAbs.Size = new System.Drawing.Size(115, 23);
            this.btnAnnulerAbs.TabIndex = 6;
            this.btnAnnulerAbs.Text = "Annuler";
            this.btnAnnulerAbs.UseVisualStyleBackColor = true;
            this.btnAnnulerAbs.Click += new System.EventHandler(this.btnAnnulerAbs_Click);
            // 
            // cmbMotif
            // 
            this.cmbMotif.FormattingEnabled = true;
            this.cmbMotif.Location = new System.Drawing.Point(410, 31);
            this.cmbMotif.Name = "cmbMotif";
            this.cmbMotif.Size = new System.Drawing.Size(197, 21);
            this.cmbMotif.TabIndex = 5;
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(368, 34);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(36, 13);
            this.lblMotif.TabIndex = 2;
            this.lblMotif.Text = "Motif :";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(24, 71);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(50, 13);
            this.lblDateFin.TabIndex = 1;
            this.lblDateFin.Text = "Date fin :";
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Location = new System.Drawing.Point(24, 34);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(66, 13);
            this.lblDateDebut.TabIndex = 0;
            this.lblDateDebut.Text = "Date début :";
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Location = new System.Drawing.Point(96, 31);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(197, 20);
            this.dtpDateDebut.TabIndex = 12;
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Location = new System.Drawing.Point(96, 66);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(197, 20);
            this.dtpDateFin.TabIndex = 13;
            // 
            // FrmAbsences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 562);
            this.Controls.Add(this.grpAjouterAbsence);
            this.Controls.Add(this.grpAbsences);
            this.Name = "FrmAbsences";
            this.Text = "Gestion des absences";
            this.grpAbsences.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.grpAjouterAbsence.ResumeLayout(false);
            this.grpAjouterAbsence.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAbsences;
        private System.Windows.Forms.DataGridView dgvAbsences;
        private System.Windows.Forms.Button btnModifAbsence;
        private System.Windows.Forms.Button btnSupprAbsence;
        private System.Windows.Forms.Button btnAjouterAbsence;
        private System.Windows.Forms.GroupBox grpAjouterAbsence;
        private System.Windows.Forms.Button btnAnnulerAbs;
        private System.Windows.Forms.ComboBox cmbMotif;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Button btnEnregistrerAbs;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
    }
}