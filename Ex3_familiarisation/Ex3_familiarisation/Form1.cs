using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3_familiarisation
{
    public partial class Form_Déduction : Form
    {
        public Form_Déduction()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Cmd_Calcul_Click(object sender, EventArgs e)
        {
            float brut;
            float famillial;            if (!float.TryParse(textBox1.Text,out famillial))
            {
                MessageBox.Show("Entrez un chiffre SVP");
                textBox1.Focus();
                return;
            }
            if (!float.TryParse(textBox2.Text, out brut))
            {
                MessageBox.Show("Entrez un chiffre SVP");
                textBox2.Focus();
                return;
            }            float total = famillial/brut;
            Lbl_revnue_imposable.Text = "Revenue Imposable : " + total.ToString();
        }
    }
}
