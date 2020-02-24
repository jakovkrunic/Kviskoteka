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
        private bool ulogiran = false;
        public Pocetna()
        {
            InitializeComponent();
            DetaljiIgre.reset(this);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = new Bitmap(@"potrebno/morzek.png");
            this.StartPosition = FormStartPosition.Manual;
            this.Left = 200;
            this.Top = 80;
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {

        }

        private bool logiraj()
        {
            bool proslo = false;
            Login login = new Login();
            if (login.ShowDialog() == DialogResult.OK)
            {
                if (login.user_text.Text == "admin" && login.pass_text.Text == "admin")
                {
                    proslo = true;
                }
                else
                {
                    MessageBox.Show("Krivi username i/ili password!");
                }
            }

            login.Dispose();

            return proslo;
        }

        private void dodaj_btn_Click(object sender, EventArgs e)
        {
            bool proslo = false;
            if (ulogiran == false) { proslo = logiraj(); }
            if (!proslo && !ulogiran)
            {
                return;
            }

            ulogiran = true;
            Dodavanje dodavanje = new Dodavanje();

            if (dodavanje.ShowDialog() == DialogResult.OK)
            {
                if (dodavanje.abc_radio.Checked) new DodajABC().Show();
                if (dodavanje.as_radio.Checked) new DodajAsocijaciju().Show();
                if (dodavanje.det_radio.Checked) new DodajDetekciju().Show();
                if (dodavanje.zav_radio.Checked) new DodajZavrsnu().Show();
            }

            dodavanje.Dispose();
        }

        private void postavke_btn_Click(object sender, EventArgs e)
        {
            SettingsForm dialog_setting = new SettingsForm();
            if (dialog_setting.ShowDialog() == DialogResult.OK)
            {
                int prvi_abc = dialog_setting.prvi_abc.Value;
                int prvi_as = dialog_setting.prvi_as.Value;
                int prvi_det = dialog_setting.prvi_det.Value;
                int prvi_zav = dialog_setting.prvi_zav.Value;

                DetaljiIgre.tezinaPrvog(prvi_abc, 0);
                DetaljiIgre.tezinaPrvog(prvi_as, 1);
                DetaljiIgre.tezinaPrvog(prvi_det, 2);
                DetaljiIgre.tezinaPrvog(prvi_zav, 3);

                int drugi_abc = dialog_setting.drugi_abc.Value;
                int drugi_as = dialog_setting.drugi_as.Value;
                int drugi_det = dialog_setting.drugi_det.Value;
                int drugi_zav = dialog_setting.drugi_zav.Value;

                DetaljiIgre.tezinaDrugog(drugi_abc, 0);
                DetaljiIgre.tezinaDrugog(drugi_as, 1);
                DetaljiIgre.tezinaDrugog(drugi_det, 2);
                DetaljiIgre.tezinaDrugog(drugi_zav, 3);
            }
            dialog_setting.Dispose();
        }

        private void kreni_btn_Click(object sender, EventArgs e)
        {
            new ABC().Show();
            //new Zavrsna().Show();
            this.Hide();
        }
    }
}
