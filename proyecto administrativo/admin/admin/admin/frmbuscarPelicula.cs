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
                
                string sql = "SELECT IIDPELICULA as 'Id', VTITULO as 'Nombre Pelicula',DCOSTO as 'Costo Pelicula',DDESCUENTO as 'Descuento Pelicula',VDURACION as 'Duracion',VSALA as 'Sala',VCLASIFICACION as 'Clasificacion',VCATEGORIA as 'Categoria',VELENCO as 'Elenco',VDEPARTAMENTO as 'Departamento',VESTABLECIMIENTO as 'Establecimiento',VIDIOMA as 'Idioma',VSUBTITULO as 'Subtitulo',IPUNTOS as 'Puntos' FROM MAPELICULA WHERE VTITULO ='" + txtbuscarPelicula.Text + "' OR VSUBTITULO = '" + txtbuscarsubtitulo.Text + "' OR VCATEGORIA= '" + txtbuscarGeneroPelicula.Text +"' OR VCLASIFICACION= '" + txtbuscarClasificacionPeli.Text+"'OR VSALA ='" + txtbuscarFormatoPeli.Text+"'";
                MySqlCommand cmd = new MySqlCommand(sql, clascrearConexion.ObtenerConexion());
                
                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable buscarPelicula = new DataTable();               //Creacion de objeto de una tabla auxiliar para sustituir por la tabla real
                buscarPelicula.Columns.Add("Id", typeof(string));
                buscarPelicula.Columns.Add("Nombre Pelicula", typeof(string));
                buscarPelicula.Columns.Add("Costo Pelicula", typeof(string));
                buscarPelicula.Columns.Add("Descuento Pelicula", typeof(string));
                buscarPelicula.Columns.Add("Duracion", typeof(string));
                buscarPelicula.Columns.Add("Sala", typeof(string));
                buscarPelicula.Columns.Add("Clasificacion", typeof(string));
                buscarPelicula.Columns.Add("Categoria", typeof(string));
                buscarPelicula.Columns.Add("Elenco", typeof(string));
                buscarPelicula.Columns.Add("Departamento", typeof(string));
                buscarPelicula.Columns.Add("Establecimiento", typeof(string));
                buscarPelicula.Columns.Add("Idioma", typeof(string));
                buscarPelicula.Columns.Add("Subtitulo", typeof(string));
                buscarPelicula.Columns.Add("Puntos", typeof(string));


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

                    MessageBox.Show("Pelicula Encontrada");

                }
                else
                {
                    MessageBox.Show("No existe ese registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmingresarPelicula pelicula = new frmingresarPelicula();
            pelicula.txtidPelicula.Text = this.grdinformacionPelicula.CurrentRow.Cells[0].Value.ToString();
            pelicula.txttitulo.Text = this.grdinformacionPelicula.CurrentRow.Cells[1].Value.ToString();
            pelicula.txtcosto.Text = this.grdinformacionPelicula.CurrentRow.Cells[2].Value.ToString();
            pelicula.txtdescuento.Text = this.grdinformacionPelicula.CurrentRow.Cells[3].Value.ToString();
            pelicula.txtduracionPelicula.Text = this.grdinformacionPelicula.CurrentRow.Cells[4].Value.ToString();
            pelicula.csalasCine.Text = this.grdinformacionPelicula.CurrentRow.Cells[5].Value.ToString();
            pelicula.cclasificacionContenidos.Text = this.grdinformacionPelicula.CurrentRow.Cells[6].Value.ToString();
            pelicula.ccategoriaPelicula.Text = this.grdinformacionPelicula.CurrentRow.Cells[7].Value.ToString();
            pelicula.txtelencoPelicula.Text = this.grdinformacionPelicula.CurrentRow.Cells[8].Value.ToString();
            pelicula.cdepartamento.Text = this.grdinformacionPelicula.CurrentRow.Cells[9].Value.ToString();
            pelicula.cestablecimiento.Text = this.grdinformacionPelicula.CurrentRow.Cells[10].Value.ToString();
            pelicula.cidioma.Text = this.grdinformacionPelicula.CurrentRow.Cells[11].Value.ToString();
            pelicula.csubtitulo.Text = this.grdinformacionPelicula.CurrentRow.Cells[12].Value.ToString();
            pelicula.txtpuntosBonificacion.Text = this.grdinformacionPelicula.CurrentRow.Cells[13].Value.ToString();
            pelicula.bguardar.Enabled = false;
            pelicula.beditar.Enabled = true;
            pelicula.beliminar.Enabled = true;
            this.Hide();
            pelicula.ShowDialog();
           
            

           


        }
    }
}
