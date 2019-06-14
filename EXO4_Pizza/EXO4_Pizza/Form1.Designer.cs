namespace EXO4_Pizza
{
    partial class frapizza
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
            this.chkanchois = new System.Windows.Forms.CheckBox();
            this.chkcrevettes = new System.Windows.Forms.CheckBox();
            this.chkjambon = new System.Windows.Forms.CheckBox();
            this.chkCapres = new System.Windows.Forms.CheckBox();
            this.rbtEfine = new System.Windows.Forms.RadioButton();
            this.rbtEpaisse = new System.Windows.Forms.RadioButton();
            this.rbtNormal = new System.Windows.Forms.RadioButton();
            this.rbtFine = new System.Windows.Forms.RadioButton();
            this.grpPate = new System.Windows.Forms.GroupBox();
            this.cmdcommander = new System.Windows.Forms.Button();
            this.lbltable = new System.Windows.Forms.Label();
            this.lblcommande = new System.Windows.Forms.Label();
            this.txtNtable = new System.Windows.Forms.TextBox();
            this.lbltout = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.grpmozzarella = new System.Windows.Forms.GroupBox();
            this.rbtnormale = new System.Windows.Forms.RadioButton();
            this.rbtbuffonne = new System.Windows.Forms.RadioButton();
            this.rbtmaigre = new System.Windows.Forms.RadioButton();
            this.cmdcharger = new System.Windows.Forms.Button();
            this.grpPate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.grpmozzarella.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkanchois
            // 
            this.chkanchois.AutoSize = true;
            this.chkanchois.Location = new System.Drawing.Point(321, 93);
            this.chkanchois.Name = "chkanchois";
            this.chkanchois.Size = new System.Drawing.Size(64, 17);
            this.chkanchois.TabIndex = 0;
            this.chkanchois.Text = "Anchois";
            this.chkanchois.UseVisualStyleBackColor = true;
            // 
            // chkcrevettes
            // 
            this.chkcrevettes.AutoSize = true;
            this.chkcrevettes.Location = new System.Drawing.Point(321, 162);
            this.chkcrevettes.Name = "chkcrevettes";
            this.chkcrevettes.Size = new System.Drawing.Size(71, 17);
            this.chkcrevettes.TabIndex = 1;
            this.chkcrevettes.Text = "Crevettes";
            this.chkcrevettes.UseVisualStyleBackColor = true;
            // 
            // chkjambon
            // 
            this.chkjambon.AutoSize = true;
            this.chkjambon.Location = new System.Drawing.Point(321, 139);
            this.chkjambon.Name = "chkjambon";
            this.chkjambon.Size = new System.Drawing.Size(63, 17);
            this.chkjambon.TabIndex = 2;
            this.chkjambon.Text = "Jambon";
            this.chkjambon.UseVisualStyleBackColor = true;
            // 
            // chkCapres
            // 
            this.chkCapres.AutoSize = true;
            this.chkCapres.Location = new System.Drawing.Point(321, 116);
            this.chkCapres.Name = "chkCapres";
            this.chkCapres.Size = new System.Drawing.Size(59, 17);
            this.chkCapres.TabIndex = 3;
            this.chkCapres.Text = "Câpres";
            this.chkCapres.UseVisualStyleBackColor = true;
            // 
            // rbtEfine
            // 
            this.rbtEfine.AutoSize = true;
            this.rbtEfine.Location = new System.Drawing.Point(26, 34);
            this.rbtEfine.Name = "rbtEfine";
            this.rbtEfine.Size = new System.Drawing.Size(69, 17);
            this.rbtEfine.TabIndex = 4;
            this.rbtEfine.TabStop = true;
            this.rbtEfine.Text = "Extra-fine";
            this.rbtEfine.UseVisualStyleBackColor = true;
            // 
            // rbtEpaisse
            // 
            this.rbtEpaisse.AutoSize = true;
            this.rbtEpaisse.Location = new System.Drawing.Point(26, 103);
            this.rbtEpaisse.Name = "rbtEpaisse";
            this.rbtEpaisse.Size = new System.Drawing.Size(62, 17);
            this.rbtEpaisse.TabIndex = 5;
            this.rbtEpaisse.TabStop = true;
            this.rbtEpaisse.Text = "Epaisse";
            this.rbtEpaisse.UseVisualStyleBackColor = true;
            // 
            // rbtNormal
            // 
            this.rbtNormal.AutoSize = true;
            this.rbtNormal.Location = new System.Drawing.Point(26, 80);
            this.rbtNormal.Name = "rbtNormal";
            this.rbtNormal.Size = new System.Drawing.Size(58, 17);
            this.rbtNormal.TabIndex = 6;
            this.rbtNormal.TabStop = true;
            this.rbtNormal.Text = "Normal";
            this.rbtNormal.UseVisualStyleBackColor = true;
            // 
            // rbtFine
            // 
            this.rbtFine.AutoSize = true;
            this.rbtFine.Location = new System.Drawing.Point(26, 57);
            this.rbtFine.Name = "rbtFine";
            this.rbtFine.Size = new System.Drawing.Size(45, 17);
            this.rbtFine.TabIndex = 7;
            this.rbtFine.TabStop = true;
            this.rbtFine.Text = "Fine";
            this.rbtFine.UseVisualStyleBackColor = true;
            // 
            // grpPate
            // 
            this.grpPate.Controls.Add(this.rbtEfine);
            this.grpPate.Controls.Add(this.rbtEpaisse);
            this.grpPate.Controls.Add(this.rbtNormal);
            this.grpPate.Controls.Add(this.rbtFine);
            this.grpPate.Location = new System.Drawing.Point(49, 69);
            this.grpPate.Name = "grpPate";
            this.grpPate.Size = new System.Drawing.Size(122, 131);
            this.grpPate.TabIndex = 8;
            this.grpPate.TabStop = false;
            this.grpPate.Text = "Pâte";
            // 
            // cmdcommander
            // 
            this.cmdcommander.Location = new System.Drawing.Point(189, 221);
            this.cmdcommander.Name = "cmdcommander";
            this.cmdcommander.Size = new System.Drawing.Size(110, 27);
            this.cmdcommander.TabIndex = 9;
            this.cmdcommander.Text = "Commander";
            this.cmdcommander.UseVisualStyleBackColor = true;
            this.cmdcommander.Click += new System.EventHandler(this.cmdcommander_Click);
            // 
            // lbltable
            // 
            this.lbltable.AutoSize = true;
            this.lbltable.Location = new System.Drawing.Point(46, 40);
            this.lbltable.Name = "lbltable";
            this.lbltable.Size = new System.Drawing.Size(34, 13);
            this.lbltable.TabIndex = 10;
            this.lbltable.Text = "Table";
            // 
            // lblcommande
            // 
            this.lblcommande.AutoSize = true;
            this.lblcommande.Location = new System.Drawing.Point(123, 302);
            this.lblcommande.Name = "lblcommande";
            this.lblcommande.Size = new System.Drawing.Size(65, 13);
            this.lblcommande.TabIndex = 11;
            this.lblcommande.Text = "Répertoire : ";
            this.lblcommande.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNtable
            // 
            this.txtNtable.Location = new System.Drawing.Point(101, 37);
            this.txtNtable.Name = "txtNtable";
            this.txtNtable.Size = new System.Drawing.Size(28, 20);
            this.txtNtable.TabIndex = 12;
            // 
            // lbltout
            // 
            this.lbltout.AutoSize = true;
            this.lbltout.Location = new System.Drawing.Point(171, 384);
            this.lbltout.Name = "lbltout";
            this.lbltout.Size = new System.Drawing.Size(0, 13);
            this.lbltout.TabIndex = 13;
            this.lbltout.Click += new System.EventHandler(this.label1_Click);
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.Color.Yellow;
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(196, 279);
            this.txttotal.Margin = new System.Windows.Forms.Padding(5);
            this.txttotal.Multiline = true;
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(285, 118);
            this.txttotal.TabIndex = 14;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // grpmozzarella
            // 
            this.grpmozzarella.Controls.Add(this.rbtnormale);
            this.grpmozzarella.Controls.Add(this.rbtbuffonne);
            this.grpmozzarella.Controls.Add(this.rbtmaigre);
            this.grpmozzarella.Location = new System.Drawing.Point(177, 69);
            this.grpmozzarella.Name = "grpmozzarella";
            this.grpmozzarella.Size = new System.Drawing.Size(122, 131);
            this.grpmozzarella.TabIndex = 9;
            this.grpmozzarella.TabStop = false;
            this.grpmozzarella.Text = "Mozzarella";
            this.grpmozzarella.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbtnormale
            // 
            this.rbtnormale.AutoSize = true;
            this.rbtnormale.Location = new System.Drawing.Point(26, 34);
            this.rbtnormale.Name = "rbtnormale";
            this.rbtnormale.Size = new System.Drawing.Size(64, 17);
            this.rbtnormale.TabIndex = 4;
            this.rbtnormale.TabStop = true;
            this.rbtnormale.Text = "Normale";
            this.rbtnormale.UseVisualStyleBackColor = false;
            // 
            // rbtbuffonne
            // 
            this.rbtbuffonne.AutoSize = true;
            this.rbtbuffonne.Location = new System.Drawing.Point(26, 80);
            this.rbtbuffonne.Name = "rbtbuffonne";
            this.rbtbuffonne.Size = new System.Drawing.Size(73, 17);
            this.rbtbuffonne.TabIndex = 6;
            this.rbtbuffonne.TabStop = true;
            this.rbtbuffonne.Text = "Bufflonne ";
            this.rbtbuffonne.UseVisualStyleBackColor = true;
            // 
            // rbtmaigre
            // 
            this.rbtmaigre.AutoSize = true;
            this.rbtmaigre.Location = new System.Drawing.Point(26, 57);
            this.rbtmaigre.Name = "rbtmaigre";
            this.rbtmaigre.Size = new System.Drawing.Size(57, 17);
            this.rbtmaigre.TabIndex = 7;
            this.rbtmaigre.TabStop = true;
            this.rbtmaigre.Text = "Maigre";
            this.rbtmaigre.UseVisualStyleBackColor = true;
            // 
            // cmdcharger
            // 
            this.cmdcharger.Location = new System.Drawing.Point(20, 298);
            this.cmdcharger.Name = "cmdcharger";
            this.cmdcharger.Size = new System.Drawing.Size(97, 20);
            this.cmdcharger.TabIndex = 15;
            this.cmdcharger.Text = "Charger";
            this.cmdcharger.UseVisualStyleBackColor = true;
            // 
            // frapizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 450);
            this.Controls.Add(this.cmdcharger);
            this.Controls.Add(this.grpmozzarella);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.lbltout);
            this.Controls.Add(this.txtNtable);
            this.Controls.Add(this.lblcommande);
            this.Controls.Add(this.lbltable);
            this.Controls.Add(this.cmdcommander);
            this.Controls.Add(this.grpPate);
            this.Controls.Add(this.chkCapres);
            this.Controls.Add(this.chkjambon);
            this.Controls.Add(this.chkcrevettes);
            this.Controls.Add(this.chkanchois);
            this.Name = "frapizza";
            this.Text = "Pizza";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpPate.ResumeLayout(false);
            this.grpPate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.grpmozzarella.ResumeLayout(false);
            this.grpmozzarella.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkanchois;
        private System.Windows.Forms.CheckBox chkcrevettes;
        private System.Windows.Forms.CheckBox chkjambon;
        private System.Windows.Forms.CheckBox chkCapres;
        private System.Windows.Forms.RadioButton rbtEfine;
        private System.Windows.Forms.RadioButton rbtEpaisse;
        private System.Windows.Forms.RadioButton rbtNormal;
        private System.Windows.Forms.RadioButton rbtFine;
        private System.Windows.Forms.GroupBox grpPate;
        private System.Windows.Forms.Button cmdcommander;
        private System.Windows.Forms.Label lbltable;
        private System.Windows.Forms.Label lblcommande;
        private System.Windows.Forms.TextBox txtNtable;
        private System.Windows.Forms.Label lbltout;
        private System.Windows.Forms.TextBox txttotal;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox grpmozzarella;
        private System.Windows.Forms.RadioButton rbtnormale;
        private System.Windows.Forms.RadioButton rbtbuffonne;
        private System.Windows.Forms.RadioButton rbtmaigre;
        private System.Windows.Forms.Button cmdcharger;
    }
}

