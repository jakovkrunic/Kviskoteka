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
    public partial class DodajABC : Form
    {
        public DodajABC()
        {
            InitializeComponent();
        }

        private void dodaj_btn_Click(object sender, EventArgs e)
        {
            String[] zaDodati = new String[5];
            zaDodati[0] = pitanje_text.Text;
            zaDodati[1] = prvi_text.Text;
            zaDodati[2] = drugi_text.Text;
            zaDodati[3] = treci_text.Text;

            if (prvi_radio.Checked) zaDodati[4] = "a";
            if (drugi_radio.Checked) zaDodati[4] = "b";
            if (treci_radio.Checked) zaDodati[4] = "c";

            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"potrebno/abc.txt", true))
            {
                foreach (string s in zaDodati)
                {
                    file.WriteLine(s);
                }
            }

            MessageBox.Show("Dodano!");

            pitanje_text.Text = "";
            prvi_text.Text = "";
            drugi_text.Text = "";
            treci_text.Text = "";

            prvi_radio.Checked = true;
        }
    }
}
