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
    public partial class ABC : Form
    {
        int broj_bodova = 0;
        int broj_bodova_1 = 0;
        int broj_bodova_2 = 0;


        public ABC()
        {
            InitializeComponent();

            String[] igra = new FileManager().abcPitalica();


        }
    }
}
