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
    public partial class DodajAsocijaciju : Form
    {
        public DodajAsocijaciju()
        {
            InitializeComponent(); 
            this.StartPosition = FormStartPosition.Manual;
            this.Left = 200;
            this.Top = 80;
        }

        private void btn_as_Click(object sender, EventArgs e)
        {
            String[] novo = new String[21];

            novo[0] = textbox_as_1_1.Text;
            novo[1] = textbox_as_1_2.Text;
            novo[2] = textbox_as_1_3.Text;
            novo[3] = textbox_as_1_4.Text;
            novo[4] = textbox_as_1.Text;
            novo[5] = textbox_as_2_1.Text;
            novo[6] = textbox_as_2_2.Text;
            novo[7] = textbox_as_2_3.Text;
            novo[8] = textbox_as_2_4.Text;
            novo[9] = textbox_as_2.Text;
            novo[10] = textbox_as_3_1.Text;
            novo[11] = textbox_as_3_2.Text;
            novo[12] = textbox_as_3_3.Text;
            novo[13] = textbox_as_3_4.Text;
            novo[14] = textbox_as_3.Text;
            novo[15] = textbox_as_4_1.Text;
            novo[16] = textbox_as_4_2.Text;
            novo[17] = textbox_as_4_3.Text;
            novo[18] = textbox_as_4_4.Text;
            novo[19] = textbox_as_4.Text;
            novo[20] = textbox_as_final.Text;
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"files/asocijacije.txt", true))
            {
                foreach (string s in novo)
                {
                    file.WriteLine(s);
                }
            }

            MessageBox.Show("Dodano!");

            textbox_as_1_1.Text = "";
            textbox_as_1_2.Text = "";
            textbox_as_1_3.Text = "";
            textbox_as_1_4.Text = "";
            textbox_as_1.Text = "";
            textbox_as_2_1.Text = "";
            textbox_as_2_2.Text = "";
            textbox_as_2_3.Text = "";
            textbox_as_2_4.Text = "";
            textbox_as_2.Text = "";
            textbox_as_3_1.Text = "";
            textbox_as_3_2.Text = "";
            textbox_as_3_3.Text = "";
            textbox_as_3_4.Text = "";
            textbox_as_3.Text = "";
            textbox_as_4_1.Text = "";
            textbox_as_4_2.Text = "";
            textbox_as_4_3.Text = "";
            textbox_as_4_4.Text = "";
            textbox_as_4.Text = "";
            textbox_as_final.Text = "";
        }
    }
}
