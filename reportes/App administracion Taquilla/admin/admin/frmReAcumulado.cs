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
    public partial class frmReAcumulado : Form
    {
        public frmReAcumulado()
        {
            InitializeComponent();
        }

        private void btnVerReporte_Click(object sender, EventArgs e)
        {
            frmReporteAcumuladoPuntos form = new frmReporteAcumuladoPuntos();
            form.Show();
        }
    }
}
