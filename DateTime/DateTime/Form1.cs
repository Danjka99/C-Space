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

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (zaehler <= 999)
            zeit[zaehler] = System.DateTime.Now.ToString();
            zaehler++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 999; i++)
            {
                MessageBox.Show(zeit[i]);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
//Aufgabe 1: Ausgabe nur soviele Zeiten wie vorhanden
//Aufgabe 2: Zeitmessung und Ausgabe mit Startnummer
