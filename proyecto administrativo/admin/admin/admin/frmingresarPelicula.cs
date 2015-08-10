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
        MySqlConnection con = new MySqlConnection("server=localhost; database=taquilla; Uid=root; pwd=;");
        System.IO.MemoryStream ms = new System.IO.MemoryStream();

        public frmingresarPelicula()
        {
            InitializeComponent();
            //con.ConnectionString = ora_connect;
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
         
            //string query2 = string.Format("INSERT INTO HORARIO (vhora, dfecha) VALUES('{0}','{1}')", txthorario.Text, dcalendario.Value.Date.ToString("yyyy-MM-dd"));
            try
            {
                pimagenPelicula.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                string query = string.Format("INSERT INTO pelicula (`vtitulo`, `dcosto`, `ddescuento`, `vduracion`, `vclasificacion`, `vcategoria`, `velenco`, `vdepartamento`, `vestablecimiento`, `vidioma`, `vsubtitulo`, `vformato`, `ipuntos`, `bimagen`) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')", txttitulo.Text, txtcosto.Text, txtdescuento.Text, txtduracionPelicula.Text, csalasCine.SelectedValue, cclasificacionContenidos.SelectedItem, ccategoriaPelicula.SelectedItem, txtelencoPelicula.Text, cdepartamento.SelectedItem, cestablecimiento.SelectedValue, cidioma.SelectedItem, csubtitulo.SelectedItem, txtpuntosBonificacion.Text, ms.GetBuffer());
   
                clascrearConexion.inserta(query);
                MessageBox.Show("Pelicula registrada con Exito "+query);
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
        {/*
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
            csalasCine.DisplayMember = "VTIPO";*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string updatePeli = ("UPDATE MAPELICULA set vtitulo = '" + txttitulo.Text + "', dcosto = '" + txtcosto.Text + "', ddescuento = '" + txtdescuento.Text + "', vduracion = '" + txtduracionPelicula.Text + "', vsala = '" + csalasCine.Text + "', vclasificacion = '" + cclasificacionContenidos.Text + "', vcategoria = '" + ccategoriaPelicula.Text + "', velenco = '" + txtelencoPelicula.Text + "', vdepartamento = '" + cdepartamento.Text + "', vestablecimiento = '" + cestablecimiento.Text + "', vidioma = '" + cidioma.Text + "', vsubtitulo = '" + csubtitulo.Text + "', ipuntos = '" + txtpuntosBonificacion.Text + "' where iidpelicula ='" + txtidPelicula.Text + "'");
            clascrearConexion.inserta(updatePeli);
            MessageBox.Show("La pelicula " + txttitulo.Text + " se actualizo correctamente");
            txttitulo.ResetText();
            txtcosto.ResetText();
            txtdescuento.ResetText();
            txtduracionPelicula.ResetText();
            csalasCine.ResetText();
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
        }

        private void beliminar_Click(object sender, EventArgs e)
        {
            try
                {

                    String delete = "Delete from MAPELICULA WHERE IIDPELICULA ='" + txtidPelicula.Text + "'";
                    clascrearConexion.inserta(delete);
                    MessageBox.Show("La pelicula " + txttitulo.Text + " se eliminó correctamente");
                    txttitulo.ResetText();
                    txtcosto.ResetText();
                    txtdescuento.ResetText();
                    txtduracionPelicula.ResetText();
                    csalasCine.ResetText();
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
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo encontrar el registro" + ex.Message);
                }
                finally
                {
                    clascrearConexion.ObtenerConexion().Close();
                }
        
        }

        private void bcancelar_Click(object sender, EventArgs e)
        {
            txttitulo.ResetText();
            txtcosto.ResetText();
            txtdescuento.ResetText();
            txtduracionPelicula.ResetText();
            csalasCine.ResetText();
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
            beditar.Enabled = false;
            beliminar.Enabled = false;
            bguardar.Enabled = true;

        }
    }
}
