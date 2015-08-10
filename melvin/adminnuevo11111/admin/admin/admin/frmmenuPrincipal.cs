using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace admin
{
    public partial class frmmenuPrincipal : Form
    {
        public frmmenuPrincipal()
        {
            InitializeComponent();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process pr = new Process();
            pr.StartInfo.WorkingDirectory = @"C:\Users\Wilfredo\Desktop\admin\admin\admin";
            pr.StartInfo.FileName = "SofTool Systems help.htm";
            pr.Start();
        }

        private void editarInformacionDePeliculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbuscarPelicula form = new frmbuscarPelicula();
            form.Show();
        }

        private void registrarPeliculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmingresarPelicula form = new frmingresarPelicula();
            form.Show();
        }

        private void busquedaDeSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbuscarSucursal form = new frmbuscarSucursal();
            form.Show();
        }

        private void busquedaDeSalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbuscarSala form = new frmbuscarSala();
            form.Show();
        }

        private void ingresarSalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmingresarSala form = new frmingresarSala();
            form.Show();
        }

        private void registrarSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmingresarSucursal form = new frmingresarSucursal();
            form.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void registroUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmregistroUsuario formregistro = new frmregistroUsuario(); 
            formregistro.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void bitacoraDeIngresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbitacora formbitacora = new frmbitacora();
            formbitacora.Show();
        }
    }
}
   
