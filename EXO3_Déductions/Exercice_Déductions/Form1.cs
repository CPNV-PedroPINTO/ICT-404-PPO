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
            
        }

        private void txtbrut_TextChanged(object sender, EventArgs e)
        {
           
            if (txtbrut.Text == "") cmdcalcul.Enabled = false;
            else cmdcalcul.Enabled = true;
         if ()
        }

        private void txtfamille_TextChanged(object sender, EventArgs e)
        {
        
            cmdcalcul.Enabled = true;
            if (txtfamille.Text == "") cmdcalcul.Enabled = false;
            else cmdcalcul.Enabled = true;
        }
    }
}
