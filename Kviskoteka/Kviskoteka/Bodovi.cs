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
    public partial class Bodovi : Form
    {
        public Bodovi(bool kvisko)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Left = 150;
            this.Top = 60;

            bodovi_label.Text = DetaljiIgre.BodoviIgraca().ToString();
            bodovi1_label.Text = DetaljiIgre.BodoviPrvog().ToString();
            bodovi2_label.Text = DetaljiIgre.BodoviDrugog().ToString();

            if (!kvisko)
            {
                kvisko_label.Visible = false;
                kvisko_btn.Visible = false;
                kvisko_btn.Enabled = false;
            } 
        }

        private void kvisko_btn_Click(object sender, EventArgs e)
        {
            DetaljiIgre.IskoristiKviskoIgrac();
            kvisko_label.Visible = false;
            kvisko_btn.Visible = false;
            kvisko_btn.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch(DetaljiIgre.Igra())
            {
                case 1: { new Asocijacije().Show(); this.Close();  break; }
                case 2: { new Detekcija().Show(); this.Close(); break; }
                case 3: new Zavrsna().Show(); break;
                case 4: // Promijeni u case 4 i odkomentiraj ono gore!
                    {
                        this.Close();
                        DetaljiIgre.pocetna.Visible = true;
                        DetaljiIgre.reset(DetaljiIgre.pocetna);
                        break;
                    }
            }
        }
    }
}
