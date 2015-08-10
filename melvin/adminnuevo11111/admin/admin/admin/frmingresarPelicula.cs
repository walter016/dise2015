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
    public partial class frmingresarPelicula : Form
    {

        String ora_connect = "server=127.0.0.1; database=taquilla; Uid=root; pwd=;";
        MySqlConnection con = new MySqlConnection();

        public frmingresarPelicula()
        {
            InitializeComponent();
            con.ConnectionString = ora_connect;
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            string query = string.Format("INSERT INTO MAPELICULA (vtitulo, dcosto, ddescuento, vduracion, vsala, vclasificacion, vcategoria, velenco, vdepartamento, vestablecimiento, vidioma, vsubtitulo, ipuntos, vrutaImagen) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')", txttitulo.Text, txtcosto.Text, txtdescuento.Text, txtduracionPelicula.Text, csalasCine.SelectedValue, cclasificacionContenidos.SelectedItem, ccategoriaPelicula.SelectedItem, txtelencoPelicula.Text, cdepartamento.SelectedItem, cestablecimiento.SelectedValue, cidioma.SelectedItem, csubtitulo.SelectedItem, txtpuntosBonificacion.Text, txtrutaImagen.Text = txtrutaImagen.Text.Replace("\\", "\\\\"));
            //string query2 = string.Format("INSERT INTO HORARIO (vhora, dfecha) VALUES('{0}','{1}')", txthorario.Text, dcalendario.Value.Date.ToString("yyyy-MM-dd"));
            try
            {
                clascrearConexion.inserta(query);
                //clascrearConexion.inserta(query2);

                txttitulo.ResetText();
                txtcosto.ResetText();
                txtdescuento.ResetText();
                txtduracionPelicula.ResetText();
                //txthorario.ResetText();
                cclasificacionContenidos.ResetText();
                ccategoriaPelicula.ResetText();
                txtelencoPelicula.ResetText();
                cdepartamento.ResetText();
                cestablecimiento.ResetText();
                cidioma.ResetText();
                csubtitulo.ResetText();
                //cformatoPelicula.ResetText();
                txtpuntosBonificacion.ResetText();
                txtrutaImagen.ResetText();

                MessageBox.Show("Pelicula registrada con Exito");
            }
            catch
            {
                MessageBox.Show("Ocurrió un Error");
            }
        }

        private void bseleccionarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Todos los Archivos de Imagen|*.*";
            BuscarImagen.FileName = "";
            BuscarImagen.Title = "Titulo del Dialogo";
            BuscarImagen.InitialDirectory = "C:\\";
            BuscarImagen.FileName = this.txtrutaImagen.Text;
            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                this.txtrutaImagen.Text = BuscarImagen.FileName; 
                String Direccion = BuscarImagen.FileName; 
                this.pimagenPelicula.ImageLocation = Direccion;
                pimagenPelicula.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void frmingresarPelicula_Load(object sender, EventArgs e)
        {
            con.Open();
            DataSet dsd = new DataSet();
            MySqlDataAdapter sql2 = new MySqlDataAdapter("SELECT VNOMBRE FROM TRSUCURSAL", con);

            sql2.Fill(dsd, "TRSUCURSAL");
            cestablecimiento.DataSource = dsd.Tables[0].DefaultView;
            cestablecimiento.ValueMember = "VNOMBRE";
            cestablecimiento.DisplayMember = "VNOMBRE";


            DataSet dsd1 = new DataSet();
            MySqlDataAdapter sql1 = new MySqlDataAdapter("SELECT DISTINCT VTIPO FROM TRSALA", con);

            sql1.Fill(dsd1, "TRSALA");
            csalasCine.DataSource = dsd1.Tables[0].DefaultView;
            csalasCine.ValueMember = "VTIPO";
            csalasCine.DisplayMember = "VTIPO";
        }
    }
}
