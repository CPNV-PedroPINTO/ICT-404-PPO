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
            float brut;
            float famille;
            float jeune=0 ;
            float transport=0 ;
            float fidelite=0;
            float tot;
            float resultat;
            if (!float.TryParse(txtbrut.Text, out brut))
            {
                MessageBox.Show("Pas ok");
                return;
            }
            if (!float.TryParse(txtfamille.Text, out famille))
            {
                MessageBox.Show("Pas ok");
                return;
            }
           
            
            tot = brut / famille;
            resultat = brut / famille;                        //calculs
            if (chkjeune.Checked == true) 
            {
                if (!float.TryParse(txtjeune.Text, out jeune))
                {
                    MessageBox.Show("Pas ok");
                    return;
                }
                resultat = resultat - jeune;
            }
            if (chktransports.Checked == true)
            {
                if (!float.TryParse(txttransport.Text, out transport))
                {
                    MessageBox.Show("Pas ok");
                    return;
                }
                resultat = resultat - transport;
            }
            if (chkfildelite.Checked == true)
            {
                if (!float.TryParse(txtfidelite.Text, out fidelite))
                {
                    MessageBox.Show("Pas ok");
                    return;
                }
                resultat = resultat - fidelite;
            }
            lblrevenu.Text = "Revenu imposable : " + (brut / famille - jeune - transport - (fidelite/100*tot));
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
