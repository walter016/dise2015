/*
 * Diseño princial Wilfredo Chacon 
 * cambio de diseño y programacion Walter Flores 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dllConexion;

namespace admin
{
    public partial class frmingresarSucursal : Form
    {
        public frmingresarSucursal()
        {
            InitializeComponent();
        }
        //Tabla la cual se utiliza para los valores del ComboBox cestadoSucursal el cual
        //se almacena un 1 si es disponible, 0 si no esta ahun disponible
        private DataTable Fill()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("texto");
            dt.Columns.Add("valor");
            DataRow contenido = dt.NewRow();
            contenido["texto"] = "Disponible";
            contenido["valor"] = "1";

            DataRow contenido2 = dt.NewRow();
            contenido2["texto"] = "No Disponible";
            contenido2["valor"] = "0";

            dt.Rows.Add(contenido);
            dt.Rows.Add(contenido2);
            cestadoSucursal.DisplayMember = "texto";
            cestadoSucursal.ValueMember = "valor";
            return dt;
        }
        //Obtenemos desde la base de datos todas las ciudades registradas
        //estas se cargan despues a un ComboBox cciudad
        private DataTable ciudad()
        {
            DataTable dat = new DataTable();
            string query = "SELECT iidCiudad,vnombreCiudad FROM MACIUDAD";
            MySqlCommand comando = new MySqlCommand(query, dllConexion.dllConexion.Conexion());
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            cciudad.DisplayMember = "vnombreCiudad";
            cciudad.ValueMember = "iidCiudad";
            da.Fill(dat);
            dllConexion.dllConexion.Conexion().Close();
            return dat;
        }
        //Guardado de los datos dentro de la bd
        private void bguardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtdireccionSucursal.Text))
            {
                MessageBox.Show("Debe de Ingresar Una Sucursal");
            }
            else
            {
               
                string query = string.Format("INSERT INTO MASUCURSAL (iidciudad, iestado, vnombre) VALUES('{0}','{1}','{2}')", cciudad.SelectedValue, cestadoSucursal.SelectedValue, txtdireccionSucursal.Text);
                try
                {
                    dllConexion.dllConexion.inserta(query);
                    cciudad.ResetText();
                    cestadoSucursal.ResetText();
                    txtdireccionSucursal.ResetText();
                    
                    MessageBox.Show("Sucursal registrada con Exito");
                    //Ingreso de sucursal en la bitacora
                    claseEmp.Bita(claseEmp.MyUserName, 2, "MASUCURSAL");
                }
                catch
                {
                    MessageBox.Show("Ocurrió un Error");
                }
            }
            
        }
        //Cargar los datos de los ComboBox al iniciar el formulario
        private void frmingresarSucursal_Load(object sender, EventArgs e)
        {
            cestadoSucursal.DataSource= Fill();
            cciudad.DataSource = ciudad();
        }

        private void txtdireccionSucursal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
