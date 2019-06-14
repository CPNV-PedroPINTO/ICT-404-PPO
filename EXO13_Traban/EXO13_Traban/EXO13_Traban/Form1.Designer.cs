namespace EXO13_Traban
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
            this.lblbase = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.grpmoteur = new System.Windows.Forms.GroupBox();
            this.rbtprix = new System.Windows.Forms.RadioButton();
            this.rbtserie = new System.Windows.Forms.RadioButton();
            this.chktaxes = new System.Windows.Forms.CheckBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtreset = new System.Windows.Forms.TextBox();
            this.cmdcalcul = new System.Windows.Forms.Button();
            this.grpmoteur.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblbase
            // 
            this.lblbase.AutoSize = true;
            this.lblbase.Location = new System.Drawing.Point(95, 56);
            this.lblbase.Name = "lblbase";
            this.lblbase.Size = new System.Drawing.Size(31, 13);
            this.lblbase.TabIndex = 0;
            this.lblbase.Text = "Base";
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(185, 53);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(116, 20);
            this.txtBase.TabIndex = 1;
            this.txtBase.Text = "12300";
            this.txtBase.TextChanged += new System.EventHandler(this.txtBase_TextChanged);
            // 
            // grpmoteur
            // 
            this.grpmoteur.Controls.Add(this.rbtprix);
            this.grpmoteur.Controls.Add(this.rbtserie);
            this.grpmoteur.Location = new System.Drawing.Point(98, 117);
            this.grpmoteur.Name = "grpmoteur";
            this.grpmoteur.Size = new System.Drawing.Size(134, 82);
            this.grpmoteur.TabIndex = 2;
            this.grpmoteur.TabStop = false;
            this.grpmoteur.Text = "Moteur";
            // 
            // rbtprix
            // 
            this.rbtprix.AutoSize = true;
            this.rbtprix.Location = new System.Drawing.Point(16, 42);
            this.rbtprix.Name = "rbtprix";
            this.rbtprix.Size = new System.Drawing.Size(87, 17);
            this.rbtprix.TabIndex = 4;
            this.rbtprix.Text = "1.6L : 2\'210$";
            this.rbtprix.UseVisualStyleBackColor = true;
            this.rbtprix.CheckedChanged += new System.EventHandler(this.rbtprix_CheckedChanged);
            // 
            // rbtserie
            // 
            this.rbtserie.AutoSize = true;
            this.rbtserie.Checked = true;
            this.rbtserie.Location = new System.Drawing.Point(16, 19);
            this.rbtserie.Name = "rbtserie";
            this.rbtserie.Size = new System.Drawing.Size(94, 17);
            this.rbtserie.TabIndex = 5;
            this.rbtserie.TabStop = true;
            this.rbtserie.Text = "1.4L : De série";
            this.rbtserie.UseVisualStyleBackColor = true;
            this.rbtserie.CheckedChanged += new System.EventHandler(this.rbtserie_CheckedChanged);
            // 
            // chktaxes
            // 
            this.chktaxes.AutoSize = true;
            this.chktaxes.Location = new System.Drawing.Point(98, 247);
            this.chktaxes.Name = "chktaxes";
            this.chktaxes.Size = new System.Drawing.Size(83, 17);
            this.chktaxes.TabIndex = 3;
            this.chktaxes.Text = "taxes (6.8%)";
            this.chktaxes.UseVisualStyleBackColor = true;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(95, 348);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(31, 13);
            this.lbltotal.TabIndex = 4;
            this.lbltotal.Text = "Total";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(185, 345);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(116, 20);
            this.txttotal.TabIndex = 5;
            this.txttotal.TextChanged += new System.EventHandler(this.txttotal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "€ ";
            // 
            // txtreset
            // 
            this.txtreset.Location = new System.Drawing.Point(98, 293);
            this.txtreset.Name = "txtreset";
            this.txtreset.Size = new System.Drawing.Size(134, 20);
            this.txtreset.TabIndex = 7;
            this.txtreset.Text = "Remetre le formulaire a zero";
            // 
            // cmdcalcul
            // 
            this.cmdcalcul.Location = new System.Drawing.Point(310, 398);
            this.cmdcalcul.Name = "cmdcalcul";
            this.cmdcalcul.Size = new System.Drawing.Size(111, 23);
            this.cmdcalcul.TabIndex = 8;
            this.cmdcalcul.Text = "Calculer";
            this.cmdcalcul.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 450);
            this.Controls.Add(this.cmdcalcul);
            this.Controls.Add(this.txtreset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.chktaxes);
            this.Controls.Add(this.grpmoteur);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.lblbase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpmoteur.ResumeLayout(false);
            this.grpmoteur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbase;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.GroupBox grpmoteur;
        private System.Windows.Forms.RadioButton rbtprix;
        private System.Windows.Forms.RadioButton rbtserie;
        private System.Windows.Forms.CheckBox chktaxes;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtreset;
        private System.Windows.Forms.Button cmdcalcul;
    }
}

