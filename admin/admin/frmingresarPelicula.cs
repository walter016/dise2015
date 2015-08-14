﻿//Diseño: José Wilfredo Chacón Cartagena
//Fecha de asignación: 05/08/2015
//Fecha de entrega: 05/08/2015

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
        public frmingresarPelicula()
        {
            InitializeComponent();
            //con.ConnectionString = ora_connect;

            //el combobox se llena con los datos que trae de las tablas el datatable
            csalasCine.DataSource = salasCine();
            cdepartamento.DataSource = departamento();
            cestablecimiento.DataSource = esablecimiento();
        }

        //Programador y Analista: José Wilfredo Chacon Cartagena
        //La siguiente función se utiliza para poder obtener el id y el tipo de sala para luego poder cargarlo a un combobox
        //Fecha de asignación: 10/08/2015
        //Fecha de entrega: 10/08/2015
        public DataTable salasCine()
        {
            DataTable dt = new DataTable();
            string query = "SELECT DISTINCT vtipo FROM TRSALA;";
            MySqlCommand comando = new MySqlCommand(query, clascrearConexion.Conexion());
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            csalasCine.DisplayMember = "vtipo";
            csalasCine.ValueMember = "vtipo";
            da.Fill(dt);
            clascrearConexion.Conexion().Close();
            return dt;
        }

        //Programador y Analista: José Wilfredo Chacon Cartagena
        //La siguiente función se utiliza para poder obtener el id y el departamento para luego poder cargarlo a un combobox
        //Fecha de asignación: 10/08/2015
        //Fecha de entrega: 10/08/2015
        public DataTable departamento()
        {
            DataTable dt = new DataTable();
            string query = "SELECT vnombreCiudad FROM MACIUDAD;";
            MySqlCommand comando = new MySqlCommand(query, clascrearConexion.Conexion());
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            cdepartamento.DisplayMember = "vnombreCiudad";
            cdepartamento.ValueMember = "vnombreCiudad";
            da.Fill(dt);
            clascrearConexion.Conexion().Close();
            return dt;
        }

        //Programador y Analista: José Wilfredo Chacon Cartagena
        //La siguiente función se utiliza para poder obtener el id y el nombre de la ubicacion del cine para luego poder cargarlo a un combobox
        //Fecha de asignación: 10/08/2015
        //Fecha de entrega: 10/08/2015
        public DataTable esablecimiento()
        {
            DataTable dt = new DataTable();
            string query = "SELECT vnombre FROM MASUCURSAL;";
            MySqlCommand comando = new MySqlCommand(query, clascrearConexion.Conexion());
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            cestablecimiento.DisplayMember = "vnombre";
            cestablecimiento.ValueMember = "vnombre";
            da.Fill(dt);
            clascrearConexion.Conexion().Close();
            return dt;
        }

        //Programador y Analista: José Wilfredo Chacon Cartagena
        //La siguiente función se utiliza para poder insertar los datos ingresados de la pelicula dentro de la base de datos
        //Fecha de asignación: 03/08/2015
        //Fecha de entrega: 03/08/2015
        private void bguardar_Click(object sender, EventArgs e)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            try
            {
                pimagenPelicula.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                string query = string.Format("INSERT INTO MAPELICULA (`vtitulo`, `dcosto`, `ddescuento`, `vduracion`, `vtipoSala`, `vclasificacion`, `vcategoria`, `velenco`, `vdepartamento`, `vestablecimiento`, `vidioma`, `vsubtitulo`, `ipuntos`, `bimagen`) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')", txttitulo.Text, txtcosto.Text, txtdescuento.Text, txtduracionPelicula.Text, csalasCine.SelectedValue, cclasificacionContenidos.SelectedItem, ccategoriaPelicula.SelectedItem, txtelencoPelicula.Text, cdepartamento.SelectedValue, cestablecimiento.SelectedValue, cidioma.SelectedItem, csubtitulo.SelectedItem, txtpuntosBonificacion.Text, ms.GetBuffer());
                clascrearConexion.inserta(query);
                MessageBox.Show("Pelicula registrada con Exito ");
                txttitulo.ResetText();
                txtcosto.ResetText();
                txtdescuento.ResetText();
                txtduracionPelicula.ResetText();
                csalasCine.ResetText();
                cclasificacionContenidos.ResetText();
                ccategoriaPelicula.ResetText();
                txtelencoPelicula.ResetText();
                cdepartamento.ResetText();
                cestablecimiento.ResetText();
                cidioma.ResetText();
                csubtitulo.ResetText();
                txtpuntosBonificacion.ResetText();
                txtrutaImagen.ResetText();
                pimagenPelicula.ResetText();
            }
            catch
            {
                MessageBox.Show("Ocurrió un Error");
            }
        }

        //Programador y Analista: José Wilfredo Chacon Cartagena
        //La siguiente función se utiliza para obtener la ruta en donde está localizada la imagen y cargar esa ruta a un textbox para luego poder guardar esa ruta en la base de datos
        //Fecha de asignación: 03/08/2015
        //Fecha de entrega: 03/08/2015
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
            cclasificacionContenidos.ResetText();
            ccategoriaPelicula.ResetText();
            txtelencoPelicula.ResetText();
            cdepartamento.ResetText();
            cestablecimiento.ResetText();
            cidioma.ResetText();
            csubtitulo.ResetText();
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
                cclasificacionContenidos.ResetText();
                ccategoriaPelicula.ResetText();
                txtelencoPelicula.ResetText();
                cdepartamento.ResetText();
                cestablecimiento.ResetText();
                cidioma.ResetText();
                csubtitulo.ResetText();
                txtpuntosBonificacion.ResetText();
                txtrutaImagen.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontrar el registro" + ex.Message);
            }
            finally
            {
                clascrearConexion.Conexion().Close();
            }

        }

        private void bcancelar_Click(object sender, EventArgs e)
        {
            txttitulo.ResetText();
            txtcosto.ResetText();
            txtdescuento.ResetText();
            txtduracionPelicula.ResetText();
            csalasCine.ResetText();
            cclasificacionContenidos.ResetText();
            ccategoriaPelicula.ResetText();
            txtelencoPelicula.ResetText();
            cdepartamento.ResetText();
            cestablecimiento.ResetText();
            cidioma.ResetText();
            csubtitulo.ResetText();
            txtpuntosBonificacion.ResetText();
            txtrutaImagen.ResetText();
            beditar.Enabled = false;
            beliminar.Enabled = false;
            bguardar.Enabled = true;

        }
    }
}