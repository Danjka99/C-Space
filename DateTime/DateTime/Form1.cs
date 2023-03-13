using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        int korrektur;

        int zeilennummer;

        string[] zeit = new string[1000];

        List<string> nummer1 = new List<string>();

        Stopwatch stoppuhr = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newLine = Environment.NewLine;
            if (!textBox1.Text.Equals("") && !nummer1.Contains(textBox1.Text))
            {
                TimeSpan ts = stoppuhr.Elapsed;
                string zeitablauf = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);

                nummer1.Add(textBox1.Text);
                zeit[zaehler] = zeitablauf;
                textBox2.Text += newLine + (zaehler + 1).ToString() + " Startnummer: " + nummer1[zaehler] + " | " + zeit[zaehler];
                zaehler++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] zeile = textBox2.Lines;
            if (!string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text))
            {
                korrektur = int.Parse(textBox4.Text);
                zeilennummer = (int.Parse(textBox3.Text) - 1);
                if (!nummer1.Contains(korrektur.ToString()) && !(zeilennummer >= nummer1.Count))
                {
                    nummer1.RemoveAt(zeilennummer);
                    nummer1.Insert(zeilennummer, korrektur.ToString());
                    zeile[zeilennummer + 1] = (zeilennummer + 1).ToString() + " Startnummer: " + nummer1[zeilennummer] + " | " + zeit[zeilennummer];
                    textBox2.Lines = zeile;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stoppuhr.Start();
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = false;
        }
    }
}
