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
    public partial class frmbuscarPelicula : Form
    {
        public frmbuscarPelicula()
        {
            InitializeComponent();
        }

        private void bbuscarPelicula_Click(object sender, EventArgs e)
        {
            try
            {
                String idPelicula = "";   //Variables para el Almacenamineto de resultados de los Querys
                String titulo = "";
                String costo = "";
                String descuento = "";
                String duracion = "";
                String sala = "";
                String clasificacion = "";
                String categoria = "";
                String elenco = "";
                String departamento = "";
                String establecimiento = "";
                String idioma = "";
                String subtitulo = "";
                String puntos = "";

                string sql = "SELECT IIDPELICULA,VTITULO as 'Nombre Pelicula',DCOSTO,DDESCUENTO,VDURACION,VSALA,VCLASIFICACION,VCATEGORIA,VELENCO,VDEPARTAMENTO,VESTABLECIMIENTO,VIDIOMA,VSUBTITULO,IPUNTOS FROM MAPELICULA WHERE VTITULO ='" + txtbuscarPelicula.Text + "' OR VSUBTITULO = '" + txtbuscarsubtitulo.Text + "' OR VCATEGORIA= '" + txtbuscarGeneroPelicula.Text +"' OR VCLASIFICACION= '" + txtbuscarClasificacionPeli.Text+"'OR VSALA ='" + txtbuscarFormatoPeli.Text+"'";
                MySqlCommand cmd = new MySqlCommand(sql, clascrearConexion.ObtenerConexion());
                
                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable buscarPelicula = new DataTable();               //Creacion de objeto de una tabla auxiliar para sustituir por la tabla real
                buscarPelicula.Columns.Add("IIDPELICULA", typeof(string));
                buscarPelicula.Columns.Add("Nombre Pelicula", typeof(string));
                buscarPelicula.Columns.Add("DCOSTO", typeof(string));
                buscarPelicula.Columns.Add("DDESCUENTO", typeof(string));
                buscarPelicula.Columns.Add("VDURACION", typeof(string));
                buscarPelicula.Columns.Add("VSALA", typeof(string));
                buscarPelicula.Columns.Add("VCLASIFICACION", typeof(string));
                buscarPelicula.Columns.Add("VCATEGORIA", typeof(string));
                buscarPelicula.Columns.Add("VELENCO", typeof(string));
                buscarPelicula.Columns.Add("VDEPARTAMENTO", typeof(string));
                buscarPelicula.Columns.Add("VESTABLECIMIENTO", typeof(string));
                buscarPelicula.Columns.Add("VIDIOMA", typeof(string));
                buscarPelicula.Columns.Add("VSUBTITULO", typeof(string));
                buscarPelicula.Columns.Add("IPUNTOS", typeof(string));


                buscarPelicula.Rows.Clear();                              //Limpia datos de la Tabla

                if (reader.Read())
                {
                    idPelicula = reader.GetString(0).ToString();
                    titulo = reader.GetString(1).ToString();
                    costo = reader.GetString(2).ToString();
                    descuento = reader.GetString(3).ToString();
                    duracion = reader.GetString(4).ToString();
                    sala = reader.GetString(5).ToString();
                    clasificacion = reader.GetString(6).ToString();
                    categoria = reader.GetString(7).ToString();
                    elenco = reader.GetString(8).ToString();
                    departamento = reader.GetString(9).ToString();
                    establecimiento = reader.GetString(10).ToString();
                    idioma = reader.GetString(11).ToString();
                    subtitulo = reader.GetString(12).ToString();
                    puntos = reader.GetString(13).ToString();

                    buscarPelicula.Rows.Add(idPelicula,titulo,costo,descuento,duracion,sala,clasificacion,categoria,elenco,departamento,establecimiento,idioma,subtitulo,puntos);

                    MessageBox.Show("Medicamento Encontrado");

                }
                else
                {
                    MessageBox.Show("No existen medicamentos con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    
                }
                grdinformacionPelicula.DataSource = buscarPelicula;
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void frmbuscarPelicula_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taquillaDataSet1.mapelicula' table. You can move, or remove it, as needed.
           // this.mapeliculaTableAdapter.Fill(this.taquillaDataSet1.mapelicula);
            // TODO: This line of code loads data into the 'taquillaDataSet.mapelicula' table. You can move, or remove it, as needed.
           // this.mapeliculaTableAdapter.Fill(this.taquillaDataSet.mapelicula);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
