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
    public partial class frmReporteGanancias : Form
    {
        public frmReporteGanancias()
        {
            InitializeComponent();
        }

        private void frmReporteGanancias_Load(object sender, EventArgs e)
        {

            this.rVReporteGanancias.RefreshReport();
        }
    }
}
