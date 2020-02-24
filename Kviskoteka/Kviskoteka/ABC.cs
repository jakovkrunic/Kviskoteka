using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kviskoteka
{
    public partial class ABC : Form
    {
        int broj_bodova = 0;
        int broj_bodova_1 = 0;
        int broj_bodova_2 = 0;

        Timer timer = new Timer();

        int proslo = 0;

        int vjerojatnost1;
        int vjerojatnost2;

        int tocan_odgovor = 10;

        int pitanje = 0;

        String[] igra;

        Random rnd = new Random();
        public ABC()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Left = 200;
            this.Top = 80;

            progressBar1.Maximum = 4;
            progressBar1.Value = 0;

            igra = new FileManager().abcPitalica();

            switch (DetaljiIgre.TezinaPrvog(0))
            {
                case 1: vjerojatnost1 = 40; break;
                case 2: vjerojatnost1 = 70; break;
                case 3: vjerojatnost1 = 90; break;
            }

            switch (DetaljiIgre.TezinaDrugog(0))
            {
                case 1: vjerojatnost2 = 40; break;
                case 2: vjerojatnost2 = 70; break;
                case 3: vjerojatnost2 = 90; break;
            }

            update_progress = new EventHandler(timer_update);
            kraj_pitanja = new EventHandler(krajPitanja);

            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += update_progress;

            label_pitanje.Text = igra[5 * pitanje];
            a_radio.Text = igra[5 * pitanje + 1];
            b_radio.Text = igra[5 * pitanje + 2];
            c_radio.Text = igra[5 * pitanje + 3];

            foreach (string s in igra) Console.WriteLine(s);

            timer.Start();
        }

        EventHandler update_progress;
        EventHandler kraj_pitanja;

        void timer_update(object sender, EventArgs e)
        {
            ++proslo;
            progressBar1.Value += 1;
            if (proslo == 4)
            {
                timer.Tick -= update_progress;
                timer.Tick += kraj_pitanja;
            }
        }

        void krajPitanja(object sender, EventArgs e)
        {
            proslo = 0;
            bool tocno = false;
            timer.Stop();

            if (igra[5 * pitanje + 4] == "a" && a_radio.Checked) { broj_bodova += tocan_odgovor; tocno = true; }
            if (igra[5 * pitanje + 4] == "b" && b_radio.Checked) { broj_bodova += tocan_odgovor; tocno = true; }
            if (igra[5 * pitanje + 4] == "c" && c_radio.Checked) { broj_bodova += tocan_odgovor; tocno = true; }

            int prvi_pogodio = rnd.Next(100);
            if (prvi_pogodio < vjerojatnost1)
            { 
                odgovor1_label.Text = igra[5 * pitanje + 4]; broj_bodova_1 += tocan_odgovor; 
            }
            else
            {
                int krivo = rnd.Next(100);
                if (krivo < 50)
                {
                    if (igra[5 * pitanje + 4] == "a") odgovor1_label.Text = "b";
                    else odgovor1_label.Text = "a";
                }
                else
                {
                    if (igra[5 * pitanje + 4] == "c") odgovor1_label.Text = "b";
                    else odgovor1_label.Text = "c";
                }
            }

            int drugi_pogodio = rnd.Next(100);
            if (drugi_pogodio < vjerojatnost2)
            {
                odgovor2_label.Text = igra[5 * pitanje + 4]; broj_bodova_2 += tocan_odgovor;
            }
            else
            {
                int krivo = rnd.Next(100);
                if (krivo < 50)
                {
                    if (igra[5 * pitanje + 4] == "a") odgovor2_label.Text = "b";
                    else odgovor2_label.Text = "a";
                }
                else
                {
                    if (igra[5 * pitanje + 4] == "c") odgovor2_label.Text = "b";
                    else odgovor2_label.Text = "c";
                }
            }

            if (tocno) MessageBox.Show("Točan odgovor!");
            else MessageBox.Show("Nažalost, Vaš odgovor je netočan.");

            odgovor1_label.Text = "";
            odgovor2_label.Text = "";

            bodovi_label.Text = broj_bodova.ToString();
            bodovi1_label.Text = broj_bodova_1.ToString();
            bodovi2_label.Text = broj_bodova_2.ToString();

            if (pitanje == 9)
            {
                timer.Stop();
                DetaljiIgre.DodajBodove(this, broj_bodova, broj_bodova_1, broj_bodova_2);
                return;
            }

            ++pitanje;

            label_pitanje.Text = igra[5 * pitanje];
            a_radio.Text = igra[5 * pitanje + 1];
            b_radio.Text = igra[5 * pitanje + 2];
            c_radio.Text = igra[5 * pitanje + 3];

            progressBar1.Value = 0;

            timer.Tick -= kraj_pitanja;
            timer.Tick += timer_update;
            timer.Start();
            
        }

        private void ABC_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
            DetaljiIgre.pocetna.Show();
            DetaljiIgre.reset(DetaljiIgre.pocetna);
        }
    }
}
