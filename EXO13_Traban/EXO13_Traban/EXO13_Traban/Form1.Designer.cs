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
            this.rbt6 = new System.Windows.Forms.RadioButton();
            this.rbt4 = new System.Windows.Forms.RadioButton();
            this.chktaxes = new System.Windows.Forms.CheckBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdreset = new System.Windows.Forms.Button();
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
            this.txtBase.Enter += new System.EventHandler(this.txtBase_Enter);
            this.txtBase.Validated += new System.EventHandler(this.txtBase_TextChanged);
            // 
            // grpmoteur
            // 
            this.grpmoteur.Controls.Add(this.rbt6);
            this.grpmoteur.Controls.Add(this.rbt4);
            this.grpmoteur.Location = new System.Drawing.Point(98, 117);
            this.grpmoteur.Name = "grpmoteur";
            this.grpmoteur.Size = new System.Drawing.Size(134, 82);
            this.grpmoteur.TabIndex = 2;
            this.grpmoteur.TabStop = false;
            this.grpmoteur.Text = "Moteur";
            // 
            // rbt6
            // 
            this.rbt6.AutoSize = true;
            this.rbt6.Location = new System.Drawing.Point(16, 42);
            this.rbt6.Name = "rbt6";
            this.rbt6.Size = new System.Drawing.Size(87, 17);
            this.rbt6.TabIndex = 4;
            this.rbt6.Text = "1.6L : 2\'210$";
            this.rbt6.UseVisualStyleBackColor = true;
            this.rbt6.CheckedChanged += new System.EventHandler(this.rbt6_CheckedChanged);
            // 
            // rbt4
            // 
            this.rbt4.AutoSize = true;
            this.rbt4.Checked = true;
            this.rbt4.Location = new System.Drawing.Point(16, 19);
            this.rbt4.Name = "rbt4";
            this.rbt4.Size = new System.Drawing.Size(94, 17);
            this.rbt4.TabIndex = 5;
            this.rbt4.TabStop = true;
            this.rbt4.Text = "1.4L : De série";
            this.rbt4.UseVisualStyleBackColor = true;
            this.rbt4.CheckedChanged += new System.EventHandler(this.rbt4_CheckedChanged);
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
            this.chktaxes.CheckedChanged += new System.EventHandler(this.chktaxes_CheckedChanged);
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
            // cmdreset
            // 
            this.cmdreset.Location = new System.Drawing.Point(98, 283);
            this.cmdreset.Name = "cmdreset";
            this.cmdreset.Size = new System.Drawing.Size(175, 26);
            this.cmdreset.TabIndex = 7;
            this.cmdreset.Text = "remettre le programme a zero ";
            this.cmdreset.UseVisualStyleBackColor = true;
            this.cmdreset.Click += new System.EventHandler(this.cmdreset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 450);
            this.Controls.Add(this.cmdreset);
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
        private System.Windows.Forms.RadioButton rbt6;
        private System.Windows.Forms.RadioButton rbt4;
        private System.Windows.Forms.CheckBox chktaxes;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdreset;
    }
}

