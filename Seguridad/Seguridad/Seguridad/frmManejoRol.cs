using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejo_Rol
{
    public partial class frmManejoRol : Form
    {
        public frmManejoRol()
        {
            InitializeComponent();
        }

        public E_Rol EmpleadoActual { get; set; }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            frmConsulta buscar = new frmConsulta();
            
            buscar.Show();
            
            if (buscar.EmpleadoSeleccionado != null)
            {
                EmpleadoActual = buscar.EmpleadoSeleccionado;
                txtUsuario.Text = Convert.ToString( buscar.EmpleadoSeleccionado.Id);
                txtNombreUsuario.Text = buscar.EmpleadoSeleccionado.Nombre;
              

            }
            this.Hide();
        }

        private void frmManejoRol_Load(object sender, EventArgs e)
        {
            mostrarPerfil();
            mostrarApps();
        }


        private void mostrarPerfil()
        {
            try
            {
                // le asignas una fuente de datos al listbox1
                lbPerfiles.DataSource = D_Rol.consultaPerfil();
                // dysplaymember es el valor que se vera en el list
               lbPerfiles.DisplayMember = "vnombreRole";
                // valuemember es el valor del list
               lbPerfiles.ValueMember = "iidRole";
            }
            catch (Exception e)
            {

            }
        }

        private void mostrarApps()
        {
            try
            {
                // le asignas una fuente de datos al listbox1
                lbAppDisponibles.DataSource = D_Rol.consultaApps();
                // dysplaymember es el valor que se vera en el list
                lbAppDisponibles.DisplayMember = "vnombreAplicacion";
                // valuemember es el valor del list
                lbAppDisponibles.ValueMember = "iidAplicacion";
            }
            catch (Exception e)
            {

            }
        }

    }
}
