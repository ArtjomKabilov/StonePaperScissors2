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
    public partial class TwoPlayers : Form
    {
        //PictureBox pb;
        PictureBox pbt, pbt2;
        Button bt;
        Button bt2;
        Button bt3;
        public int numb;
        public int num;
        public TwoPlayers()
        {
            this.Height = 700;
            this.Width = 1000;
            this.Text = "Kivist paber käärid";


            pbt = new PictureBox();
            pbt2 = new PictureBox();
            pbt.Location = new Point(500, 100);
            pbt.ImageLocation = "../../images/Hõiva.png";
            pbt.SizeMode = PictureBoxSizeMode.AutoSize;
            pbt2.Location = new Point(250, 100);
            pbt2.ImageLocation = "../../images/Hõiva.png";
            pbt2.SizeMode = PictureBoxSizeMode.AutoSize;



            this.Controls.Add(pbt);

            bt = new Button();
            bt.Location = new Point(500, 300);
            bt.Size = new Size(100, 50);
            bt.Text = "Alusta";
            this.Controls.Add(bt);
            bt.MouseClick += Bt_MouseClick;
            bt3 = new Button();
            bt3.Location = new Point(500, 300);
            bt3.Size = new Size(100, 50);
            bt3.Text = "Esimene mängija liigub";
            this.Controls.Add(bt3);
            bt3.MouseClick += Bt3_MouseClick;

            bt2 = new Button();
            bt2.Location = new Point(300, 300);
            bt2.Size = new Size(100, 50);
            this.Controls.Add(bt2);
            bt2.MouseClick += Bt2_MouseClick;
            bt2.Text = "teine mängija liigub";

            

            


        }

        private void Bt3_MouseClick(object sender, MouseEventArgs e)
        {
            List<string> list = new List<string>();

            list.Add("kamen.png");
            list.Add("noznitsi.png");
            list.Add("bumaga.png");


            Random rnd = new Random();

            num = rnd.Next(3);
            pbt.ImageLocation = ($"../../images/{list[numb]}");
            bt3.Hide();
        }

        public void Bt2_MouseClick(object sender, MouseEventArgs e)
        {
            pbt.SizeMode = PictureBoxSizeMode.AutoSize;
            List<string> lists = new List<string>();

            lists.Add("kamen.png");
            lists.Add("noznitsi.png");
            lists.Add("bumaga.png");




            Random rand = new Random();

            numb = rand.Next(3);
            pbt.ImageLocation = ($"../../images/{lists[numb]}");
            bt2.Hide();
            /*if (rb1.Checked)
            {
                rb2.Hide();
                rb3.Hide();
            }
            else if (rb2.Checked)
            {
                rb1.Hide();
                rb3.Hide();
            }
            else if (rb3.Checked)
            {
                rb2.Hide();
                rb1.Hide();
            }*/

        }

        public void Bt_MouseClick(object sender, MouseEventArgs e)
        {


            if (num == 1 && numb == 2 || num == 2 && numb == 3 || num == 3 && numb == 1)
            {

                var answer = MessageBox.Show(
                "Ты победил" + numb.ToString(),
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
                if (answer == DialogResult.Yes)
                {
                    TwoPlayers tp = new TwoPlayers();
                    tp.Show();
                    tp.WindowState = FormWindowState.Minimized;
                    tp.WindowState = FormWindowState.Normal;
                    this.Hide();

                }
                else
                {
                    Form1 fp = new Form1();
                    fp.Show();
                    fp.WindowState = FormWindowState.Minimized;
                    fp.WindowState = FormWindowState.Normal;
                    this.Hide();

                }


            }
            else if (num == 1 && numb == 1 || num == 2 && numb == 2 || num == 3 && numb == 3)
            {
                var answer = MessageBox.Show(
                "Ничья" + numb.ToString(),
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
                if (answer == DialogResult.Yes)
                {
                    TwoPlayers tp = new TwoPlayers();
                    tp.Show();
                    tp.WindowState = FormWindowState.Minimized;
                    tp.WindowState = FormWindowState.Normal;
                    this.Hide();

                }
                else
                {
                    Form1 fp = new Form1();
                    fp.Show();
                    fp.WindowState = FormWindowState.Minimized;
                    fp.WindowState = FormWindowState.Normal;
                    this.Hide();

                }

            }
            else
            {
                var answer = MessageBox.Show(
                "Ты проиграл, бот выиграл" + numb.ToString(),
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
                if (answer == DialogResult.Yes)
                {
                    TwoPlayers tp = new TwoPlayers();
                    tp.Show();
                    tp.WindowState = FormWindowState.Minimized;
                    tp.WindowState = FormWindowState.Normal;
                    this.Hide();

                }
                else
                {
                    Form1 fp = new Form1();
                    fp.Show();
                    fp.WindowState = FormWindowState.Minimized;
                    fp.WindowState = FormWindowState.Normal;
                    this.Hide();

                }

            }
        }
    }
}
