using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_first
{
    public partial class Form1 : Form
    {
        double i;
        double c = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = i + c;
            button1.Text = "Hallo Welt zum " + i.ToString() + ".";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i = 0;
            button1.Text = "Hallo Welt zum " + i.ToString() + ".";
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                c = c * 10;
                button3.Text = c.ToString();
            }
            else if (e.Button == MouseButtons.Right)
            {
                c = c / 10;
                button3.Text = c.ToString();
            }
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && button4.Height > 6)
            {
                button4.Width = button4.Width - 10;
                button4.Height = button4.Height - 10;
                button4.Left = button4.Left + 5;
                button4.Top = button4.Top + 5;
            }
            else if (e.Button == MouseButtons.Right && button4.Height < 166)
            {
                button4.Width = button4.Width + 10;
                button4.Height = button4.Height + 10;
                button4.Left = button4.Left - 5;
                button4.Top = button4.Top - 5;
            }
        }
    }
}
