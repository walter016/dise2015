using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admin
{
    public partial class frmReGanancias : Form
    {
        public frmReGanancias()
        {
            InitializeComponent();
        }

        private void btnVerReporte_Click(object sender, EventArgs e)
        {
            frmReporteGanancias form = new frmReporteGanancias();
            form.Show();
        }
    }
}
