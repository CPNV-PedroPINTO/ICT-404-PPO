namespace Exercice_Déductions
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
            this.lblbrut = new System.Windows.Forms.Label();
            this.lblfamille = new System.Windows.Forms.Label();
            this.cmdcalcul = new System.Windows.Forms.Button();
            this.chktransports = new System.Windows.Forms.CheckBox();
            this.chkjeune = new System.Windows.Forms.CheckBox();
            this.chkfildelite = new System.Windows.Forms.CheckBox();
            this.lblrevenu = new System.Windows.Forms.Label();
            this.txtbrut = new System.Windows.Forms.TextBox();
            this.txtfamille = new System.Windows.Forms.TextBox();
            this.txtjeune = new System.Windows.Forms.TextBox();
            this.txtfidelite = new System.Windows.Forms.TextBox();
            this.txttransport = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblbrut
            // 
            this.lblbrut.AutoSize = true;
            this.lblbrut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbrut.Location = new System.Drawing.Point(77, 55);
            this.lblbrut.Name = "lblbrut";
            this.lblbrut.Size = new System.Drawing.Size(119, 13);
            this.lblbrut.TabIndex = 0;
            this.lblbrut.Text = "Revenu annuel brut";
            // 
            // lblfamille
            // 
            this.lblfamille.AutoSize = true;
            this.lblfamille.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfamille.Location = new System.Drawing.Point(77, 100);
            this.lblfamille.Name = "lblfamille";
            this.lblfamille.Size = new System.Drawing.Size(111, 13);
            this.lblfamille.TabIndex = 3;
            this.lblfamille.Text = "Coefficient familial";
            // 
            // cmdcalcul
            // 
            this.cmdcalcul.Enabled = false;
            this.cmdcalcul.Location = new System.Drawing.Point(231, 243);
            this.cmdcalcul.Name = "cmdcalcul";
            this.cmdcalcul.Size = new System.Drawing.Size(104, 28);
            this.cmdcalcul.TabIndex = 4;
            this.cmdcalcul.Text = "Calcul";
            this.cmdcalcul.UseVisualStyleBackColor = true;
            this.cmdcalcul.Click += new System.EventHandler(this.cmdcalcul_Click);
            // 
            // chktransports
            // 
            this.chktransports.AutoSize = true;
            this.chktransports.Location = new System.Drawing.Point(98, 170);
            this.chktransports.Name = "chktransports";
            this.chktransports.Size = new System.Drawing.Size(119, 17);
            this.chktransports.TabIndex = 5;
            this.chktransports.Text = "Deduction transport";
            this.chktransports.UseVisualStyleBackColor = true;
            this.chktransports.CheckedChanged += new System.EventHandler(this.chktransports_CheckedChanged);
            // 
            // chkjeune
            // 
            this.chkjeune.AutoSize = true;
            this.chkjeune.Location = new System.Drawing.Point(98, 137);
            this.chkjeune.Name = "chkjeune";
            this.chkjeune.Size = new System.Drawing.Size(104, 17);
            this.chkjeune.TabIndex = 6;
            this.chkjeune.Text = "Deduction jeune";
            this.chkjeune.UseVisualStyleBackColor = true;
            this.chkjeune.CheckedChanged += new System.EventHandler(this.chkjeune_CheckedChanged);
            // 
            // chkfildelite
            // 
            this.chkfildelite.AutoSize = true;
            this.chkfildelite.Location = new System.Drawing.Point(98, 202);
            this.chkfildelite.Name = "chkfildelite";
            this.chkfildelite.Size = new System.Drawing.Size(92, 17);
            this.chkfildelite.TabIndex = 7;
            this.chkfildelite.Text = "Rabais fidelite";
            this.chkfildelite.UseVisualStyleBackColor = true;
            this.chkfildelite.CheckedChanged += new System.EventHandler(this.chkfildelite_CheckedChanged);
            // 
            // lblrevenu
            // 
            this.lblrevenu.AutoSize = true;
            this.lblrevenu.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrevenu.Location = new System.Drawing.Point(128, 309);
            this.lblrevenu.Name = "lblrevenu";
            this.lblrevenu.Size = new System.Drawing.Size(223, 27);
            this.lblrevenu.TabIndex = 8;
            this.lblrevenu.Text = "Revenu imposable : ";
            this.lblrevenu.Click += new System.EventHandler(this.lblrevenu_Click);
            // 
            // txtbrut
            // 
            this.txtbrut.Location = new System.Drawing.Point(270, 52);
            this.txtbrut.Name = "txtbrut";
            this.txtbrut.Size = new System.Drawing.Size(183, 20);
            this.txtbrut.TabIndex = 9;
            this.txtbrut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbrut.TextChanged += new System.EventHandler(this.txtbrut_TextChanged);
            // 
            // txtfamille
            // 
            this.txtfamille.Location = new System.Drawing.Point(386, 97);
            this.txtfamille.Name = "txtfamille";
            this.txtfamille.Size = new System.Drawing.Size(67, 20);
            this.txtfamille.TabIndex = 10;
            this.txtfamille.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtfamille.TextChanged += new System.EventHandler(this.txtfamille_TextChanged);
            // 
            // txtjeune
            // 
            this.txtjeune.AcceptsTab = true;
            this.txtjeune.Enabled = false;
            this.txtjeune.Location = new System.Drawing.Point(386, 135);
            this.txtjeune.Name = "txtjeune";
            this.txtjeune.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtjeune.Size = new System.Drawing.Size(67, 20);
            this.txtjeune.TabIndex = 11;
            this.txtjeune.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtjeune.TextChanged += new System.EventHandler(this.txtjeune_TextChanged);
            // 
            // txtfidelite
            // 
            this.txtfidelite.Enabled = false;
            this.txtfidelite.Location = new System.Drawing.Point(386, 200);
            this.txtfidelite.Name = "txtfidelite";
            this.txtfidelite.Size = new System.Drawing.Size(67, 20);
            this.txtfidelite.TabIndex = 12;
            this.txtfidelite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtfidelite.TextChanged += new System.EventHandler(this.txtfidelite_TextChanged);
            // 
            // txttransport
            // 
            this.txttransport.Enabled = false;
            this.txttransport.Location = new System.Drawing.Point(386, 167);
            this.txttransport.Name = "txttransport";
            this.txttransport.Size = new System.Drawing.Size(67, 20);
            this.txttransport.TabIndex = 13;
            this.txttransport.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttransport.TextChanged += new System.EventHandler(this.txttransport_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 367);
            this.Controls.Add(this.txttransport);
            this.Controls.Add(this.txtfidelite);
            this.Controls.Add(this.txtjeune);
            this.Controls.Add(this.txtfamille);
            this.Controls.Add(this.txtbrut);
            this.Controls.Add(this.lblrevenu);
            this.Controls.Add(this.chkfildelite);
            this.Controls.Add(this.chkjeune);
            this.Controls.Add(this.chktransports);
            this.Controls.Add(this.cmdcalcul);
            this.Controls.Add(this.lblfamille);
            this.Controls.Add(this.lblbrut);
            this.Name = "Form1";
            this.Text = "Deduction";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbrut;
        private System.Windows.Forms.Label lblfamille;
        private System.Windows.Forms.Button cmdcalcul;
        private System.Windows.Forms.CheckBox chktransports;
        private System.Windows.Forms.CheckBox chkjeune;
        private System.Windows.Forms.CheckBox chkfildelite;
        private System.Windows.Forms.Label lblrevenu;
        private System.Windows.Forms.TextBox txtbrut;
        private System.Windows.Forms.TextBox txtfamille;
        private System.Windows.Forms.TextBox txtjeune;
        private System.Windows.Forms.TextBox txtfidelite;
        private System.Windows.Forms.TextBox txttransport;
    }
}

