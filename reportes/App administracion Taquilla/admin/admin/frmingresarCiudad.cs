/*
 Diseño y programacion inicial Walter Flores
 * Modificacion: Hector Cardona
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
using MySql.Data.MySqlClient;

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
            if (String.IsNullOrEmpty(txtnombreCiudad.Text))
            {
                MessageBox.Show("Debe de ingresar una Ciudad");
            }
            else
            {
                String nombreCiudad = null;
                string sql = "SELECT vnombreCiudad FROM MACIUDAD WHERE vnombreCiudad ='" + txtnombreCiudad.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, dllConexion.dllConexion.Conexion());
                // reader al momento de realizar la busqueda
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable buscarCiudad = new DataTable();

                //Creacion de objeto de una tabla auxiliar para sustituir por la tabla real
                buscarCiudad.Columns.Add("vnombreCiudad", typeof(string));// asigna el valor del campo nombre ciudad a la columna



                buscarCiudad.Rows.Clear(); //Limpia datos de la Tabla



                if (reader.Read())
                {
                    // asigancion de los datos en las variables string
                    nombreCiudad = reader.GetString(0).ToString(); //asignnacion de datos a la variable String
                }



                //Comprobacion si ya existe la ciudad
                if (txtnombreCiudad.Text == nombreCiudad)
                {
                    MessageBox.Show("Ya existe " + txtnombreCiudad.Text + " como registro");
                    txtnombreCiudad.ResetText();
                }
                else
                {
                    //si no existe, inserta el dato
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
