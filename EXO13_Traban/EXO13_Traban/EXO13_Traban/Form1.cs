using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXO13_Traban
{
    public partial class Form1 : Form
    {
        String memoire;

        public Form1()
        {
            InitializeComponent();
        }
        private void calcul()
        {
            double baseprice = double.Parse(txtBase.Text);
            if (baseprice < 10000)
            {
                MessageBox.Show("invalide");
                txtBase.Text = memoire;
            }
            if (rbt4.Checked == true)
            {

            }
            if (rbt6.Checked == true)
            {
                baseprice = baseprice + 2210;
            }
            if (chktaxes.Checked == true)
            {
                baseprice = baseprice + baseprice / 100 * 6.8;
            }

            txttotal.Text = String.Format("{0:F1}",baseprice);
        }
        private void rbt4_CheckedChanged(object sender, EventArgs e)
        {
            calcul();
            txttotal.Text = "12300";
        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBase_TextChanged(object sender, EventArgs e)
        {
            calcul();
        }

        private void rbt6_CheckedChanged(object sender, EventArgs e)
        {
            calcul();
          
        }

        private void cmdreset_Click(object sender, EventArgs e)
        {
            chktaxes.Checked = false;
            rbt4.Checked = true; 
            rbt6.Checked = false;
            txtBase.Text = "12300";
            txttotal.Text = ""; 
        }

        private void txtBase_Enter(object sender, EventArgs e)
        {
            memoire = txtBase.Text;
        }

        private void chktaxes_CheckedChanged(object sender, EventArgs e)
        {
            calcul();
        }
    }
}
