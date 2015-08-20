/*
 Diseño y programacion inicial Walter Flores 
 */
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
    public partial class frmingresarCiudad : Form
    {
        public frmingresarCiudad()
        {
            InitializeComponent();
        }
        //insercion de ciudades dentro de la base de datos
        private void bguardar_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtnombreCiudad.Text))
            {
                MessageBox.Show("Debe de ingresar una Ciudad"); 
            }
            else
            {
                
                try
                {
                    string query = string.Format("INSERT INTO MACIUDAD (vnombreCiudad) VALUES('{0}')", txtnombreCiudad.Text);
                    dllConexion.dllConexion.inserta(query);
                    MessageBox.Show("La Ciudad se registro exitosamente");
                }
                catch
                {
                    MessageBox.Show("Ocurrio algun error! Lo sentimos");
                }
            }
            
        }

        private void txtnombreCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "" ,MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
