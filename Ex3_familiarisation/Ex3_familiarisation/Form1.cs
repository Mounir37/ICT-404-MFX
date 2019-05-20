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
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Cmd_Calcul_Click(object sender, EventArgs e)
        {
            float brut;
            float famillial;
            float fidel;
            float transport = 0;
            float jeune = 0;
            if (!float.TryParse(textBox1.Text, out famillial))
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
            }
            float total = famillial / brut;

            if (ChBox_Rabais.Checked == true)
            {
                if (!float.TryParse(textBox5.Text, out fidel))
                {
                    MessageBox.Show("Entrez un chiffre SVP");
                    textBox5.Focus();
                    return;
                }
                fidel = total - (total / 100) * fidel;
                total = fidel;
            }
                
                
            if (ChBox_Transport.Checked == true)
            {
                if (!float.TryParse(textBox4.Text, out transport))
                {
                    MessageBox.Show("Entrez un chiffre SVP");
                    textBox4.Focus();
                    return;
                }
                total = total - transport;                                
            }

            if (ChBox_Jeune.Checked == true)
            {
                if (!float.TryParse(textBox3.Text, out jeune))
                {
                    MessageBox.Show("Entrez un chiffre SVP");
                    textBox3.Focus();
                    return;
                }
                total = total - jeune;
            }

            Lbl_revnue_imposable.Text = "Revenue Imposable : " + total.ToString();
        }

        private void ChBox_Rabais_CheckedChanged(object sender, EventArgs e)
        {

            if (ChBox_Rabais.Checked == false)
            {
                textBox5.Enabled = false;

            }
            if (ChBox_Rabais.Checked == true)
            {
                textBox5.Enabled = true;

            }
        }
        private void ChBox_Transport_CheckedChanged(object sender, EventArgs e)
        {

            if (ChBox_Transport.Checked == false)
            {
                textBox4.Enabled = false;

            }
            if (ChBox_Transport.Checked == true)
            {
                textBox4.Enabled = true;

            }
        }
        private void ChBox_Jeune_CheckedChanged(object sender, EventArgs e)
        {

            if (ChBox_Jeune.Checked == false)
            {
                textBox3.Enabled = false;

            }
            if (ChBox_Jeune.Checked == true)
            {
                textBox3.Enabled = true;

            }
        }

        private void Lbl_revnue_imposable_Click(object sender, EventArgs e)
        {

        }
    }
}
