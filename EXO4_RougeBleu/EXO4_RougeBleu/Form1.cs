using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXO4_RougeBleu
{
    public partial class Form1 : Form
    {
        int compteurdeplacements;
        int compteurcouleurs;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdbleu_Click(object sender, EventArgs e)
        {

            this.BackColor = Color.Blue;
            compteurcouleurs = compteurcouleurs + 1;
        }

        private void cmdrouge_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            compteurcouleurs = compteurcouleurs + 1;
        }

        private void cmdstatu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deplacements : " + compteurdeplacements + " Couleurs : " + compteurcouleurs);
        }

        private void cmdquitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdHG_Click(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            compteurdeplacements = compteurdeplacements + 1;
        }

        private void cmdHD_Click(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.GetBounds(this).Width - this.Width);
            compteurdeplacements = compteurdeplacements + 1;
        }

        private void cmdBG_Click(object sender, EventArgs e)
        {
            this.Location = new Point(0, Screen.GetBounds(this).Height - this.Height);
            compteurdeplacements = compteurdeplacements + 1;
        }

        private void cmdBD_Click(object sender, EventArgs e)

        { 
            this.Location = new Point(Screen.GetBounds(this).Width - this.Width, Screen.GetBounds(this).Height - this.Height);
            compteurdeplacements = compteurdeplacements + 1;
        }
    }
}
