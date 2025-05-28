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
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.btnAjouterAbsence = new System.Windows.Forms.Button();
            this.btnSupprAbsence = new System.Windows.Forms.Button();
            this.btnModifAbsence = new System.Windows.Forms.Button();
            this.grpAjouterAbsence = new System.Windows.Forms.GroupBox();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            this.txtDateDebut = new System.Windows.Forms.TextBox();
            this.txtDateFin = new System.Windows.Forms.TextBox();
            this.cboMotif = new System.Windows.Forms.ComboBox();
            this.btnAjouterAbs = new System.Windows.Forms.Button();
            this.btnEnregistrerAbs = new System.Windows.Forms.Button();
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
            // dgvAbsences
            // 
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(6, 19);
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.Size = new System.Drawing.Size(680, 330);
            this.dgvAbsences.TabIndex = 0;
            // 
            // btnAjouterAbsence
            // 
            this.btnAjouterAbsence.Location = new System.Drawing.Point(95, 367);
            this.btnAjouterAbsence.Name = "btnAjouterAbsence";
            this.btnAjouterAbsence.Size = new System.Drawing.Size(117, 23);
            this.btnAjouterAbsence.TabIndex = 3;
            this.btnAjouterAbsence.Text = "Ajouter absence";
            this.btnAjouterAbsence.UseVisualStyleBackColor = true;
            // 
            // btnSupprAbsence
            // 
            this.btnSupprAbsence.Location = new System.Drawing.Point(479, 367);
            this.btnSupprAbsence.Name = "btnSupprAbsence";
            this.btnSupprAbsence.Size = new System.Drawing.Size(117, 23);
            this.btnSupprAbsence.TabIndex = 4;
            this.btnSupprAbsence.Text = "Supprimer absence";
            this.btnSupprAbsence.UseVisualStyleBackColor = true;
            // 
            // btnModifAbsence
            // 
            this.btnModifAbsence.Location = new System.Drawing.Point(287, 367);
            this.btnModifAbsence.Name = "btnModifAbsence";
            this.btnModifAbsence.Size = new System.Drawing.Size(117, 23);
            this.btnModifAbsence.TabIndex = 5;
            this.btnModifAbsence.Text = "Modifier absence";
            this.btnModifAbsence.UseVisualStyleBackColor = true;
            // 
            // grpAjouterAbsence
            // 
            this.grpAjouterAbsence.Controls.Add(this.btnEnregistrerAbs);
            this.grpAjouterAbsence.Controls.Add(this.btnAjouterAbs);
            this.grpAjouterAbsence.Controls.Add(this.cboMotif);
            this.grpAjouterAbsence.Controls.Add(this.txtDateFin);
            this.grpAjouterAbsence.Controls.Add(this.txtDateDebut);
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
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Location = new System.Drawing.Point(24, 34);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(66, 13);
            this.lblDateDebut.TabIndex = 0;
            this.lblDateDebut.Text = "Date début :";
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
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(368, 34);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(36, 13);
            this.lblMotif.TabIndex = 2;
            this.lblMotif.Text = "Motif :";
            // 
            // txtDateDebut
            // 
            this.txtDateDebut.Location = new System.Drawing.Point(96, 31);
            this.txtDateDebut.Name = "txtDateDebut";
            this.txtDateDebut.Size = new System.Drawing.Size(197, 20);
            this.txtDateDebut.TabIndex = 3;
            // 
            // txtDateFin
            // 
            this.txtDateFin.Location = new System.Drawing.Point(96, 68);
            this.txtDateFin.Name = "txtDateFin";
            this.txtDateFin.Size = new System.Drawing.Size(197, 20);
            this.txtDateFin.TabIndex = 4;
            // 
            // cboMotif
            // 
            this.cboMotif.FormattingEnabled = true;
            this.cboMotif.Location = new System.Drawing.Point(410, 31);
            this.cboMotif.Name = "cboMotif";
            this.cboMotif.Size = new System.Drawing.Size(197, 21);
            this.cboMotif.TabIndex = 5;
            // 
            // btnAjouterAbs
            // 
            this.btnAjouterAbs.Location = new System.Drawing.Point(371, 66);
            this.btnAjouterAbs.Name = "btnAjouterAbs";
            this.btnAjouterAbs.Size = new System.Drawing.Size(115, 23);
            this.btnAjouterAbs.TabIndex = 6;
            this.btnAjouterAbs.Text = "Ajouter";
            this.btnAjouterAbs.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrerAbs
            // 
            this.btnEnregistrerAbs.Location = new System.Drawing.Point(492, 66);
            this.btnEnregistrerAbs.Name = "btnEnregistrerAbs";
            this.btnEnregistrerAbs.Size = new System.Drawing.Size(115, 23);
            this.btnEnregistrerAbs.TabIndex = 7;
            this.btnEnregistrerAbs.Text = "Enregistrer";
            this.btnEnregistrerAbs.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Button btnAjouterAbs;
        private System.Windows.Forms.ComboBox cboMotif;
        private System.Windows.Forms.TextBox txtDateFin;
        private System.Windows.Forms.TextBox txtDateDebut;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Button btnEnregistrerAbs;
    }
}