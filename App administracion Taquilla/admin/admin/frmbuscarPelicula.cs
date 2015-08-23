//Diseño y Creacion: Hector Joannes Gil Cardona
//Fecha de asignación: 03/08/2015
//Fecha de entrega: 07/08/2015
//Modificacion: Luis Linares - Acciones a Bitacora
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
                //Diseño y Creacion: Hector Joannes Gil Cardona
                //Fecha de asignación: 03/08/2015
                //Fecha de entrega: 07/08/2015
                //modificacion: 19/08/2015
                //Ingreso de busqueda de pelicula en la bitacora
                claseEmp.Bita(claseEmp.MyUserName, 3, "MAPELICULA");
            
                String sidPelicula = "";   //Variables para el Almacenamineto de resultados de los Querys
                String stitulo = "";     
                String scosto = "";
                String sdescuento = "";
                String ssala = "";
                String sclasificacion = "";
                String scategoria = "";
                String selenco = "";
                String sidioma = "";
                String ssubtitulo = "";
                String spuntos = "";
                
                //query para la seleccion del dato a buscar
                string sql = "SELECT IIDPELICULA as 'Id', VTITULO as 'Nombre Pelicula',DCOSTO as 'Costo Pelicula',DDESCUENTO as 'Descuento Pelicula',VTIPOSALA as 'Sala',VCLASIFICACION as 'Clasificacion',VCATEGORIA as 'Categoria',VELENCO as 'Elenco',VIDIOMA as 'Idioma',VSUBTITULO as 'Subtitulo',IPUNTOS as 'Puntos' FROM MAPELICULA WHERE VTITULO ='" + txtbuscarPelicula.Text + "' OR VSUBTITULO = '" + txtbuscarsubtitulo.Text + "' OR VCATEGORIA= '" + txtbuscarGeneroPelicula.Text +"' OR VCLASIFICACION= '" + txtbuscarClasificacionPeli.Text+"'OR VTIPOSALA ='" + txtbuscarFormatoPeli.Text+"'";
                MySqlCommand cmd = new MySqlCommand(sql, dllConexion.dllConexion.Conexion());
                // reader al momento de realizar la busqueda
                MySqlDataReader reader = cmd.ExecuteReader();


               

                DataTable buscarPelicula = new DataTable(); 

                //Creacion de objeto de una tabla auxiliar para sustituir por la tabla real
                buscarPelicula.Columns.Add("Id", typeof(string));// asigna el campo ID de tipo string en la posicion 0 de la columna del datagridview
                buscarPelicula.Columns.Add("Nombre Pelicula", typeof(string));
                buscarPelicula.Columns.Add("Costo Pelicula", typeof(string));
                buscarPelicula.Columns.Add("Descuento Pelicula", typeof(string));
                buscarPelicula.Columns.Add("Sala", typeof(string));
                buscarPelicula.Columns.Add("Clasificacion", typeof(string));
                buscarPelicula.Columns.Add("Categoria", typeof(string));
                buscarPelicula.Columns.Add("Elenco", typeof(string));
                buscarPelicula.Columns.Add("Idioma", typeof(string));
                buscarPelicula.Columns.Add("Subtitulo", typeof(string));
                buscarPelicula.Columns.Add("Puntos", typeof(string));


                buscarPelicula.Rows.Clear(); //Limpia datos de la Tabla

               

                while (reader.Read())
                {
                    // asigancion de los datos en las variables string
                    sidPelicula = reader.GetString(0).ToString(); //asigna las variables para los datos del datagridview
                    stitulo = reader.GetString(1).ToString();
                    scosto = reader.GetString(2).ToString();
                    sdescuento = reader.GetString(3).ToString();
                    ssala = reader.GetString(4).ToString();
                    sclasificacion = reader.GetString(5).ToString();
                    scategoria = reader.GetString(6).ToString();
                    selenco = reader.GetString(7).ToString();
                    sidioma = reader.GetString(8).ToString();
                    ssubtitulo = reader.GetString(9).ToString();
                    spuntos = reader.GetString(10).ToString();

                    
                    // se agregan cada columna al datagrid
                    buscarPelicula.Rows.Add(sidPelicula,stitulo,scosto,sdescuento,ssala,sclasificacion,scategoria,selenco,sidioma,ssubtitulo,spuntos);

                   

                }
                //validacion si existe pelicula o no
                if (buscarPelicula.Rows.Count > 0)
                {
                    MessageBox.Show("pelicula encontrada");
                }
                else
                {
                    grdinformacionPelicula.DataSource = null;
                    grdinformacionPelicula.Refresh();
                    MessageBox.Show("No existe ese registro");
                }

              
                

               //muestra la infomracion buscada en el datagridview
                grdinformacionPelicula.DataSource = buscarPelicula;
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void frmbuscarPelicula_Load(object sender, EventArgs e)
        {


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Diseño y Creacion: Hector Joannes Gil Cardona
            //Fecha de asignación: 03/08/2015
            //Fecha de entrega: 07/08/2015
            //modificacion: 19/08/2015
            //asignacion de cada columna para el fomulario de edicion de los datos
            frmingresarPelicula pelicula = new frmingresarPelicula();
            pelicula.txtidPelicula.Text = this.grdinformacionPelicula.CurrentRow.Cells[0].Value.ToString();
            pelicula.txttitulo.Text = this.grdinformacionPelicula.CurrentRow.Cells[1].Value.ToString();
            pelicula.txtcosto.Text = this.grdinformacionPelicula.CurrentRow.Cells[2].Value.ToString();
            pelicula.txtdescuento.Text = this.grdinformacionPelicula.CurrentRow.Cells[3].Value.ToString();
    
            pelicula.csalasCine.Text = this.grdinformacionPelicula.CurrentRow.Cells[4].Value.ToString();
            pelicula.cclasificacionContenidos.Text = this.grdinformacionPelicula.CurrentRow.Cells[5].Value.ToString();
            pelicula.ccategoriaPelicula.Text = this.grdinformacionPelicula.CurrentRow.Cells[6].Value.ToString();
            pelicula.txtelencoPelicula.Text = this.grdinformacionPelicula.CurrentRow.Cells[7].Value.ToString();
           
            pelicula.cidioma.Text = this.grdinformacionPelicula.CurrentRow.Cells[8].Value.ToString();
            pelicula.csubtitulo.Text = this.grdinformacionPelicula.CurrentRow.Cells[9].Value.ToString();
            pelicula.txtpuntosBonificacion.Text = this.grdinformacionPelicula.CurrentRow.Cells[10].Value.ToString();
            pelicula.bguardar.Enabled = false;
            pelicula.beditar.Enabled = true;
            pelicula.beliminar.Enabled = true;
            // query para la seleccion de la imagen
            string query = string.Format("SELECT bimagen FROM MAPELICULA where iidpelicula ='{0}'", this.grdinformacionPelicula.CurrentRow.Cells[0].Value.ToString());
            MySqlCommand comando = new MySqlCommand(query, dllConexion.dllConexion.Conexion());
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataSet ds = new DataSet("MAPELICULA");
            da.Fill(ds, "MAPELICULA");
            byte[] datos = new byte[0];
            DataRow dr = ds.Tables["MAPELICULA"].Rows[0];
            datos = (byte[])dr["bimagen"];
            System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
            pelicula.pimagenPelicula.Image = System.Drawing.Bitmap.FromStream(ms);

            this.Hide();
            pelicula.ShowDialog();
           
            

           


        }

        private void bnuevabusqueda_Click(object sender, EventArgs e)
        {
            //Diseño: Hector Joannes Gil Cardona
            //Fecha de asignación: 03/08/2015
            //Fecha de entrega: 07/08/2015
            //modificacion: 19/08/2015
            txtbuscarPelicula.ResetText(); //Resetext limpia cada objeto del formulario
            txtbuscarsubtitulo.ResetText();
            txtbuscarClasificacionPeli.ResetText();
            txtbuscarGeneroPelicula.ResetText();
            txtbuscarFormatoPeli.ResetText();
            grdinformacionPelicula.DataSource = null; // borra la consulta para una nueva
            grdinformacionPelicula.Rows.Clear();
            grdinformacionPelicula.Refresh();
        }

        private void bcancelarPelicula_Click(object sender, EventArgs e)
        {
            //Diseño y Creacion: Hector Joannes Gil Cardona
            //Fecha de asignación: 03/08/2015
            //Fecha de entrega: 07/08/2015
            //modificacion: 19/08/2015
            //limpieza de cada objeto en el formulario
            txtbuscarPelicula.ResetText();
            txtbuscarsubtitulo.ResetText();
            txtbuscarClasificacionPeli.ResetText();
            txtbuscarGeneroPelicula.ResetText();
            txtbuscarFormatoPeli.ResetText();
            grdinformacionPelicula.DataSource = null;
            grdinformacionPelicula.Rows.Clear();
            grdinformacionPelicula.Refresh();
        }
    }
}
