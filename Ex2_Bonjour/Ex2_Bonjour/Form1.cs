using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2_Bonjour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Lbl_Nom_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lbl_Bjr_.Text = "Bonjour " + TxtB_Nom.Text;
            TxtB_Nom.Text = "";
            Btn_bienvenue.Enabled = false;
        }

        private void TxtB_Nom_TextChanged(object sender, EventArgs e)
        {
            Btn_bienvenue.Enabled = true;
            if (TxtB_Nom.Text == "")
            {
                Btn_bienvenue.Enabled = false;
            }
            else
            {
                Btn_bienvenue.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Btn_bienvenue.Enabled = false;
        }

        private void Lbl_Bjr__Click(object sender, EventArgs e)
        {

        }
    }
}
