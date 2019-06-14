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
        public Form1()
        {
            InitializeComponent();
        }

        private void rbtserie_CheckedChanged(object sender, EventArgs e)
        {
            txtBase.Text = "12300";
        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBase_TextChanged(object sender, EventArgs e)
        {
            int baseprice = int.Parse(txtBase.Text);
            if(baseprice < 10000)
            {
                MessageBox.Show("invalide");
            }
        }

        private void rbtprix_CheckedChanged(object sender, EventArgs e)
        {
            txtBase.Text = "14510" ; 
        }
    }
}
