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
    public partial class frmReportePeliculas : Form
    {
        public frmReportePeliculas()
        {
            InitializeComponent();
        }

        private void frmReportePeliculas_Load(object sender, EventArgs e)
        {

            this.rVReportePeliculas.RefreshReport();
        }
    }
}
