using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4_Bleu_Rouge
{
    public partial class Form_fenetre : Form
    {
        public Form_fenetre()
        {
            InitializeComponent();
        }

        private void Bleu_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void cmd_HG_Click(object sender, EventArgs e)
        {
            this.Location = new Point(-6, 0);
        }

        private void rouge_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void cmd_HD_Click(object sender, EventArgs e)
        {
            this.Location = new Point(1338, 0);
        }
        private void cmd_BD_Click(object sender, EventArgs e) // marche pas
        {
            this.Location = new Point(1338, 601);
        }
    }
}