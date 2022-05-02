namespace Projet_IHM2
{
    partial class Form1
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
            this.Label1 = new System.Windows.Forms.Label();
            this.listBoxMatieres = new System.Windows.Forms.ListBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtAjoutLibelle = new System.Windows.Forms.TextBox();
            this.txtAjoutCode = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.txtModifLibelle = new System.Windows.Forms.TextBox();
            this.txtModifCode = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.txtFiltreCode = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(558, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(183, 24);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Gestion des matières";
            // 
            // listBoxMatieres
            // 
            this.listBoxMatieres.FormattingEnabled = true;
            this.listBoxMatieres.ItemHeight = 16;
            this.listBoxMatieres.Location = new System.Drawing.Point(12, 9);
            this.listBoxMatieres.Name = "listBoxMatieres";
            this.listBoxMatieres.Size = new System.Drawing.Size(344, 660);
            this.listBoxMatieres.TabIndex = 1;
            this.listBoxMatieres.SelectedIndexChanged += new System.EventHandler(this.listBoxMatieres_SelectedIndexChanged);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnAjouter);
            this.GroupBox1.Controls.Add(this.txtAjoutLibelle);
            this.GroupBox1.Controls.Add(this.txtAjoutCode);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Location = new System.Drawing.Point(432, 55);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(509, 166);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Ajouter";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(119, 118);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(91, 26);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtAjoutLibelle
            // 
            this.txtAjoutLibelle.Location = new System.Drawing.Point(119, 77);
            this.txtAjoutLibelle.MaxLength = 50;
            this.txtAjoutLibelle.Name = "txtAjoutLibelle";
            this.txtAjoutLibelle.Size = new System.Drawing.Size(295, 22);
            this.txtAjoutLibelle.TabIndex = 3;
            // 
            // txtAjoutCode
            // 
            this.txtAjoutCode.Location = new System.Drawing.Point(119, 30);
            this.txtAjoutCode.MaxLength = 5;
            this.txtAjoutCode.Name = "txtAjoutCode";
            this.txtAjoutCode.Size = new System.Drawing.Size(91, 22);
            this.txtAjoutCode.TabIndex = 2;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(56, 82);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(57, 17);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "Libellé :";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(56, 30);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 23);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Code : ";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnModifier);
            this.GroupBox2.Controls.Add(this.txtModifLibelle);
            this.GroupBox2.Controls.Add(this.txtModifCode);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Location = new System.Drawing.Point(432, 247);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(509, 166);
            this.GroupBox2.TabIndex = 3;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Modifier";
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(119, 118);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(91, 26);
            this.btnModifier.TabIndex = 4;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // txtModifLibelle
            // 
            this.txtModifLibelle.Location = new System.Drawing.Point(119, 79);
            this.txtModifLibelle.MaxLength = 50;
            this.txtModifLibelle.Name = "txtModifLibelle";
            this.txtModifLibelle.Size = new System.Drawing.Size(295, 22);
            this.txtModifLibelle.TabIndex = 3;
            // 
            // txtModifCode
            // 
            this.txtModifCode.Location = new System.Drawing.Point(120, 30);
            this.txtModifCode.MaxLength = 5;
            this.txtModifCode.Name = "txtModifCode";
            this.txtModifCode.Size = new System.Drawing.Size(91, 22);
            this.txtModifCode.TabIndex = 2;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(56, 82);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(57, 17);
            this.Label5.TabIndex = 1;
            this.Label5.Text = "Libellé :";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(56, 30);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(100, 23);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "Code : ";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.btnSupprimer);
            this.GroupBox3.Location = new System.Drawing.Point(432, 434);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(509, 81);
            this.GroupBox3.TabIndex = 5;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Supprimer l\'enregistrement sélectionné";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(120, 37);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(91, 26);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.txtFiltreCode);
            this.GroupBox4.Controls.Add(this.Label6);
            this.GroupBox4.Location = new System.Drawing.Point(432, 537);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(509, 81);
            this.GroupBox4.TabIndex = 6;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Filtrer par le début du code";
            // 
            // txtFiltreCode
            // 
            this.txtFiltreCode.Location = new System.Drawing.Point(119, 40);
            this.txtFiltreCode.MaxLength = 5;
            this.txtFiltreCode.Name = "txtFiltreCode";
            this.txtFiltreCode.Size = new System.Drawing.Size(91, 22);
            this.txtFiltreCode.TabIndex = 4;
            this.txtFiltreCode.TextChanged += new System.EventHandler(this.txtFiltreCode_TextChanged);
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(56, 39);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(100, 23);
            this.Label6.TabIndex = 3;
            this.Label6.Text = "Code : ";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(876, 669);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(91, 26);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 707);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.listBoxMatieres);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des matières";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ListBox listBoxMatieres;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtAjoutLibelle;
        private System.Windows.Forms.TextBox txtAjoutCode;
        private System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox txtModifLibelle;
        private System.Windows.Forms.TextBox txtModifCode;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.GroupBox GroupBox3;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.GroupBox GroupBox4;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.TextBox txtFiltreCode;
        private System.Windows.Forms.Label Label6;
    }
}

