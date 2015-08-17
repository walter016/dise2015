using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmCiudad : Form
    {
        public frmCiudad()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCine.SelectedIndex = 0;
            cmbCiudad.SelectedIndex = 0;
        }

        private void btnCartelera_Click(object sender, EventArgs e)
        {
            cartelera cartelera = new cartelera();            
            cartelera.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
