using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice_Déductions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdcalcul_Click(object sender, EventArgs e)
        {
            float brut = float.Parse(txtbrut.Text);
            float famille = float.Parse(txtfamille.Text);
            float jeune = float.Parse(txtjeune.Text);
            float transport = float.Parse(txttransport.Text);
            float fidelite = float.Parse(txtfidelite.Text);
            float tot = brut / famille - jeune - transport;
            lblrevenu.Text = "Revenu imposable : " + (brut / famille - jeune - transport - (fidelite/100*tot));      //calculs
        }

        private void txtbrut_TextChanged(object sender, EventArgs e)
        {
            
            if (txtbrut.Text == "") cmdcalcul.Enabled = false;
            else cmdcalcul.Enabled = true;
         
        }

        private void txtfamille_TextChanged(object sender, EventArgs e)
        {
            
            cmdcalcul.Enabled = true;
            if (txtfamille.Text == "") cmdcalcul.Enabled = false;
            else cmdcalcul.Enabled = true;
            
        }

        private void chkjeune_CheckedChanged(object sender, EventArgs e)
        {
            
            if(chkjeune.Checked == true) txtjeune.Enabled = true;
            else txtjeune.Enabled = false;
        }

        private void txttransport_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void chkfildelite_CheckedChanged(object sender, EventArgs e)
        {
            txtfidelite.Enabled = true;
            if (chkfildelite.Checked == true) txtfidelite.Enabled = true;
            else txtfidelite.Enabled = false; 
        }

        private void chktransports_CheckedChanged(object sender, EventArgs e)
        {
       
            if (chktransports.Checked == true) txttransport.Enabled = true;
            else txttransport.Enabled = false;

        }

        private void lblrevenu_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtjeune_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtfidelite_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
