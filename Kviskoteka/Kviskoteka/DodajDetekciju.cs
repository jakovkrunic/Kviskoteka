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
    public partial class DodajDetekciju : Form
    {
        int ukupno = 0;
        string[] zaDodati = new string[42];
        public DodajDetekciju()
        {
            InitializeComponent();

            this.Width = 1100;
            this.Height = 700;
            this.StartPosition = FormStartPosition.Manual;
            this.Left = 200;
            this.Top = 80;

        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            zaDodati[0] = imePrezime.Text;
            zaDodati[1] = recenica.Text;

            zaDodati[2] = pitanje1.Text;
            zaDodati[3] = odgovor1_1.Text;
            zaDodati[4] = odgovor1_2.Text;
            zaDodati[5] = odgovor1_3.Text;

            zaDodati[6] = pitanje2.Text;
            zaDodati[7] = odgovor2_1.Text;
            zaDodati[8] = odgovor2_2.Text;
            zaDodati[9] = odgovor2_3.Text;

            zaDodati[10] = pitanje3.Text;
            zaDodati[11] = odgovor3_1.Text;
            zaDodati[12] = odgovor3_2.Text;
            zaDodati[13] = odgovor3_3.Text;

            zaDodati[14] = pitanje4.Text;
            zaDodati[15] = odgovor4_1.Text;
            zaDodati[16] = odgovor4_2.Text;
            zaDodati[17] = odgovor4_3.Text;

            zaDodati[18] = pitanje5.Text;
            zaDodati[19] = odgovor5_1.Text;
            zaDodati[20] = odgovor5_2.Text;
            zaDodati[21] = odgovor5_3.Text;

            zaDodati[22] = pitanje6.Text;
            zaDodati[23] = odgovor6_1.Text;
            zaDodati[24] = odgovor6_2.Text;
            zaDodati[25] = odgovor6_3.Text;

            zaDodati[26] = pitanje7.Text;
            zaDodati[27] = odgovor7_1.Text;
            zaDodati[28] = odgovor7_2.Text;
            zaDodati[29] = odgovor7_3.Text;

            zaDodati[30] = pitanje8.Text;
            zaDodati[31] = odgovor8_1.Text;
            zaDodati[32] = odgovor8_2.Text;
            zaDodati[33] = odgovor8_3.Text;

            zaDodati[34] = pitanje9.Text;
            zaDodati[35] = odgovor9_1.Text;
            zaDodati[36] = odgovor9_2.Text;
            zaDodati[37] = odgovor9_3.Text;

            zaDodati[38] = pitanje10.Text;
            zaDodati[39] = odgovor10_1.Text;
            zaDodati[40] = odgovor10_2.Text;
            zaDodati[41] = odgovor10_3.Text;

            foreach (string element in zaDodati)
            {
                if (element != "" && element != null)
                    ukupno++;
            }

            if(ukupno != 42)
            {
                MessageBox.Show("Nešto niste unijeli, pokušajte ponovo!");
                ukupno = 0;
            }
            else
            {
                ukupno = 0;
                using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"potrebno\detekcije.txt", true))
                {
                    foreach (string s in zaDodati)
                    {
                        file.WriteLine(s);
                    }
                }

                MessageBox.Show("Dodano!");
                imePrezime.Text = "";
                recenica.Text = "";
                pitanje1.Text = ""; odgovor1_1.Text = ""; odgovor1_2.Text = ""; odgovor1_3.Text = "";
                pitanje2.Text = ""; odgovor2_1.Text = ""; odgovor2_2.Text = ""; odgovor2_3.Text = "";
                pitanje3.Text = ""; odgovor3_1.Text = ""; odgovor3_2.Text = ""; odgovor3_3.Text = "";
                pitanje4.Text = ""; odgovor4_1.Text = ""; odgovor4_2.Text = ""; odgovor4_3.Text = "";
                pitanje5.Text = ""; odgovor5_1.Text = ""; odgovor5_2.Text = ""; odgovor5_3.Text = "";
                pitanje6.Text = ""; odgovor6_1.Text = ""; odgovor6_2.Text = ""; odgovor6_3.Text = "";
                pitanje7.Text = ""; odgovor7_1.Text = ""; odgovor7_2.Text = ""; odgovor7_3.Text = "";
                pitanje8.Text = ""; odgovor8_1.Text = ""; odgovor8_2.Text = ""; odgovor8_3.Text = "";
                pitanje9.Text = ""; odgovor9_1.Text = ""; odgovor9_2.Text = ""; odgovor9_3.Text = "";
                pitanje10.Text = ""; odgovor10_1.Text = ""; odgovor10_2.Text = ""; odgovor10_3.Text = "";
            }
        }
    }
}
