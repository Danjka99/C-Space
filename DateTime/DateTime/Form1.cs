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
            //if (zaehler <= 999)
            zeit[zaehler] = System.DateTime.Now.TimeOfDay.ToString();
            textBox2.Text += newLine + "Startnummer: " + nummer[zaehler] + " | " + zeit[zaehler];
            zaehler++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           //for (int i = 0; i <= 999; i++)
            {
                //if (!string.IsNullOrEmpty(zeit[i]))
                     //textBox2.Text += newLine + "Startnummer: " + nummer[i] + " | " + zeit[i];
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nummer[zaehler] = textBox1.Text;
        }

    }
}
//Aufgabe 1: Ausgabe nur soviele Zeiten wie vorhanden
//Aufgabe 2: Zeitmessung und Ausgabe mit Startnummer
