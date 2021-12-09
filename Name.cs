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
    public partial class Name : Form
    {
        TextBox tb;
        //Button bt;
        Label lb;
        public Name()
        {
            this.Height = 200;
            this.Width = 300;
            this.Text = "Kivist paber käärid";

            lb = new Label();
            tb = new TextBox();
            //bt = new Button();
            tb.Size = new Size(200, 100);
            tb.Location = new Point(50, 60);

            lb.Size = new Size(200, 100);
            lb.Location = new Point(50, 45);
            lb.Text = "Kirjuta sinu nimi";

            /*bt.Size = new Size(100, 50);
            bt.Location = new Point(50, 75);
            bt.Text = "Kliki siia";
            this.Controls.Add(tb);
            this.Controls.Add(lb);
            this.Controls.Add(bt);*/


        }
    }
}
