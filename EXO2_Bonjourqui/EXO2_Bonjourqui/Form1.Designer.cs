namespace EXO2_Bonjourqui
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
            this.lblnom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblqui = new System.Windows.Forms.Label();
            this.buttonbienvenue = new System.Windows.Forms.Button();
            this.buttonquit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Location = new System.Drawing.Point(121, 83);
            this.lblnom.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(220, 34);
            this.lblnom.TabIndex = 0;
            this.lblnom.Text = "Votre nom ?";
            this.lblnom.Click += new System.EventHandler(this.lblnom_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(802, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 34);
            this.label2.TabIndex = 1;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(408, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 42);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblqui
            // 
            this.lblqui.AutoSize = true;
            this.lblqui.Location = new System.Drawing.Point(201, 198);
            this.lblqui.Name = "lblqui";
            this.lblqui.Size = new System.Drawing.Size(48, 34);
            this.lblqui.TabIndex = 3;
            this.lblqui.Text = "...";
            this.lblqui.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonbienvenue
            // 
            this.buttonbienvenue.Enabled = false;
            this.buttonbienvenue.Location = new System.Drawing.Point(354, 306);
            this.buttonbienvenue.Name = "buttonbienvenue";
            this.buttonbienvenue.Size = new System.Drawing.Size(291, 98);
            this.buttonbienvenue.TabIndex = 4;
            this.buttonbienvenue.Text = "Bienvenue ";
            this.buttonbienvenue.UseVisualStyleBackColor = true;
            this.buttonbienvenue.Click += new System.EventHandler(this.buttonBienvenue_Click);
            // 
            // buttonquit
            // 
            this.buttonquit.Image = global::EXO2_Bonjourqui.Properties.Resources.Xmoche;
            this.buttonquit.Location = new System.Drawing.Point(829, 352);
            this.buttonquit.Name = "buttonquit";
            this.buttonquit.Size = new System.Drawing.Size(116, 122);
            this.buttonquit.TabIndex = 5;
            this.buttonquit.UseVisualStyleBackColor = true;
            this.buttonquit.Click += new System.EventHandler(this.buttonquit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1033, 486);
            this.Controls.Add(this.buttonquit);
            this.Controls.Add(this.buttonbienvenue);
            this.Controls.Add(this.lblqui);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblnom);
            this.Font = new System.Drawing.Font("Rockwell Extra Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.Name = "Form1";
            this.Text = "Bonjour qui ?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblqui;
        private System.Windows.Forms.Button buttonbienvenue;
        private System.Windows.Forms.Button buttonquit;
    }
}

