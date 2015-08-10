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

namespace admin
{
    public partial class frmbitacora : Form
    {
        public frmbitacora()
        {
            InitializeComponent();
        }

        private void frmbitacora_Load(object sender, EventArgs e)
        {
            
            String usuario = "";   //Variables para el Almacenamineto de resultados de los Querys
                String hora = "";
                String  fecha = "";
                String nombre = "";
                string accion = "";
                
                string sqlb = "SELECT vusuario as 'Name Usuario', thora as 'hora ingreso',dfecha as 'fecha ingreso',vnombreEquipo as 'Nombre Equipo' FROM TRBITACORA";
                MySqlCommand cmdl = new MySqlCommand(sqlb, clascrearConexion.ObtenerConexion());

                MySqlDataReader reader = cmdl.ExecuteReader();

                DataTable bitacora = new DataTable();               //Creacion de objeto de una tabla auxiliar para sustituir por la tabla real
                bitacora.Columns.Add("Name Usuario", typeof(string));
                bitacora.Columns.Add("hora ingreso", typeof(string));
                bitacora.Columns.Add("fecha ingreso", typeof(string));
                bitacora.Columns.Add("Nombre Equipo", typeof(string));
               // bitacora.Columns.Add("Accion Realizada", typeof(string));

                //bitacora.Rows.Clear();                              //Limpia datos de la Tabla
                while (reader.Read())
                {
                    usuario = reader.GetString(0).ToString();
                    hora = reader.GetString(1).ToString();
                    fecha = reader.GetString(2).ToString();
                    nombre = reader.GetString(3).ToString();
                   // accion = reader.GetString(4).ToString();

                    bitacora.Rows.Add(usuario, hora, fecha, nombre);


                    

                }
                dgvbitacora.DataSource = bitacora;

            
        }

        private void dgvbitacora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }
    }
}
