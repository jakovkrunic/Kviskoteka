using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kviskoteka
{
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {

        }

        private void dodaj_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (login.ShowDialog() == DialogResult.OK) { 
                if (login.user_text.Text == "admin" && login.pass_text.Text == "admin")
                {
                    new Dodavanje().Show();
                }
                else
                {
                    MessageBox.Show("Krivi user i/ili pass!");
                }
            }

            login.Dispose();
        }

        private void provjeri_btn_Click(object sender, EventArgs e)
        {
            String[] asocijacija = new FileManager().asocijacija();
            foreach (string s in asocijacija)
            {
                Console.WriteLine(s);
            }
        }
    }
}
