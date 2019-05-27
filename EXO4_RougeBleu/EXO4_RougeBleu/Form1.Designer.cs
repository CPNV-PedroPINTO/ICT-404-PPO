namespace EXO4_RougeBleu
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
            this.cmdHG = new System.Windows.Forms.Button();
            this.cmdBG = new System.Windows.Forms.Button();
            this.cmdBD = new System.Windows.Forms.Button();
            this.cmdHD = new System.Windows.Forms.Button();
            this.cmdbleu = new System.Windows.Forms.Button();
            this.cmdrouge = new System.Windows.Forms.Button();
            this.cmdstat = new System.Windows.Forms.Button();
            this.cmdquitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdHG
            // 
            this.cmdHG.Location = new System.Drawing.Point(12, 12);
            this.cmdHG.Name = "cmdHG";
            this.cmdHG.Size = new System.Drawing.Size(84, 23);
            this.cmdHG.TabIndex = 0;
            this.cmdHG.Text = "Haut/Gauche";
            this.cmdHG.UseVisualStyleBackColor = true;
            this.cmdHG.Click += new System.EventHandler(this.cmdHG_Click);
            // 
            // cmdBG
            // 
            this.cmdBG.Location = new System.Drawing.Point(12, 415);
            this.cmdBG.Name = "cmdBG";
            this.cmdBG.Size = new System.Drawing.Size(84, 23);
            this.cmdBG.TabIndex = 1;
            this.cmdBG.Text = "Bas/Gauche";
            this.cmdBG.UseVisualStyleBackColor = true;
            this.cmdBG.Click += new System.EventHandler(this.cmdBG_Click);
            // 
            // cmdBD
            // 
            this.cmdBD.Location = new System.Drawing.Point(713, 415);
            this.cmdBD.Name = "cmdBD";
            this.cmdBD.Size = new System.Drawing.Size(75, 23);
            this.cmdBD.TabIndex = 2;
            this.cmdBD.Text = "Bas/Droite";
            this.cmdBD.UseVisualStyleBackColor = true;
            this.cmdBD.Click += new System.EventHandler(this.cmdBD_Click);
            // 
            // cmdHD
            // 
            this.cmdHD.Location = new System.Drawing.Point(713, 12);
            this.cmdHD.Name = "cmdHD";
            this.cmdHD.Size = new System.Drawing.Size(75, 23);
            this.cmdHD.TabIndex = 3;
            this.cmdHD.Text = "Haut/Droite";
            this.cmdHD.UseVisualStyleBackColor = true;
            this.cmdHD.Click += new System.EventHandler(this.cmdHD_Click);
            // 
            // cmdbleu
            // 
            this.cmdbleu.Location = new System.Drawing.Point(379, 88);
            this.cmdbleu.Name = "cmdbleu";
            this.cmdbleu.Size = new System.Drawing.Size(75, 23);
            this.cmdbleu.TabIndex = 4;
            this.cmdbleu.Text = "Bleu";
            this.cmdbleu.UseVisualStyleBackColor = true;
            this.cmdbleu.Click += new System.EventHandler(this.cmdbleu_Click);
            // 
            // cmdrouge
            // 
            this.cmdrouge.Location = new System.Drawing.Point(379, 139);
            this.cmdrouge.Name = "cmdrouge";
            this.cmdrouge.Size = new System.Drawing.Size(75, 23);
            this.cmdrouge.TabIndex = 5;
            this.cmdrouge.Text = "Rouge";
            this.cmdrouge.UseVisualStyleBackColor = true;
            this.cmdrouge.Click += new System.EventHandler(this.cmdrouge_Click);
            // 
            // cmdstat
            // 
            this.cmdstat.Location = new System.Drawing.Point(379, 232);
            this.cmdstat.Name = "cmdstat";
            this.cmdstat.Size = new System.Drawing.Size(75, 23);
            this.cmdstat.TabIndex = 6;
            this.cmdstat.Text = "Stats";
            this.cmdstat.UseVisualStyleBackColor = true;
            this.cmdstat.Click += new System.EventHandler(this.cmdstatu_Click);
            // 
            // cmdquitter
            // 
            this.cmdquitter.Location = new System.Drawing.Point(379, 272);
            this.cmdquitter.Name = "cmdquitter";
            this.cmdquitter.Size = new System.Drawing.Size(75, 23);
            this.cmdquitter.TabIndex = 7;
            this.cmdquitter.Text = "Quitter";
            this.cmdquitter.UseVisualStyleBackColor = true;
            this.cmdquitter.Click += new System.EventHandler(this.cmdquitter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdquitter);
            this.Controls.Add(this.cmdstat);
            this.Controls.Add(this.cmdrouge);
            this.Controls.Add(this.cmdbleu);
            this.Controls.Add(this.cmdHD);
            this.Controls.Add(this.cmdBD);
            this.Controls.Add(this.cmdBG);
            this.Controls.Add(this.cmdHG);
            this.Name = "Form1";
            this.Text = "Fenêtre";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdHG;
        private System.Windows.Forms.Button cmdBG;
        private System.Windows.Forms.Button cmdBD;
        private System.Windows.Forms.Button cmdHD;
        private System.Windows.Forms.Button cmdbleu;
        private System.Windows.Forms.Button cmdrouge;
        private System.Windows.Forms.Button cmdstat;
        private System.Windows.Forms.Button cmdquitter;
    }
}

