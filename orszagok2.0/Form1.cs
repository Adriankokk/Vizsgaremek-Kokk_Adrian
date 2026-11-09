using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace orszagok2._0
{
    public partial class Form1 : Form
    {
        // Az adatokat egy BindingList-ben tároljuk
        private BindingList<Orszag> orszagokLista = new BindingList<Orszag>();

        public Form1()
        {
            InitializeComponent();

            // Táblázat összekötése a listával (az elvárt dgvOrszagok névvel)
            dgvOrszagok.DataSource = orszagokLista;

            // Táblázat oszlopainak formázása
            Alapbeallitasok();
        }

        private void Alapbeallitasok()
        {
            if (dgvOrszagok.Columns.Count > 0)
            {
                dgvOrszagok.Columns["Nev"].HeaderText = "Ország";
                dgvOrszagok.Columns["Fovaros"].HeaderText = "Főváros";
                dgvOrszagok.Columns["Lakossag"].HeaderText = "Lakosság";

                dgvOrszagok.Columns["Lakossag"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvOrszagok.Columns["Lakossag"].DefaultCellStyle.Format = "N0";
            }
        }

        // --- HOZZÁADÁS GOMB ---
        private void btnHozzaadas_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrszag.Text) || string.IsNullOrWhiteSpace(txtFovaros.Text))
            {
                MessageBox.Show("Kérem adja meg az ország nevét és fővárosát!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtLakossag.Text.Replace(" ", ""), out int lakossagInt))
            {
                MessageBox.Show("A lakosság csak szám lehet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Orszag ujOrszag = new Orszag(txtOrszag.Text, txtFovaros.Text, lakossagInt);
            orszagokLista.Add(ujOrszag);

            txtOrszag.Clear();
            txtFovaros.Clear();
            txtLakossag.Clear();
            txtOrszag.Focus();
        }

        // --- KERESÉS GOMB ---
        private void btnKereses_Click(object sender, EventArgs e)
        {
            string kulcsszo = txtKereses.Text.ToLower();

            var szurtLista = orszagokLista.Where(o =>
                o.Nev.ToLower().Contains(kulcsszo) ||
                o.Fovaros.ToLower().Contains(kulcsszo)).ToList();

            dgvOrszagok.DataSource = new BindingList<Orszag>(szurtLista);
        }

        // --- RENDEZÉS GOMB ---
        private void btnRendezes_Click(object sender, EventArgs e)
        {
            var rendezettLista = orszagokLista.OrderByDescending(o => o.Lakossag).ToList();

            orszagokLista = new BindingList<Orszag>(rendezettLista);
            dgvOrszagok.DataSource = orszagokLista;
        }

        // --- BEOLVASÁS GOMB ---
        private void btnBeolvasas_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Szöveges fájlok (*.txt;*.csv)|*.txt;*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                orszagokLista.Clear();
                string[] sorok = File.ReadAllLines(ofd.FileName);

                foreach (string sor in sorok)
                {
                    string[] adatok = sor.Split(';'); // Pontosvesszős elválasztást feltételezve
                    if (adatok.Length >= 3)
                    {
                        orszagokLista.Add(new Orszag(adatok[0], adatok[1], int.Parse(adatok[2])));
                    }
                }

            }
        }

    }

    // --- AZ ORSZÁG ADATMODELL OSZTÁLYA ---
    public class Orszag
    {
        public string Nev { get; set; }
        public string Fovaros { get; set; }
        public int Lakossag { get; set; }

        public Orszag(string nev, string fovaros, int lakossag)
        {
            Nev = nev;
            Fovaros = fovaros;
            Lakossag = lakossag;
        }
    }
}