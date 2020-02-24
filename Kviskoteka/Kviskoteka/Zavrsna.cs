using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Kviskoteka
{
    public partial class Zavrsna : Form
    {
        public Label kaj_se_dogada;
        public Button taster, next_q;
        public TextBox unesi_odg;
        public Label ind_tast1, ind_tast2, ind_tast3;
        public System.Windows.Forms.Timer timer1;
        /*
        String[] pitanja = { "Pitanje A", "Pitanje B", "Pitanje C" };
        String[] tocni_odg = { "Odgovor A", "Odgovor B", "Odgovor C" };
        String[] krivi_odg = { "Glupost A1", "Glupost A2", "Glupost A3", "Blabla" };
        */
        List<String> pitanja;
        List<String> tocni_odg;
        List<String> krivi_odg;
        int curr_q;
        double timer_counter;
        Random random;
        int pozovi_taster2, pozovi_taster3;
        List<int> list = new List<int>();
        int[] red = new int[3];
        int na_redu;
        int bodovi, bodovi_2, bodovi_3;

        double tocnost_drugog = 0.8;
        double tocnost_treceg = 0.5;
        public Zavrsna()
        {
            
            //KAD SE SPOJIS NA MASTER
            tocnost_drugog = DetaljiIgre.TezinaPrvog(3)*0.25;
            tocnost_treceg = DetaljiIgre.TezinaDrugog(3)*0.25;
            String[] zavrsna = new FileManager().zavrsna();
            pitanja = new List<string>();
            tocni_odg = new List<string>();
            krivi_odg = new List<string>();

            for (int i = 0; i < zavrsna.Length; ++i)
            {
                pitanja.Add(zavrsna[i]);
                tocni_odg.Add(zavrsna[++i]);
                krivi_odg.Add(zavrsna[++i]);
                krivi_odg.Add(zavrsna[++i]);
                krivi_odg.Add(zavrsna[++i]);
            }

            bodovi = 0;
            bodovi_2 = 0;
            bodovi_3 = 0;

            na_redu = 0;
            random = new Random();
            curr_q = 0;
            this.Width = 1200;
            this.Height = 800;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            kaj_se_dogada = new Label();
            kaj_se_dogada.Size = new Size(800, 100);
            kaj_se_dogada.Anchor = AnchorStyles.Top;
            kaj_se_dogada.Location = new Point((ClientRectangle.Width - kaj_se_dogada.Width) / 2, 0);
            kaj_se_dogada.Text = "ZAVRŠNA IGRA";
            kaj_se_dogada.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(kaj_se_dogada);

            taster = new Button();
            taster.Text = "Prijavi se!";
            taster.TextAlign = ContentAlignment.MiddleCenter;
            taster.Location = new Point((ClientRectangle.Width - taster.Width) / 2, (ClientRectangle.Height - 200));
            taster.Enabled = false;
            taster.Click += prijavi_se;
            this.Controls.Add(taster);

            ind_tast1 = new Label();
            ind_tast1.BackColor = Color.IndianRed;
            ind_tast1.TextAlign = ContentAlignment.MiddleCenter;
            ind_tast1.Size = new Size(200, 50);
            ind_tast1.Location = new Point(taster.Location.X - 50, taster.Location.Y - 100);
            this.Controls.Add(ind_tast1);

            ind_tast2 = new Label();
            ind_tast2.TextAlign = ContentAlignment.MiddleCenter;
            ind_tast2.BackColor = Color.IndianRed;
            ind_tast2.Size = new Size(200, 50);
            ind_tast2.Location = new Point(300, 250);
            this.Controls.Add(ind_tast2);

            ind_tast3 = new Label();
            ind_tast3.BackColor = Color.IndianRed;
            ind_tast3.TextAlign = ContentAlignment.MiddleCenter;
            ind_tast3.Size = new Size(200, 50);
            ind_tast3.Location = new Point(700, 250);
            this.Controls.Add(ind_tast3);

            unesi_odg = new TextBox();
            unesi_odg.Size = new Size(200, 100);
            unesi_odg.Location = new Point((ClientRectangle.Width - unesi_odg.Width) / 2, (ClientRectangle.Height - unesi_odg.Height - 100));
            unesi_odg.Anchor = AnchorStyles.Bottom;
            unesi_odg.Enabled = false;
            unesi_odg.KeyDown += odg_key_down;
            this.Controls.Add(unesi_odg);

            next_q = new Button();
            next_q.Text = "Sljedeće pitanje";
            next_q.Size = new Size(80, 80);
            next_q.TextAlign = ContentAlignment.MiddleCenter;
            next_q.Location = new Point((ClientRectangle.Width - next_q.Width) / 2, (ClientRectangle.Height - 500));
            next_q.Click += postavi_pitanje;
            this.Controls.Add(next_q);

            this.timer1 = new System.Windows.Forms.Timer();
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            timer1.Interval = 500;

            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Left = 200;
            this.Top = 80;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.FormClosing += new FormClosingEventHandler(Zavrsna_FormClosing);
        }

        private void Zavrsna_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            DetaljiIgre.pocetna.Show();
            DetaljiIgre.reset(DetaljiIgre.pocetna);
        }

        void postavi_pitanje(Object sender, EventArgs e)
        {
            for (int i = 0; i < 3; ++i)
            {
                kaj_se_dogada.Text = "Sljedeće pitanje za: " + (2 - i).ToString();
                this.Refresh();
                Thread.Sleep(1000);
            }
            kaj_se_dogada.Text = pitanja[curr_q];
            next_q.Enabled = false;
            taster.Enabled = true;
            pozovi_taster2 = random.Next(30);
            pozovi_taster3 = random.Next(30);
            ind_tast1.BackColor = Color.IndianRed;
            ind_tast2.BackColor = Color.IndianRed;
            ind_tast3.BackColor = Color.IndianRed;
            ind_tast1.Text = "";
            ind_tast2.Text = "";
            ind_tast3.Text = "";
            na_redu = 0;
            list.Clear();

            timer_counter = 30;
            timer1.Enabled = true;
            timer1.Start();

        }

        private void prijavi_se(Object sender, EventArgs e)
        {
            list.Add(1);
            ind_tast1.Text = (list.IndexOf(1) + 1).ToString();
            taster.Enabled = false;
            ind_tast1.BackColor = Color.ForestGreen;

        }

        private void odg_key_down(Object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                if (unesi_odg.Text == tocni_odg[curr_q])
                {
                    kaj_se_dogada.Text = "Igrač pogađa: " + tocni_odg[curr_q] + "\n Točno!";
                    bodovi += 10;
                    this.Refresh();
                    Thread.Sleep(1000);
                    kraj_pitanja();
                }
                else
                {
                    kaj_se_dogada.Text = "Igrač pogađa: " + unesi_odg.Text + "\n Netočno!";
                    bodovi -= 5;
                }
                unesi_odg.Enabled = false;
                ++na_redu;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //kaj_se_dogada.Text = timer_counter.ToString();
            // ^^ to na poseban lejbl
            timer_counter -= 0.5;
            if ((na_redu + 1).ToString() == ind_tast1.Text)
            {
                unesi_odg.Enabled = true;
            }
            if ((na_redu + 1).ToString() == ind_tast2.Text)
            {
                //drugi odgovara
                //updateaj bodove;
                if (random.Next(100) < tocnost_drugog * 100)
                {
                    kaj_se_dogada.Text = "Drugi pogađa: " + tocni_odg[curr_q] + "\n Točno!";
                    bodovi_2 += 10;
                    this.Refresh();
                    Thread.Sleep(1000);
                    kraj_pitanja();
                }
                else
                {
                    kaj_se_dogada.Text = "Drugi pogađa: " + krivi_odg[3*curr_q+random.Next(3)] + "\n Netočno!";
                    bodovi_2 -= 5;
                }

                ++na_redu;
            }
            if ((na_redu + 1).ToString() == ind_tast3.Text)
            {
                //treci odgovara
                //updateaj bodove;
                if (random.Next(100) < tocnost_treceg * 100)
                {
                    kaj_se_dogada.Text = "Treći pogađa: " + tocni_odg[curr_q] + "\n Točno!";
                    bodovi_3 += 10;
                    this.Refresh();
                    Thread.Sleep(1000);
                    kraj_pitanja();
                }
                else
                {
                    kaj_se_dogada.Text = "Treći pogađa: " + krivi_odg[3 * curr_q + random.Next(3)] + "\n Netočno!";
                    bodovi_3 -= 5;
                }
                ++na_redu;
            }
            if (timer_counter < pozovi_taster2 && ind_tast2.BackColor != Color.ForestGreen)
            {
                ind_tast2.BackColor = Color.ForestGreen;
                list.Add(2);
                ind_tast2.Text = (list.IndexOf(2) + 1).ToString();
            }
            else if (timer_counter < pozovi_taster3 && ind_tast3.BackColor != Color.ForestGreen)
            {
                ind_tast3.BackColor = Color.ForestGreen;
                ind_tast3.Text = 1.ToString();
                list.Add(3);
                ind_tast3.Text = (list.IndexOf(3) + 1).ToString();
            }
            else if (timer_counter < 0 || na_redu == 4)
            {
                kraj_pitanja();
            }
        }

        void kraj_pitanja()
        {
            timer1.Stop();
            // poslozi batone, curr_q. tak nekaj
            ++curr_q;
            kaj_se_dogada.Text = "Gotovo pitanje, još " + (pitanja.Count() - curr_q).ToString() + " pitanja!";
            taster.Enabled = false;
            unesi_odg.Enabled = false;
            if (curr_q >= pitanja.Count())
            {
                kaj_se_dogada.Text = "IGRA JE GOTOVA MARŠ DOMA!";
                next_q.Enabled = false;
                DetaljiIgre.DodajBodove(this, bodovi, bodovi_2, bodovi_3);
            }
            else
            {
                next_q.Enabled = true;
            }
        }
    }
}
