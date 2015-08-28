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
    public partial class frmCompra : Form
    {
        public frmCompra()
        {
            InitializeComponent();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            /*
            this.Close();
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmventa);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                frm.WindowState = FormWindowState.Normal;
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frmventa();
            frm.Show
             * */
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //this.Close();
            ////se localiza el formulario buscandolo entre los forms abiertos 
            //Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmventa);

            //if (frm != null)
            //{
            //    //si la instancia existe la pongo en primer plano
            //    frm.BringToFront();
            //    frm.WindowState = FormWindowState.Normal;
            //    return;
            //}

            ////sino existe la instancia se crea una nueva
            //frm = new frmventa();
            //frm.Show();
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
