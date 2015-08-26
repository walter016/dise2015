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
                String accion = "";
                String tabla = "";

                string sqlb = "SELECT TRBITA.vusuario as 'Nombre Usuario', TRBITA.thora as 'Hora Ingreso', TRBITA.dfecha as 'Fecha Ingreso', TRBITA.vnombreEquipo as 'Nombre Equipo', MAACC.DescAccion as 'Accion Realizada', TRBITA.vTabla as 'Tabla ' FROM TRBITACORA TRBITA, MAACCION MAACC WHERE TRBITA.vaccion=MAACC.iidAccion";
                MySqlCommand cmdl = new MySqlCommand(sqlb, dllConexion.dllConexion.Conexion());

                MySqlDataReader reader = cmdl.ExecuteReader();

                DataTable bitacora = new DataTable();               //Creacion de objeto de una tabla auxiliar para sustituir por la tabla real
                bitacora.Columns.Add("Nombre Usuario", typeof(string));
                bitacora.Columns.Add("Hora Ingreso", typeof(string));
                bitacora.Columns.Add("Fecha Ingreso", typeof(string));
                bitacora.Columns.Add("Nombre Equipo", typeof(string));
                bitacora.Columns.Add("Accion Realizada", typeof(string));
                bitacora.Columns.Add("Tabla", typeof(string));

                //bitacora.Rows.Clear();                              //Limpia datos de la Tabla
                while (reader.Read())
                {
                    usuario = reader.GetString(0).ToString();
                    hora = reader.GetString(1).ToString();
                    fecha = reader.GetString(2).ToString();
                    nombre = reader.GetString(3).ToString();
                    accion = reader.GetString(4).ToString();
                    tabla = reader.GetString(5).ToString();

                    bitacora.Rows.Add(usuario, hora, fecha, nombre, accion,tabla);


                    

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
