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
                }
                else
                    MessageBox.Show("Usuario y Contraseña Incorrectos");


            string fecha;
            fecha = dtpfecha.Value.Year + "/" + dtpfecha.Value.Month + "/" + dtpfecha.Value.Day;
            string query = string.Format("INSERT INTO TRBITACORA (vusuario, thora, dfecha, vNombreEquipo) VALUES('{0}','{1}','{2}','{3}')", txtBxNombre.Text, txthora.Text, fecha, txtname.Text);

            clascrearConexion.inserta(query);


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