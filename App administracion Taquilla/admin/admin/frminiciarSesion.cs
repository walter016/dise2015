//Diseño:  Luis Fernando Linares
//Fecha de asignación: 05/08/2015
//Fecha de entrega: 05/08/2015
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

       

        //Programador y Analista: Luis Fernando Linares Garzaro
        //Esta funcion es la seguridad del sistema en el cual solo usuarios verificados pueden entrar
        //Fecha de asignación: 10/08/2015
        //Fecha de entrega: 10/08/2015

        private void biniciarSesion_Click_1(object sender, EventArgs e)
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
                    frmmenuPrincipal Menu = new frmmenuPrincipal();
                    Menu.Show();
                    claseEmp.MyUserName = txtBxNombre.Text;

                    claseEmp.Bita(txtBxNombre.Text, 1, "");
                }
                else
                    MessageBox.Show("Usuario y Contraseña Incorrectos");


            }




        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            txthora.Text = DateTime.Now.ToString("hh:mm:ss");
            txtname.Text = Environment.MachineName;

        }

        private void frminiciarSesion_Load(object sender, EventArgs e)
        {

        }

       

       


    }
}