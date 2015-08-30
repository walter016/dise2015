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
    public partial class frmRePeliculas : Form
    {
        public frmRePeliculas()
        {
            InitializeComponent();
        }

        private void cmbSemanaMes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVerReporte_Click(object sender, EventArgs e)
        {
            frmReportePeliculas form = new frmReportePeliculas();
            form.Show();
        }
    }
}
