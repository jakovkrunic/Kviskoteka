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
    public partial class DodajZavrsnu : Form
    {
        public DodajZavrsnu()
        {
            InitializeComponent();
        }

        private void dodaj_btn_Click(object sender, EventArgs e)
        {
            String[] zaDodati = new String[5];
            zaDodati[0] = pitanje_text.Text;
            zaDodati[1] = pravi_text.Text;
            zaDodati[2] = krivi1_text.Text;
            zaDodati[3] = krivi2_text.Text;
            zaDodati[4] = krivi3_text.Text;

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
            pravi_text.Text = "";
            krivi1_text.Text = "";
            krivi2_text.Text = "";
            krivi3_text.Text = "";
        }
    }
}
