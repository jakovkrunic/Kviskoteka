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
        public Asocijacije()
        {
            InitializeComponent();
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

            if (clickedLabel != null)
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
            }
        }

        private void CheckKeys(object sender, System.Windows.Forms.KeyPressEventArgs e)
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
                            MessageBox.Show("bravo");
                            tb.BackColor = Color.Aquamarine;
                            tb.ReadOnly = true;
                        }
                        else
                        {
                            MessageBox.Show("nije tocno");
                            tb.Text = "";
                        }
                    }
                }
                if (tb.Name == "textBox5")
                {
                    if (tb.Text == asocijacija[20])
                    {
                        MessageBox.Show("bravo, pogodili ste konacno rjesenje");
                        tb.BackColor = Color.Aquamarine;
                        tb.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("nije tocno");
                        tb.Text = "";
                    }
                }
            }
        }
    }
}
