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
    public partial class frmReporteAcumuladoPuntos : Form
    {
        public frmReporteAcumuladoPuntos()
        {
            InitializeComponent();
        }

        private void frmReporteAcumuladoPuntos_Load(object sender, EventArgs e)
        {

            this.rVReporteAcumuladoPuntos.RefreshReport();
        }
    }
}
