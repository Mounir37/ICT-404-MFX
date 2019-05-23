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
        const int dist = 12 ;
        const int larg_cmd = 111;
        const int haut_cmd = 39;
        int Max_Y = scr.Width - 16; //a finir 
        int Max_X = scr.Width - 40;
        Rectangle scr;
        int X;
        int Y;
        int X_cmd;
        int Y_cmd;
        public Form_fenetre()
        {
            InitializeComponent();
        }

        private void Bleu_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void Rouge_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void Form_fenetre_Load(object sender, EventArgs e)
        {
            scr = Screen.GetBounds(this);
            X = scr.Width - this.Width;
            Y = scr.Height - this.Height;
        }

        private void cmd_HG_Click(object sender, EventArgs e)
        {
            this.Location = new Point(-6, 0);
        }

        private void cmd_HD_Click(object sender, EventArgs e)
        {
            this.Location = new Point(X + 6, 0);
        }

        private void cmd_BG_Click(object sender, EventArgs e)
        {
            this.Location = new Point(-6, Y + 6);
        }

        private void cmd_BD_Click(object sender, EventArgs e)
        {
            this.Location = new Point(X + 6, Y + 6);
        }

        private void Form_fenetre_Resize(object sender, EventArgs e)
        {
            X = scr.Width - this.Width;
            Y = scr.Height - this.Height;
            X_cmd = scr.Width - larg_cmd - dist;
            Y_cmd = scr.Height - larg_cmd - dist;

            cmd_HG.Location = new Point(dist,dist);
            cmd_BG.Location = new Point(dist,Y_cmd);
            cmd_HD.Location = new Point(X_cmd, dist);
            cmd_BD.Location = new Point(X_cmd, Y_cmd);

        }
    }
}
