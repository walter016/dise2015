//Diseño: José Wilfredo Chacón Cartagena
//Fecha de asignación: 01/08/2015
//Fecha de entrega: 01/08/2015

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
    public partial class frminiciarSesion : Form
    {
        public frminiciarSesion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmmenuPrincipal form = new frmmenuPrincipal();
            form.Show();
        }

        private void biniciarSesion_Click(object sender, EventArgs e)
        {
            if (claseEmp.Autentificar(txtBxNombre.Text, txtBxContra.Text) > 0)
            {
                this.Hide();
                frmmenuPrincipal Menu = new frmmenuPrincipal();
                Menu.Show();
            }
            else
                MessageBox.Show("Usuario y Contraseña Incorrectos");
        }
    }
}
