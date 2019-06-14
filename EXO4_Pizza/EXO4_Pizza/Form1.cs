using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;                          
using System.Windows.Forms;
//EXO4_Pizza
//PPO
//14.06.2019

namespace EXO4_Pizza
{
    public partial class frapizza : Form
    {
        public frapizza()
        {
            InitializeComponent();
        }
        private void cmdcommander_Click(object sender, EventArgs e)
        {
            bool Avec = false; 
            string NomF;       
            string commande = "pour la table N° " + txtNtable.Text + " ";   
            

            if (txtNtable.Text == "")
            {
                MessageBox.Show("un numéro de table est requis");       //Pour obliger les gens a mettre un numero de table
                return;
            }
      
            NomF = "Table " + txtNtable.Text + ".txt";      //jsp a quoi sa sert 

            commande = commande +"pâte ";

            if(rbtEpaisse.Checked) commande = commande + "epaisse ";
            if (rbtEfine.Checked) commande = commande + "extra fine ";      //pour intégerer le type de pâte dans le text de la commande 
            if (rbtNormal.Checked) commande = commande + "normale ";
            if (rbtFine.Checked) commande = commande + "fine ";

            if (chkjambon.Checked || chkCapres.Checked || chkanchois.Checked || chkcrevettes.Checked) ;          //jsp a quoi sa sert    
            {
                commande = commande + "avec ";      //pour ajouter le "AVEC" dans le text de commande 
                Avec = true;                //jsp a ce que sa fait  
                if (chkanchois.Checked) commande = commande + "anchois, ";
                if (chkCapres.Checked) commande = commande + "capres, ";              //pour intégerer le type de garniture dans le text de la commande 
                if (chkjambon.Checked) commande = commande + "jambon, ";
                if (chkcrevettes.Checked) commande = commande + "crevettes, ";
                commande = commande.Substring(0, commande.Length - 2);          //je sais que sa sert a supprimer les 2 derniers caractaires mais je sais pas comment sa marche 
            }
            if (rbtbuffonne.Checked || rbtmaigre.Checked)           //changer le text de la commande en cas de mozz differante de normal 
            {
                if (Avec) commande = commande + " et mozzarella";       //text affiché si on change pas de mozzarella
                else commande = commande + " avec mozzarella";          //text affiché si on prend une autre mozzarella
                if (rbtbuffonne.Checked) commande = commande + " de bufflonne";  //si on check mozzarella buffone is l'ajoute au text  
                if (rbtmaigre.Checked) commande = commande + " maigre";      //si on check mozzarella maigre is l'ajoute au text 
            }
            txttotal.Text = commande;
                      //pour afficher un message comme quoi la commande a été envoyée 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       
    }
}
