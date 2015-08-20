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
    public partial class frmbuscarSala : Form
    {
        public frmbuscarSala()
        {
            InitializeComponent();
        }

        private void bbuscarSala_Click(object sender, EventArgs e)
        {
            try
            {
                //Ingreso de busqueda de sala en la bitacora
                claseEmp.Bita(claseEmp.MyUserName, 3, "TRSALA");
                String idSala = "";   //Variables para el Almacenamineto de resultados de los Querys
                String idSucursal = "";
                String capacidad = "";
                String tipo = "";


                string sql = "SELECT IIDSALA as 'Id Sala Cine', IDSUCURSAL as 'Id Sucursal Cine',ICAPACIDAD as 'Capacidad',VTIPO as 'Tipo' FROM TRSALA WHERE VTIPO ='" + txtbuscarSala.Text + "'OR ICAPACIDAD ='" + txtcapacidadSala.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, dllConexion.dllConexion.Conexion());
         

                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable buscarPelicula = new DataTable();               //Creacion de objeto de una tabla auxiliar para sustituir por la tabla real
                buscarPelicula.Columns.Add("Id Sala Cine", typeof(string));
                buscarPelicula.Columns.Add("id Sucursal Cine", typeof(string));
                buscarPelicula.Columns.Add("Capacidad", typeof(string));
                buscarPelicula.Columns.Add("Tipo", typeof(string));

                buscarPelicula.Rows.Clear();                              //Limpia datos de la Tabla

                while (reader.Read())
                {
                    idSala = reader.GetString(0).ToString();
                    idSucursal = reader.GetString(1).ToString();
                    capacidad = reader.GetString(2).ToString();
                    tipo = reader.GetString(3).ToString();
                    

                    buscarPelicula.Rows.Add(idSala,idSucursal,capacidad,tipo);
                    //MessageBox.Show("Sala Encontrada");


                }
                
                
                grdinformacionSala.DataSource = buscarPelicula;
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void bnuevabusqueda_Click(object sender, EventArgs e)
        {
            txtbuscarSala.ResetText();
            txtcapacidadSala.ResetText();
            grdinformacionSala.DataSource = null;
            grdinformacionSala.Rows.Clear();
            grdinformacionSala.Refresh();

        }
    }
}
