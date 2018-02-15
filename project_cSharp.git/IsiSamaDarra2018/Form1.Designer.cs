namespace IsiSamaDarra2018
{
    partial class frmTuteur
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgTuteur = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCni = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtParente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbCivilite = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTuteur)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTuteur
            // 
            this.dgTuteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTuteur.Location = new System.Drawing.Point(30, 43);
            this.dgTuteur.Name = "dgTuteur";
            this.dgTuteur.RowTemplate.Height = 24;
            this.dgTuteur.Size = new System.Drawing.Size(1112, 240);
            this.dgTuteur.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "nom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(112, 346);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(437, 22);
            this.txtNom.TabIndex = 2;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(706, 344);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(437, 22);
            this.txtPrenom.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(624, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "prenom";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(706, 386);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(437, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(624, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "email";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(112, 389);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(437, 22);
            this.txtAdresse.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "adresse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(624, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "civilité";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(112, 432);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(437, 22);
            this.txtTel.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "téléphone";
            // 
            // txtCni
            // 
            this.txtCni.Location = new System.Drawing.Point(706, 472);
            this.txtCni.Name = "txtCni";
            this.txtCni.Size = new System.Drawing.Size(437, 22);
            this.txtCni.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(624, 481);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "cni";
            // 
            // txtParente
            // 
            this.txtParente.Location = new System.Drawing.Point(112, 475);
            this.txtParente.Name = "txtParente";
            this.txtParente.Size = new System.Drawing.Size(437, 22);
            this.txtParente.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 478);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "parenté";
            // 
            // cbbCivilite
            // 
            this.cbbCivilite.FormattingEnabled = true;
            this.cbbCivilite.Items.AddRange(new object[] {
            "M.",
            "Mme",
            "Mlle"});
            this.cbbCivilite.Location = new System.Drawing.Point(706, 428);
            this.cbbCivilite.Name = "cbbCivilite";
            this.cbbCivilite.Size = new System.Drawing.Size(436, 24);
            this.cbbCivilite.TabIndex = 17;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAjouter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAjouter.Location = new System.Drawing.Point(30, 529);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(207, 58);
            this.btnAjouter.TabIndex = 18;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModifier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifier.Location = new System.Drawing.Point(282, 529);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(207, 58);
            this.btnModifier.TabIndex = 19;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSupprimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSupprimer.Location = new System.Drawing.Point(534, 529);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(207, 58);
            this.btnSupprimer.TabIndex = 20;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSelect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelect.Location = new System.Drawing.Point(1058, 289);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(84, 36);
            this.btnSelect.TabIndex = 21;
            this.btnSelect.Text = "select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // frmTuteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 660);
            this.ControlBox = false;
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cbbCivilite);
            this.Controls.Add(this.txtCni);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtParente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgTuteur);
            this.Name = "frmTuteur";
            this.Text = "Tuteur";
            this.Load += new System.EventHandler(this.frmTuteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTuteur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTuteur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCni;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtParente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbCivilite;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnSelect;
    }
}

