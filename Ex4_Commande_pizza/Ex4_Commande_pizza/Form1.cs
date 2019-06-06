using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4_Commande_pizza
{
    public partial class Form_Pizza : Form
    {


        public Form_Pizza()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pate;
            string garniture;

            if (RadBtn_ExFine.Checked == true)
            {
                pate = RadBtn_ExFine.Text;
                lbl_ContenuCommande.Text = "Commande pour la table " + TxtB_table.Text + ", une pâte " + pate; // pas fini
            }
            if (RadBtn_fine.Checked == true)
            {
                pate = RadBtn_fine.Text;
                lbl_ContenuCommande.Text = "Commande pour la table " + TxtB_table.Text + ", une pâte " + pate; // pas fini
            }
            if (RadBtn_Normal.Checked == true)
            {
                pate = RadBtn_Normal.Text;
                lbl_ContenuCommande.Text = "Commande pour la table " + TxtB_table.Text + ", une pâte " + pate; // pas fini
            }
            if (RadBtn_Epaisse.Checked == true)
            {
                pate = RadBtn_Epaisse.Text;
                lbl_ContenuCommande.Text = "Commande pour la table " + TxtB_table.Text + ", une pâte " + pate; // pas fini
            }
        }

        private void RadBtn_ExFine_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
