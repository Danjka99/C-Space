using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTime
{
    public partial class Form1 : Form
    {
        int zaehler = 0;

        string[] zeit = new string[1000];

        string [] nummer = new string[1000];

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newLine = Environment.NewLine;
            if (!string.IsNullOrEmpty(nummer[zaehler]))
            {
                zeit[zaehler] = System.DateTime.Now.ToString("hh:mm:ss.ff");
                textBox2.Text += newLine + "Startnummer: " + nummer[zaehler] + " | " + zeit[zaehler];
                zaehler++;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nummer[zaehler] = textBox1.Text;
        }

    }
}
