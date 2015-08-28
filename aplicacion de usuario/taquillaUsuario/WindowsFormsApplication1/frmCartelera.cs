//La función del siguiente formulario es la de mostrar las peliculas segun la sucursal y ciudad seleccionados


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

namespace WindowsFormsApplication1
{
    public partial class cartelera : Form
    {

        public cartelera()
        {
            InitializeComponent();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmCiudad);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                frm.Show();
                frm.WindowState = FormWindowState.Normal;

                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frmCiudad();
            frm.Show();

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void cartelera_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        //Programador y Analista: José Wilfredo Chacón Cartagena
        //Programador y Analista: Luis Fernando Linares Garzaro (Edición Final)
        //Fecha de Asignación: 21/08/2015
        //Fecha de Entrega: 26/08/2015
        //Esta funcion se utiliza para mostrar los datos de la pelicula dinamicamente acorde a la sucursal seleecionada
        private void cartelera_Load(object sender, EventArgs e)
        {
            //Muestra el total de peliculas acorde ala sucursal seleccionada
            String numeroSucursal = lblsucursal.Text;
            // Esta parte ejecuta la consulta de la sucursal seleccionada
            string sql = "select count(*) FROM TRHORARIO TRHORA, MAPELICULA MAPELI WHERE TRHORA.iidpelicula=MAPELI.iidpelicula and TRHORA.idSucursal = '" + numeroSucursal + "'";
            MySqlCommand cmd = new MySqlCommand(sql, dllConexion.dllConexion.Conexion());
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                int n = reader.GetInt32(0);


                //En esta consulta Obtiene los datos y la imagen para mostrar en los picture box
                string query = string.Format("select Distinct TRHORA.iidpelicula, MAPELI.bimagen FROM TRHORARIO TRHORA, MAPELICULA MAPELI WHERE TRHORA.iidpelicula=MAPELI.iidpelicula and TRHORA.idSucursal = '" + numeroSucursal + "'");
                MySqlCommand comando = new MySqlCommand(query, dllConexion.dllConexion.Conexion());
                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                DataSet ds = new DataSet("MAPELICULA");
                da.Fill(ds, "MAPELICULA");
                dt = ds.Tables["MAPELICULA"];
                byte[] datos = new byte[0];
                int i = -1;
                foreach (DataRow dr in dt.Rows)
                {
                    // se hace incrementable la variable I
                    i++;
                    datos = (byte[])dr["bimagen"];
                    // se captura el id de la pelicula
                    string peli = dr["iidpelicula"].ToString();
                    PictureBox pb = new PictureBox();
                    //dibuja los picture box con sus  propiedades 
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                    pb.Image = System.Drawing.Bitmap.FromStream(ms);
                    // se multiplica por la variable i para que valla aumentando el ancho  de la imagen en la pelicula
                    pb.Size = new System.Drawing.Size(250, 320);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    // ala hora de hacer click en el picturebox se envia la variable de la pelicula
                    pb.Click += new EventHandler((sender1, e1) => PB_Click(sender1, e1, peli));
                    flowLayoutPanel1.Controls.Add(pb);

                }
            }
        }

        protected void PB_Click(object sender, EventArgs e, string pelicula)
        {
            frmInformacion info = new frmInformacion();
            //se asigna la variable pelicula hacia la variable My id Movie
            claseEmp.MyIdMovie = pelicula;
            // se muestra el formulario informacion
            info.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}