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
    public partial class Asocijacije : Form
    {
        private string[] celije = new string[16];
        String[] asocijacija = new FileManager().asocijacija();
        int bodovi1 = 0;
        int bodovi2 = 0;
        int bodovi3 = 0;
        public Asocijacije()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Left = 200;
            this.Top = 80;
            for (var i = 0; i < 16; i++)
            {
                if (i < 4)
                    celije[i] = asocijacija[i];
                else if (i >= 4 && i < 8)
                    celije[i] = asocijacija[i+1];
                else if (i >= 8 && i < 12)
                    celije[i] = asocijacija[i+2];
                else
                    celije[i] = asocijacija[i+3];
            }
        }

        private void label_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null && clickedLabel != Red)
            {

                clickedLabel.BackColor = Color.Aquamarine;
                for (var i = 1; i <= 16; i++)
                {
                    if (clickedLabel.Name == "label" + i)
                    {
                        clickedLabel.Font = new Font(clickedLabel.Font.FontFamily, 10);
                        clickedLabel.Text = celije[i-1];
                    }
                }

                foreach (Control c in Controls)
                {
                    if (c is Label && c != Red)
                    {
                        var label = (Label)c;
                        label.Click -= label_Click;
                    }
                }
            }
        }

        private void CheckKeys(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (e.KeyChar == (char)13)
            {
                for (var i = 1; i <= 4; i++)
                {
                    if (tb.Name == "textBox" + i)
                    {
                        if (tb.Text == asocijacija[5*i-1])
                        {
                            MessageBox.Show("Tocno!");
                            tb.Font = new Font(tb.Font, FontStyle.Bold);
                            tb.BackColor = Color.Aquamarine;
                            tb.ReadOnly = true;
                            foreach (Control c in Controls)
                            {
                                if (c is Label && c != Red)
                                {
                                    var label = (Label)c;
                                    string index;
                                    if (label.Name.Length == 6)
                                        index = label.Name.Substring(5, 1);
                                    else
                                        index = label.Name.Substring(5, 2);

                                    if (Convert.ToInt32(index) > (i-1)*4 && Convert.ToInt32(index) <= i * 4)
                                    {                        
                                        label.BackColor = Color.Aquamarine;
                                        label.Font = new Font(label.Font.FontFamily, 10);
                                        label.Text = celije[Convert.ToInt32(index) - 1];
                                    }
                                }
                            }
                            foreach (Control c in Controls)
                            {
                                if (c is Label && c != Red)
                                {
                                    var label = (Label)c;
                                    if(label.BackColor != Color.Aquamarine)
                                        label.Click += label_Click;
                                }
                            }
                            //dodaj igracu 15 bodova
                            bodovi1 += 15;
                        }
                        else
                        {
                            MessageBox.Show("Nije tocno!");
                            tb.Text = "";
                            //simuliraj igru protivnika1
                            potez_protivnik1();
                        }
                    }
                }
                if (tb.Name == "textBox5")
                {
                    if (tb.Text == asocijacija[20])
                    {
                        MessageBox.Show("Bravo, pogodili ste konacno rjesenje!");
                        tb.Font = new Font(tb.Font, FontStyle.Bold);
                        tb.BackColor = Color.Aquamarine;
                        tb.ReadOnly = true;
                        foreach (Control c in Controls)
                        {
                            if (c is Label && c != Red)
                            {
                                var label = (Label)c;
                                label.BackColor = Color.Aquamarine;
                                label.Font = new Font(label.Font.FontFamily, 10);
                                string index;
                                if(label.Name.Length==6)
                                    index = label.Name.Substring(5, 1);
                                else
                                    index = label.Name.Substring(5, 2);
                                label.Text = celije[Convert.ToInt32(index)-1];
                            }
                            else if (c is TextBox)
                            {
                                var textbox = (TextBox)c;
                                for (var j = 1; j <= 4; j++)
                                {
                                    if (textbox.Name == "textBox" + j)
                                    {
                                        textbox.Font = new Font(tb.Font, FontStyle.Bold);
                                        textbox.BackColor = Color.Aquamarine;
                                        textbox.Text = asocijacija[5 * j - 1];
                                        textbox.ReadOnly = true;
                                    }
                                }
                            }
                        }
                        //dodaj igracu 40 bodova
                        bodovi1 += 40;
                        //kraj igre
                        MessageBox.Show("Kraj igre asocijacija!");
                        if (DetaljiIgre.IskoristenKviskoIgrac()) bodovi1 *= 2;
                        if (DetaljiIgre.IskoristenKviskoPrvi()) bodovi2 *= 2;
                        if (DetaljiIgre.IskoristenKviskoDrugi()) bodovi3 *= 2;
                        DetaljiIgre.DodajBodove(this, bodovi1, bodovi2, bodovi3);
                    }
                    else
                    {
                        MessageBox.Show("Nije tocno!");
                        tb.Text = "";
                        //simuliraj igru protivnika1
                        potez_protivnik1();
                    }
                }
            }
        }

        private async void potez_protivnik1()
        {
            Red.Text = "Protivnik1 je na redu!";
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    var tbx = (TextBox)c;
                    tbx.ReadOnly = true;
                }
            }
            int tezina = DetaljiIgre.TezinaPrvog(1);
            await Task.Delay(1500);
            if (neotvorena_polja().Count > 0)
            {

                otvori_random_polje();
                int i = stupac_s_najvise_otvorenih();
                await Task.Delay(1000);
                pogadaj_rjesenje_stupca(i,tezina,1);
            }
            else if (neotvorena_rjesenja_stupaca().Count > 0)
            {
                int j = stupac_s_najvise_otvorenih();
                pogadaj_rjesenje_stupca(j, tezina, 1);
            }
            else
                pogadaj_konacno_rjesenje(tezina,1);
        }

        private async void potez_protivnik2()
        {
            Red.Text = "Protivnik2 je na redu!";
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    var tbx = (TextBox)c;
                    tbx.ReadOnly = true;
                }
            }
            int tezina = DetaljiIgre.TezinaDrugog(1);
            await Task.Delay(1500);
            if (neotvorena_polja().Count > 0)
            {

                otvori_random_polje();
                int i = stupac_s_najvise_otvorenih();
                await Task.Delay(1000);
                pogadaj_rjesenje_stupca(i,tezina,2);
            }
            else if (neotvorena_rjesenja_stupaca().Count > 0)
            {
                int j = stupac_s_najvise_otvorenih();
                pogadaj_rjesenje_stupca(j, tezina,2);
            }
            else
                pogadaj_konacno_rjesenje(tezina,2);
        }

        private void otvori_random_polje()
        {
            Random rnd = new Random();
            int p = rnd.Next(1, neotvorena_polja().Count+1);
            Label label = neotvorena_polja()[p-1];
            label.BackColor = Color.Aquamarine;
            label.Font = new Font(label.Font.FontFamily, 10);
            label.Click -= label_Click;
            string index;
            if (label.Name.Length == 6)
                index = label.Name.Substring(5, 1);
            else
                index = label.Name.Substring(5, 2);
            label.Text = celije[Convert.ToInt32(index) - 1];
        }

        private void pogadaj_rjesenje_stupca(int j, int t, int protivnik)
        {
            TextBox tb = new TextBox();
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    var textbox = (TextBox)c;
                    if (textbox.Name == "textBox" + Convert.ToString(j))
                    {
                        tb = textbox;
                        break;
                    }
                }
            }
            Random rnd = new Random();
            int p = rnd.Next(1, 4);
            if (p <= t)
            {
                tb.Text = asocijacija[5 * j - 1];
                tb.Font = new Font(tb.Font, FontStyle.Bold);
                tb.BackColor = Color.Aquamarine;
                tb.ReadOnly = true;
                foreach (Control c in Controls)
                {
                    if (c is Label && c != Red)
                    {
                        var label = (Label)c;
                        string index;
                        if (label.Name.Length == 6)
                            index = label.Name.Substring(5, 1);
                        else
                            index = label.Name.Substring(5, 2);

                        if (Convert.ToInt32(index) > (j - 1) * 4 && Convert.ToInt32(index) <= j * 4)
                        {
                            label.BackColor = Color.Aquamarine;
                            label.Font = new Font(label.Font.FontFamily, 10);
                            label.Text = celije[Convert.ToInt32(index) - 1];
                            label.Click -= label_Click;
                        }
                    }
                }
                if (protivnik == 1)
                {
                    bodovi2 += 15;
                    potez_protivnik1();
                }
                else
                {
                    bodovi3 += 15;
                    potez_protivnik2();
                }
            }
            else
            {
                if (protivnik == 1)
                    potez_protivnik2();
                else
                {
                    //igra igrac
                    Red.Text = "Vi ste na redu!";
                    foreach (Control c in Controls)
                    {
                        if (c is Label && c != Red)
                        {
                            var label = (Label)c;
                            if (label.BackColor != Color.Aquamarine)
                                label.Click += label_Click;
                        }
                    }
                    foreach (Control c in Controls)
                    {
                        if (c is TextBox)
                        {
                            var tbx = (TextBox)c;
                            if (tbx.BackColor != Color.Aquamarine)
                                tbx.ReadOnly = false;
                        }
                    }
                }
            }
        }

        private void pogadaj_konacno_rjesenje(int t, int protivnik)
        {
            Random rnd = new Random();
            int p = rnd.Next(1, 4);
            if (p <= t)
            {
                textBox5.Text = asocijacija[20];
                textBox5.Font = new Font(textBox5.Font, FontStyle.Bold);
                textBox5.BackColor = Color.Aquamarine;
                textBox5.ReadOnly = true;
                //dodaj 40 bodova protivniku s indeksom "protivnik"
                if (protivnik == 1)
                    bodovi2 += 40;
                else
                    bodovi3 += 40;
                //kraj igre
                MessageBox.Show("Kraj igre asocijacija!");
                if (DetaljiIgre.IskoristenKviskoIgrac()) bodovi1 *= 2;
                if (DetaljiIgre.IskoristenKviskoPrvi()) bodovi2 *= 2;
                if (DetaljiIgre.IskoristenKviskoDrugi()) bodovi3 *= 2;
                DetaljiIgre.DodajBodove(this, bodovi1, bodovi2, bodovi3);
            }
            else
            {
                if (protivnik == 1)
                    potez_protivnik2();
                else
                {
                    //igra igrac
                    Red.Text = "Vi ste na redu!";
                    foreach (Control c in Controls)
                    {
                        if (c is Label && c != Red)
                        {
                            var label = (Label)c;
                            if (label.BackColor != Color.Aquamarine)
                                label.Click += label_Click;
                        }
                    }
                    foreach (Control c in Controls)
                    {
                        if (c is TextBox)
                        {
                            var tbx = (TextBox)c;
                            if (tbx.BackColor != Color.Aquamarine)
                                tbx.ReadOnly = false;
                        }
                    }
                }
            }
        }

        private List<Label> neotvorena_polja()
        {
            List<Label> lista = new List<Label>();
            foreach (Control c in Controls)
            {
                if (c is Label && c != Red)
                {
                    var label = (Label)c;
                    if (label.BackColor != Color.Aquamarine)
                        lista.Add(label);
                }
            }
            return lista;
        }

        private List<TextBox> neotvorena_rjesenja_stupaca()
        {
            List<TextBox> lista = new List<TextBox>();
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    var tb = (TextBox)c;
                    if (tb.BackColor != Color.Aquamarine)
                        lista.Add(tb);
                }
            }
            lista.Remove(textBox5);
            return lista;
        }

        private int stupac_s_najvise_otvorenih()
        {
            int s = 0, s1=-1, s2=-1, s3=-1, s4=-1;
            List<TextBox> neotvoreni = neotvorena_rjesenja_stupaca();
            if (neotvoreni.Contains(textBox1))
                s1 = 0;
            if (neotvoreni.Contains(textBox2))
                s2 = 0;
            if (neotvoreni.Contains(textBox3))
                s3 = 0;
            if (neotvoreni.Contains(textBox4))
                s4 = 0;

            foreach (Control c in Controls)
            {
                if (c is Label && c!=Red)
                {
                    var label = (Label)c;
                    if (label.BackColor == Color.Aquamarine)
                    {
                        string index;
                        if (label.Name.Length == 6)
                            index = label.Name.Substring(5, 1);
                        else
                            index = label.Name.Substring(5, 2);

                        int ind = Convert.ToInt32(index);
                        if ((ind == 1 || ind == 2 || ind == 3 || ind == 4) && s1 != -1)
                            s1++;
                        if ((ind == 5 || ind == 6 || ind == 7 || ind == 8) && s2 != -1)
                            s2++;
                        if ((ind == 9 || ind == 10 || ind == 11 || ind == 12) && s3 != -1)
                            s3++;
                        if ((ind == 13 || ind == 14 || ind == 15 || ind == 16) && s4 != -1)
                            s4++;
                    }
                }
            }
            int max = Math.Max(Math.Max(s1, s2), Math.Max(s3, s4));
            if (s1 == max) s = 1;
            if (s2 == max) s = 2;
            if (s3 == max) s = 3;
            if (s4 == max) s = 4;
            return s;
        }
    }
}
