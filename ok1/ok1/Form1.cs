using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ok1
{
    public partial class Form1 : Form
    {
        bool flag = true;
        int count = 10;
        public Form1()
        {
            InitializeComponent();
            this.timer1.Interval = 1000;
            this.timer1.Enabled = true;

            this.button1.MouseEnter += Button1_MouseEnter;
            this.MouseMove += Button1_MouseMove;
            this.button1.MouseLeave += Button1_MouseLeave;

            button1.TabStop = false; 
        }

        private void Change_Size()
        {
            if (count > 0) count--;

            else
            {
                count = 10;
                this.button1.Size = new Size(button1.Width - 1, button1.Height - 1);
            }
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.Location = new Point(500, 290);
        }

        private void Button1_MouseMove(object sender, MouseEventArgs e)
        {
            
            int delta = 30;
            int speed = 5;

            int bx = button1.Location.X;
            int by = button1.Location.Y;

            if (e.X > bx - delta & e.Y < by + (button1.Height / 2) & e.X < bx + (button1.Width / 2) & e.Y > by - delta)
            {
                this.button1.Location = new Point(bx + speed, by + speed);
                Change_Size();
            }

            if (e.X > bx + (button1.Width / 2) & e.Y < by + (button1.Height / 2) & e.X < bx + button1.Width + delta & e.Y > by - delta)
            {
                this.button1.Location = new Point(bx - speed, by + speed);
                Change_Size();
            }

            if (e.X > bx + (button1.Width / 2) & e.Y < by + button1.Height + delta & e.X < bx + button1.Width + delta & e.Y > by + (button1.Height / 2))
            {
                this.button1.Location = new Point(bx - speed, by - speed);
                Change_Size();
            }

            if (e.X > bx - delta & e.Y < by + button1.Height + delta & e.X < bx + (button1.Width / 2) & e.Y > by + (button1.Height / 2))
            {
                this.button1.Location = new Point(bx + speed, by - speed);
                Change_Size();
            }

            if (this.button1.Left <= 0)
            {
                this.button1.Location = new Point(bx + this.button1.Width + delta, by);
            }

            if (this.button1.Top <= 0)
            {
                this.button1.Location = new Point(bx , by + this.button1.Width + delta);
            }

            if (this.button1.Right >= this.Width)
            {
                this.button1.Location = new Point(bx - this.button1.Width - delta, by);
            }

            if (this.button1.Bottom >= this.Height)
            {
                this.button1.Location = new Point(bx, by - this.button1.Width - delta);
            }

            if (button1.Height == 0)
            {
                this.timer2.Interval = 1000;
                this.timer2.Enabled = true;
            }
        }


        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            this.button1.Location = new Point(500, 290);
        }

        int i = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                this.Text = "Click 'OK' to continue!";
                flag = false;
            }

            else
            {
                this.Text = "";
                flag = true;
            }

            if(i == 8)
            {
                this.timer1.Stop();
            }

            i++;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                this.Text = "'OK' will newer been pressed!!!";
                flag = false;
            }

            else
            {
                this.Text = "";
                flag = true;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
