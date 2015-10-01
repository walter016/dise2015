using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitacora
{
    public partial class frmIniciarSesion : Form
    {
        public frmIniciarSesion()
        {
            InitializeComponent();
        }

        private void biniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtBxNombre.Text.Length == 0 && txtBxContra.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar los datos requeridos");
            }
            else
            {

                if (claseEmp.Autentificar(txtBxNombre.Text, txtBxContra.Text) > 0)
                {
                    this.Hide();
                    Presentacion form = new Presentacion();
                    form.Show();
                    claseEmp.MyUserName = txtBxNombre.Text;

                    claseEmp.Bita(txtBxNombre.Text, 1, "");
                }
                else
                    MessageBox.Show("Usuario y Contraseña Incorrectos");
            }
        }
    }
}
