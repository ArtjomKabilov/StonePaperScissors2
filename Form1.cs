using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StonePaperScissors
{
    public partial class Form1 : Form
    {
        Button bt, bt2;
        public Form1()
        {
            this.Height = 600;
            this.Width = 400;
            this.Text = "Kivist paber käärid";

            bt = new Button();
            bt.Location = new Point(140, 170);
            bt.Text = "1 mängija";
            bt.Height = 40;
            bt.Width = 100;
            this.Controls.Add(bt);
            bt.MouseClick += Bt_MouseClick;
            bt2 = new Button();
            bt2.Location = new Point(140, 240);
            bt2.Text = "2 mängijat";
            bt2.Height = 40;
            bt2.Width = 100;
            this.Controls.Add(bt2);
            bt2.MouseClick += Bt2_MouseClick;
        }

        private void Bt2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            TwoPlayers tp = new TwoPlayers();
            tp.Show();
        }

        private void Bt_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            OnePlayer op = new OnePlayer();
            op.Show();
        }
    }
}
