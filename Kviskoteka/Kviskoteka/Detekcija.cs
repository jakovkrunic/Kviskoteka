using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Kviskoteka
{
    public partial class Detekcija : Form
    {
        string[] detekcija = new FileManager().detekcija();
        private string ime;
        int bodovi1 = -1, bodovi2 = -1, bodoviKorisnik = 0;
        int razina1 = 1, razina2 = 2;
        int trenutniIgrac = 1;
        string pocetnaRecenica;
        int odabirRjesenja = 0;
        int tocanOdogovor = 0;
        List<PitanjaOdgovori> pitanjaOdgovori = new List<PitanjaOdgovori>();

        //List<int> vjerojatnosti = new List<int>();
        //List<int> koji_vjerojatnosti = new List<int>();

        string[] odgovoriOsobeA;
        string[] odgovoriOsobeB;
        string[] odgovoriOsobeC;

        Point tekst1 = new Point(520, 130);
        Point krug1_1 = new Point(600, 235);
        Point krug2_1 = new Point(620, 275);
        Point krug3_1 = new Point(640, 305);

        Point tekst2 = new Point(640, 130);
        Point krug1_2 = new Point(720, 235);
        Point krug2_2 = new Point(740, 275);
        Point krug3_2 = new Point(760, 305);

        Point tekst3 = new Point(760, 130);
        Point krug1_3 = new Point(880, 235);
        Point krug2_3 = new Point(900, 275);
        Point krug3_3 = new Point(920, 305);

        int[] numbers = new int[] { 1, 2, 3 };
        int[] poredakIgraca;

        Random rnd = new Random();
        public Detekcija()
        {
            InitializeComponent();


            poredakIgraca = numbers.OrderBy(x => rnd.Next()).ToArray();

            //OBLIKOVANJE
            this.Width = 1100;
            this.Height = 700;
            this.StartPosition = FormStartPosition.Manual;
            this.Left = 200;
            this.Top = 80;

            trenutniIspitivac.Text = "";
            trenutniIspitivac.Visible = false;
            trenutniIspitivac.Location = new Point(50, 250);
            kojuOsobuPita.Text = "";
            kojuOsobuPita.Location = new Point(280, 250);
            kojuOsobuPita.Visible = false;
            odgovorOsobe.Text = "";
            odgovorOsobe.Location = new Point(500, 250);
            odgovorOsobe.Visible = false;
            odgovorOsobe.AutoSize = false;
            odgovorOsobe.Width = 500;
            odgovorOsobe.Height = 80;

            glasajPrije.Visible = false;
            glasajPrije.Location = new Point(760, 100);
            glasajPrije.Width = 260;
            glasajPrije.Height = 30;

            preskoci.Visible = false;
            preskoci.Location = new Point(760, 50);
            preskoci.Width = 260;
            preskoci.Height = 30;

            //OBLAK S TEKSTOM
            label2.Width = 305;
            label2.Height = 105;
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, label2.Width, label2.Height);
            label2.Region = new Region(gp);
            label2.Invalidate();
            label2.Location = tekst1;
            label2.Visible = false;

            //TRI KRUZICA!!!!
            label3.Width = 40;
            label3.Height = 40;
            GraphicsPath gpp = new GraphicsPath();
            gpp.AddEllipse(0, 0, label3.Width, label3.Height);
            label3.Region = new Region(gpp);
            label3.Invalidate();
            label3.Text = "";
            label3.Location = krug1_1;
            label3.Visible = false;

            label4.Width = 30;
            label4.Height = 30;
            GraphicsPath gppp = new GraphicsPath();
            gppp.AddEllipse(0, 0, label4.Width, label4.Height);
            label4.Region = new Region(gppp);
            label4.Invalidate();
            label4.Text = "";
            label4.Location = krug2_1;
            label4.Visible = false;

            label5.Width = 20;
            label5.Height = 20;
            GraphicsPath gpppp = new GraphicsPath();
            gpppp.AddEllipse(0, 0, label5.Width, label5.Height);
            label5.Region = new Region(gpppp);
            label5.Invalidate();
            label5.Text = "";
            label5.Location = krug3_1;
            label5.Visible = false;

            listBox1.Width = 520;
            listBox1.Height = 300;
            listBox1.Location = new Point(50, this.Bottom - 450);
            progressBar1.Maximum = 60;

            progressBar1.Width = 400;
            progressBar1.Height = 50;
            progressBar1.Location = new Point(620, this.Bottom - 215);

            pictureBox1.Width = 120;
            pictureBox1.Height = 200;
            pictureBox1.Location = new Point(620, this.Bottom - 450);
            pictureBox1.BackColor = Color.Aqua;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = new Bitmap(@"potrebno/musko.png");
            osoba1.Location = new Point(620, this.Bottom - 245);
            osoba1.Enabled = false;
            osoba1.Width = 120;
            osoba1.Height = 25;

            pictureBox2.Width = 120;
            pictureBox2.Height = 200;
            pictureBox2.Location = new Point(760, this.Bottom - 450);
            pictureBox2.BackColor = Color.Aqua;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = new Bitmap(@"potrebno/musko.png");
            osoba2.Location = new Point(760, this.Bottom - 245);
            osoba2.Width = 120;
            osoba2.Enabled = false;
            osoba2.Height = 25;

            pictureBox3.Width = 120;
            pictureBox3.Height = 200;
            pictureBox3.Location = new Point(900, this.Bottom - 450);
            pictureBox3.BackColor = Color.Aqua;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = new Bitmap(@"potrebno/musko.png");
            osoba3.Location = new Point(900, this.Bottom - 245);
            osoba3.Width = 120;
            osoba3.Enabled = false;
            osoba3.Height = 25;

            naslov.Location = new Point(50, 50);
            zapocni.Location = new Point(50, 100);

            label1.Location = new Point(50, 150);

            //Image myimage = new Bitmap(@"oblacic.png");
            //label2.Image = myimage;  

            ime = detekcija[0];
            pocetnaRecenica = detekcija[1];
            label1.Text = "Osoba koju tražite je " + ime + ".";
            label2.Text = pocetnaRecenica;
            for (int i = 0; i < 10; i++)
            {
                string pitanje = detekcija[2 + i * 4];
                string[] odgovori = { detekcija[3 + i * 4], detekcija[4 + i * 4], detekcija[5 + i * 4] };
                PitanjaOdgovori dodaj = new PitanjaOdgovori();
                dodaj.pitanje = pitanje;
                dodaj.odgovori = odgovori;
                pitanjaOdgovori.Add(dodaj);

            }
            foreach (var item in pitanjaOdgovori)
            {
                listBox1.Items.Add(item.pitanje);
            }
            Random rand = new Random();
            Random rand1 = new Random();

            urediOdgovoreIgraca(0, rand, rand1);
            urediOdgovoreIgraca(1, rand, rand1);
            urediOdgovoreIgraca(2, rand, rand1);

            //for (int i = 0; i < 10; i++)
            //    Console.Write(odgovoriOsobeA[i] + " ");
            //Console.WriteLine();
            //for (int i = 0; i < 10; i++)
            //    Console.Write(odgovoriOsobeB[i] + " ");
            //Console.WriteLine();
            //for (int i = 0; i < 10; i++)
            //    Console.Write(odgovoriOsobeC[i] + " ");
            //Console.WriteLine();
            //foreach (var item in vjerojatnosti)
            //{
            //    Console.Write(item.ToString() + " ");
            //}
            //Console.WriteLine();
            //foreach (var item in koji_vjerojatnosti)
            //{
            //    Console.Write(item.ToString() + " ");
            //}
            //Console.WriteLine();

        }

        //poredak igraca - 1,2,3 igrac: 0,1,2 DOLJE IM SE UPISUJE LISTA ODGOVORA, PO REDU
        void urediOdgovoreIgraca(int igrac, Random rand, Random rand1)
        {

            string[] odgovori = new string[10];
            if (poredakIgraca[igrac] == 1)
            {
                tocanOdogovor = igrac + 1;
                for (int i = 0; i < 6; i++)
                    odgovori[i] = pitanjaOdgovori[i].odgovori[0];
                for (int i = 6; i < 10; i++)
                {
                    int vjerojatnost = rand.Next(1, 101);
                    int kojiOdgovor = rand1.Next(1, 3);
                    if (vjerojatnost >= 20)
                        odgovori[i] = pitanjaOdgovori[i].odgovori[0];
                    else
                        odgovori[i] = pitanjaOdgovori[i].odgovori[kojiOdgovor];
                    //vjerojatnosti.Add(vjerojatnost);
                    //koji_vjerojatnosti.Add(kojiOdgovor);
                }
                //vjerojatnosti.Add(1000);
                //koji_vjerojatnosti.Add(1000);
            }
            //ostala 2 odgovaraju svejedno, ali sa smanjenom vjerojatnoscu
            else
            {
                for (int i = 0; i < 6; i++)
                {
                    int vjerojatnost = rand.Next(1, 101);
                    int kojiOdgovor = rand1.Next(1, 3);
                    if (vjerojatnost >= 40)
                        odgovori[i] = pitanjaOdgovori[i].odgovori[0];
                    else
                        odgovori[i] = pitanjaOdgovori[i].odgovori[kojiOdgovor];
                    //  vjerojatnosti.Add(vjerojatnost);
                    //koji_vjerojatnosti.Add(kojiOdgovor);
                }

                for (int i = 6; i < 10; i++)
                {
                    int vjerojatnost = rand.Next(1, 101);
                    int kojiOdgovor = rand1.Next(1, 3);
                    if (vjerojatnost >= 60)
                        odgovori[i] = pitanjaOdgovori[i].odgovori[0];
                    else
                        odgovori[i] = pitanjaOdgovori[i].odgovori[kojiOdgovor];
                    //vjerojatnosti.Add(vjerojatnost);
                    //koji_vjerojatnosti.Add(kojiOdgovor);
                }
                //vjerojatnosti.Add(1000);
                //koji_vjerojatnosti.Add(1000);
            }

            //treba pridruziti osobi tu listu odgovora
            if (igrac == 0) odgovoriOsobeA = odgovori;
            else if (igrac == 1) odgovoriOsobeB = odgovori;
            else if (igrac == 2) odgovoriOsobeC = odgovori;
        }


        //POCETNO PREDSTAVLJDANJE
        int broj_oblaka = 0;
        private void zapocni_Click(object sender, EventArgs e)
        {
            zapocni.Enabled = false;
            zapocni.Visible = false;
            timer1.Interval = 2000;
            timer1.Enabled = true;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (broj_oblaka == 0)
            {

                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                broj_oblaka++;
            }
            else if (broj_oblaka == 1)
                broj_oblaka++;
            else if (broj_oblaka == 2)
            {
                broj_oblaka++;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label2.Location = tekst2;
                label3.Location = krug1_2;
                label4.Location = krug2_2;
                label5.Location = krug3_2;
            }

            else if (broj_oblaka == 3)
                broj_oblaka++;

            else if (broj_oblaka == 4)
            {
                broj_oblaka++;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
            }

            else if (broj_oblaka == 5)
                broj_oblaka++;

            else if (broj_oblaka == 6)
            {
                broj_oblaka++;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label2.Location = tekst3;
                label3.Location = krug1_3;
                label4.Location = krug2_3;
                label5.Location = krug3_3;
            }

            else if (broj_oblaka == 7)
                broj_oblaka++;

            else if (broj_oblaka == 8)
            {
                broj_oblaka++;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
            }

            else if (broj_oblaka == 9)
                broj_oblaka++;
            else if (broj_oblaka == 10)
            {
                broj_oblaka++;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
            }
            else if (broj_oblaka == 11)
                broj_oblaka++;
            else if (broj_oblaka == 12)
            {
                broj_oblaka++;
                timer1.Stop();
                timer1.Tick -= new EventHandler(timer1_Tick);
                simulirajIgraca1();
            }

        }

        //PROGRESS BAR - 60 SEKUNDI
        private void timer1_TickZaProgressBar(object sender, EventArgs e)
        {
            if (progressBar1.Value != 60)
                progressBar1.Value++;
            else
            {
                timer1.Stop();
                timer1.Tick -= new EventHandler(timer1_TickZaProgressBar);

                if (trenutniIgrac == 2)
                { preskoci.Enabled = false; preskoci.Visible = false; }
                if (trenutniIgrac == 3)
                    vrijemeZaGlasanje();
            }

        }

        //PRVI IGRAC
        void simulirajIgraca1()
        {
            trenutniIspitivac.Text = "Trenutno ispituje igrač 1";
            trenutniIspitivac.Visible = true;
            preskoci.Visible = true;
            osoba1.Enabled = true;
            osoba2.Enabled = true;
            osoba3.Enabled = true;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += new EventHandler(timer1_TickZaProgressBar);
            timer1.Start();

            timer2.Interval = 3000;
            timer2.Enabled = true;
            timer2.Start();
            timer2.Tick += new EventHandler(timer2_Tick);
        }

        int broj = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {

            string a = "";
            Random rand = new Random();
            if (broj != 60)
            {

                broj += 3;
                int pitanje = rand.Next(0, 10);
                int osoba = rand.Next(1, 4);

                listBox1.SelectedIndex = pitanje;
                if (osoba == 1) a = "A";
                if (osoba == 2) a = "B";
                if (osoba == 3) a = "C";
                kojuOsobuPita.Visible = true;
                kojuOsobuPita.Text = "Igrač pita OSOBU " + a + ".";

                odrediOdgovor(pitanje, osoba);


            }
            else
            {
                timer2.Stop();
                timer2.Tick -= new EventHandler(timer2_Tick);
                if (trenutniIgrac == 1)
                    odaberiSvojOdgovorOsobe(1, razina1, rand);
                if (trenutniIgrac == 2)
                    odaberiSvojOdgovorOsobe(2, razina2, rand);

                if (trenutniIgrac == 2)
                { preskoci.Enabled = false; preskoci.Visible = false; }

                trenutniIgrac++;

                kojuOsobuPita.Text = "";
                odgovorOsobe.Text = "";


                progressBar1.Value = 0;
                broj = 0;
                if (trenutniIgrac == 2) simulirajIgraca2();
                else korisnikovRed();

            }

        }

        void odaberiSvojOdgovorOsobe(int igrac, int razina, Random rand)
        {
            int vjerojatnost = rand.Next(1, 101);
            int bodovi = 0;
            if (razina == 1)
            {
                if (vjerojatnost > 90) bodovi = 50;
            }
            if (razina == 2)
            {
                if (vjerojatnost > 60) bodovi = 50;
            }
            if (razina == 3)
            {
                if (vjerojatnost > 40) bodovi = 50;
            }
            if (igrac == 1) bodovi1 = bodovi;
            if (igrac == 2) bodovi2 = bodovi;
        }

        void odrediOdgovor(int pitanje, int osoba)
        {
            if (osoba == 1)
                odgovorOsobe.Text = "Odgovor: " + odgovoriOsobeA[pitanje];
            else if (osoba == 2)
                odgovorOsobe.Text = "Odgovor: " + odgovoriOsobeB[pitanje];
            else if (osoba == 3)
                odgovorOsobe.Text = "Odgovor: " + odgovoriOsobeC[pitanje];
            odgovorOsobe.Visible = true;
        }

        void simulirajIgraca2()
        {
            trenutniIspitivac.Text = "Trenutno ispituje igrač 2";
            trenutniIspitivac.Visible = true;
            osoba1.Enabled = true;
            osoba2.Enabled = true;
            osoba3.Enabled = true;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += new EventHandler(timer1_TickZaProgressBar);
            timer1.Start();

            timer2.Interval = 3000;
            timer2.Enabled = true;
            timer2.Start();
            timer2.Tick += new EventHandler(timer2_Tick);
        }

        void korisnikovRed()
        {
            glasajPrije.Visible = true;
            trenutniIspitivac.Text = "Vi ste na redu";
            trenutniIspitivac.Visible = true;
            osoba1.Enabled = true;
            osoba2.Enabled = true;
            osoba3.Enabled = true;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            trenutniIgrac = 3;
            timer1.Tick += new EventHandler(timer1_TickZaProgressBar);
            timer1.Start();
        }

        private void osoba1_Click(object sender, EventArgs e)
        {
            //klik ce nesto znaciti samo ako je korisnik na redu
            if (trenutniIgrac == 3 && odabirRjesenja == 0)
            {
                if (listBox1.SelectedIndex == -1)
                    MessageBox.Show("Morate odabrati pitanje!");
                else
                {
                    kojuOsobuPita.Text = "Pitate OSOBU A";
                    odrediOdgovor(listBox1.SelectedIndex, 1);
                }
            }

            if (trenutniIgrac == 3 && odabirRjesenja == 1)
            {
                string izlaz = "";
                if (tocanOdogovor == 1)
                {
                    bodoviKorisnik = 50;
                    izlaz += "Pogodili ste osobu i osvojili 50 bodova. ";
                }
                else izlaz += "Niste pogodili osobu pa je vaš broj bodova 0. ";

                if (bodovi1 == 50) izlaz += "Igrač 1 je također pogodio osobu i osvojio 50 bodova. ";
                else izlaz += "Igrač 1 nije pogodio osobu pa nije osvojio bodove. ";
                if (bodovi2 == 50) izlaz += "Igrač 2 je također pogodio osobu i osvojio 50 bodova. ";
                else izlaz += "Igrač 2 nije pogodio osobu pa nije osvojio bodove.";

                MessageBox.Show(izlaz);
            }

        }



        private void osoba2_Click(object sender, EventArgs e)
        {
            if (trenutniIgrac == 3 && odabirRjesenja == 0)
            {
                if (listBox1.SelectedIndex == -1)
                    MessageBox.Show("Morate odabrati pitanje!");
                else
                {
                    kojuOsobuPita.Text = "Pitate OSOBU B";
                    odrediOdgovor(listBox1.SelectedIndex, 2);
                }
            }

            if (trenutniIgrac == 3 && odabirRjesenja == 1)
            {
                string izlaz = "";
                if (tocanOdogovor == 2)
                {
                    bodoviKorisnik = 50;
                    izlaz += "Pogodili ste osobu i osvojili 50 bodova. ";
                }
                else izlaz += "Niste pogodili osobu pa je vaš broj bodova 0. ";

                if (bodovi1 == 50) izlaz += "Igrač 1 je također pogodio osobu i osvojio 50 bodova. ";
                else izlaz += "Igrač 1 nije pogodio osobu pa nije osvojio bodove. ";
                if (bodovi2 == 50) izlaz += "Igrač 2 je također pogodio osobu i osvojio 50 bodova. ";
                else izlaz += "Igrač 2 nije pogodio osobu pa nije osvojio bodove.";

                MessageBox.Show(izlaz);
            }
        }

        private void preskoci_Click(object sender, EventArgs e)
        {
            preskoci.Visible = false;
            kojuOsobuPita.Visible = true;
            kojuOsobuPita.Text = "";
            odgovorOsobe.Text = "";
            progressBar1.Value = 0;
            timer1.Stop();
            timer1.Tick -= new EventHandler(timer1_TickZaProgressBar);

            timer2.Stop();
            timer2.Tick -= new EventHandler(timer2_Tick);
            Random rand = new Random();
            if (bodovi1 == -1) odaberiSvojOdgovorOsobe(1, razina1, rand);
            if (bodovi2 == -1) odaberiSvojOdgovorOsobe(2, razina2, rand);

            korisnikovRed();

        }

        private void osoba3_Click(object sender, EventArgs e)
        {
            if (trenutniIgrac == 3 && odabirRjesenja == 0)
            {
                if (listBox1.SelectedIndex == -1)
                    MessageBox.Show("Morate odabrati pitanje!");
                else
                {
                    kojuOsobuPita.Text = "Pitate OSOBU C";
                    odrediOdgovor(listBox1.SelectedIndex, 3);
                }
            }

            if (trenutniIgrac == 3 && odabirRjesenja == 1)
            {
                string izlaz = "";
                if (tocanOdogovor == 3)
                {
                    bodoviKorisnik = 50;
                    izlaz += "Pogodili ste osobu i osvojili 50 bodova. ";
                }
                else izlaz += "Niste pogodili osobu pa je vaš broj bodova 0. ";

                if (bodovi1 == 50) izlaz += "Igrač 1 je također pogodio osobu i osvojio 50 bodova. ";
                else izlaz += "Igrač 1 nije pogodio osobu pa nije osvojio bodove. ";
                if (bodovi2 == 50) izlaz += "Igrač 2 je također pogodio osobu i osvojio 50 bodova. ";
                else izlaz += "Igrač 2 nije pogodio osobu pa nije osvojio bodove. ";

                MessageBox.Show(izlaz);
            }
        }

        private void glasajPrije_Click(object sender, EventArgs e)
        {
            glasajPrije.Visible = false;
            odabirRjesenja = 1;
            timer1.Stop();
            timer1.Tick -= new EventHandler(timer1_TickZaProgressBar);
        }
        void vrijemeZaGlasanje()
        {
            odabirRjesenja = 1;
            listBox1.Enabled = false;
            glasajPrije.Enabled = false;
            kojuOsobuPita.Text = "";
            odgovorOsobe.Text = "Vrijeme je isteklo. Izaberite osobu za koju mislite da je točna.";
        }
    }
}
