using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace Járművek1
{
    public partial class Form1 : Form
    {
        List<Autók> autok = new List<Autók>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            autok.Clear();

            string[] sorok = File.ReadAllLines("adat.txt");

            foreach (string sor in sorok)
            {
                string[] adatok = sor.Split(',');

                string marka = adatok[0];
                int ev = int.Parse(adatok[1]);

                autok.Add(new Autók(marka, ev));
            }

            listBox1.Items.Clear();

            foreach (Autók auto in autok)
            {
                listBox1.Items.Add(auto);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show("Nincs beolvasott adat!");
                return;
            }

            autok = autok.OrderBy(a => a.Ev).ToList();

            listBox1.Items.Clear();

            foreach (Autók auto in autok)
            {
                listBox1.Items.Add(auto);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (autok.Count == 0)
            {
                MessageBox.Show("Nincs beolvasott adat!");
                return;
            }

            Autók legregebbi = autok.OrderBy(a => a.Ev).First();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (autok.Count == 0)
            {
                MessageBox.Show("Nincs beolvasott adat!");
                return;
            }

            Autók legujabb = autok.OrderByDescending(a => a.Ev).First();

            lbleredmeny.Text =
                "Legújabb: " + legujabb.Marka + " - " + legujabb.Ev;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (autok.Count == 0)
            {
                MessageBox.Show("Nincs beolvasott adat!");
                return;
            }

            if (!int.TryParse(txtev.Text, out int keresettEv))
            {
                MessageBox.Show("Hibás évszám!");
                return;
            }

            listBox1.Items.Clear();

            foreach (Autók auto in autok)
            {
                if (auto.Ev > keresettEv)
                {
                    listBox1.Items.Add(auto);
                }
            }
        }
    }


    public class Autók
    {
        public string Marka { get; set; }
        public int Ev { get; set; }

        public Autók(string marka, int ev)
        {
            Marka = marka;
            Ev = ev;
        }

    }
}