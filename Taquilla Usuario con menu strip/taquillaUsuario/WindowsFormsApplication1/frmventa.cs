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
    public partial class frmasientos : Form
    {
        public frmasientos()
        {
            InitializeComponent();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void venta_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmInformacion);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                frm.Show();
                frm.WindowState = FormWindowState.Normal;

                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frmInformacion();
            frm.Show();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            Form frm = new frmCompra();
            frm.Show();
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmInformacion);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                frm.Show();
                frm.WindowState = FormWindowState.Normal;

                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frmInformacion();
            frm.Show();
        }

        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
