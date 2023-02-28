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
        int i;
        int c = 1;

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

        private void button3_Click(object sender, EventArgs e)
        {
            c = c * 10;
            button3.Text = c.ToString();
            button4.Text = c.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (c > 1)
            {
                c = c / 10;
                button4.Text = c.ToString();
                button3.Text = c.ToString();
            }
            else
            {
                button4.Text = c.ToString();
                button3.Text = c.ToString();
            }
        }
    }
}
