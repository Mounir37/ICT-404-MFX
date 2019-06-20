using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex6_Traban
{
    public partial class Form1 : Form
    {
        int prix_base = 12300;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TxtB_prix_base_TextChanged(object sender, EventArgs e)
        {
            TxtB_prix_base.Text = "12300";
            TxtB_prix_base = prix_base;
            
        }
    }
}
