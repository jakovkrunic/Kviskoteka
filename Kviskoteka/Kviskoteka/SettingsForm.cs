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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            prvi_abc.Value = DetaljiIgre.TezinaPrvog(0);
            prvi_as.Value = DetaljiIgre.TezinaPrvog(1);
            prvi_det.Value = DetaljiIgre.TezinaPrvog(2);
            prvi_zav.Value = DetaljiIgre.TezinaPrvog(3);

            drugi_abc.Value = DetaljiIgre.TezinaDrugog(0);
            drugi_as.Value = DetaljiIgre.TezinaDrugog(1);
            drugi_det.Value = DetaljiIgre.TezinaDrugog(2);
            drugi_zav.Value = DetaljiIgre.TezinaDrugog(3);
            this.StartPosition = FormStartPosition.Manual;
            this.Left = 200;
            this.Top = 80;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
