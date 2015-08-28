using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using dllConexion;

namespace WindowsFormsApplication1
{
    public partial class frmInformacion : Form
    {
        public frmInformacion()
        {
            InitializeComponent();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            
           /* frmVenta ventas = new frmVenta();                       
            ventas.Show();
            this.WindowState = FormWindowState.Minimized;*/
        }



        private void informacion_Load(object sender, EventArgs e)
        {
            ToolTip tstclasificacion = new ToolTip();
            ToolTip tstsala = new ToolTip();
            tstclasificacion.IsBalloon = true;
            tstsala.IsBalloon = true;
            
            //Programador y Analista: Luis Fernando Linares Garzaro
            //Fecha de Asignación: 21/08/2015
            //Fecha de Entrega: 26/08/2015
            //Esta funcion se utiliza para mostrar la informacion de la pelicula cuando el usuario desee verla
            try
            {
                // se ejecuta la consulta para mostrar la informacion de la pelicula
                string sql = "SELECT trhorario.iidHorario, mapelicula.vtitulo, mapelicula.dcosto, mapelicula.vclasificacion, mapelicula.vcategoria,mapelicula.velenco,mapelicula.vidioma,mapelicula.vsubtitulo,trhorario.thorainicio,trhorario.thorafinal,CONCAT(thorainicio,'         -             ',thorafinal) AS Hora ,mapelicula.bimagen FROM mapelicula" +
                " INNER JOIN trhorario ON mapelicula.iidpelicula = trhorario.iidPelicula WHERE trhorario.iidPelicula = '" + claseEmp.MyIdMovie + "'";
                MySqlCommand comando = new MySqlCommand(sql, dllConexion.dllConexion.Conexion());
                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                DataSet ds = new DataSet("MAPELICULA");
                da.Fill(ds, "MAPELICULA");
                dt = ds.Tables["MAPELICULA"];

                byte[] datos = new byte[0];
                foreach (DataRow dr in dt.Rows)
                {
                    string TituloPeli = dr["vtitulo"].ToString();
                    string CostoPeli = dr["dcosto"].ToString();
                    string ClasificacionSala = dr["vclasificacion"].ToString();
                    string CategPeli = dr["vcategoria"].ToString();
                    string ElencoPeli = dr["velenco"].ToString();
                    string IdiomaPeli = dr["vidioma"].ToString();
                    string SubtituloPeli = dr["vsubtitulo"].ToString();



                    //asigna los datos para mostrarlos en pantalla
                    lblclasificacion.Text = ClasificacionSala;
                    
                    NmbPeli.Text = TituloPeli;
                    MstCosto.Text = CostoPeli;
                    MstCategoria.Text = CategPeli;
                    MstIdioma.Text = IdiomaPeli;
                    MstSubtitu.Text = SubtituloPeli;
                    cmbBxHora.DisplayMember = "Hora";
                    cmbBxHora.ValueMember = "iidHorario";
                    cmbBxHora.DataSource = dt;
                        
                        datos = (byte[])dr["bimagen"];
                        //dibuja los picture box con sus  propiedades 
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                        pictureBox1.Image = System.Drawing.Bitmap.FromStream(ms);
                        

                    }
                  
                   
            
            
           }
           catch (Exception m)
           {
               MessageBox.Show(m.Message);
           }
            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is cartelera);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                frm.WindowState = FormWindowState.Normal;
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new cartelera();
            frm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnClasificacion_Click(object sender, EventArgs e)
        {   


            
                
            
        }

        private void btnSala_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void breservarPelicula_Click(object sender, EventArgs e)
        {
            string idhorario = cmbBxHora.SelectedValue.ToString();
            claseEmp.idschedule = idhorario;

            this.Close();
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmreservacion);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                frm.WindowState = FormWindowState.Maximized;
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frmreservacion();
            frm.Show();
        }
    }
}
