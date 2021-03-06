﻿//Diseño: José Wilfredo Chacón Cartagena
//Fecha de asignación: 05/08/2015
//Fecha de entrega: 05/08/2015
//La función del siguiente formulario es la de poder ingresar registros de peliculas a la base de datos, las fuciones que
//se pueden encontrar en el formulario son las siguientes: guardar, editar, eliminar y seleccionar imagen de la pelicula

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
using System.IO;

namespace admin
{
    public partial class frmingresarPelicula : Form
    {
        public frmingresarPelicula()
        {
            InitializeComponent();
           

            //el combobox se llena con los datos que trae de las tablas el datatable
            csalasCine.DataSource = salasCine();
           
        }

        //Programador y Analista: José Wilfredo Chacon Cartagena
        //La siguiente función se utiliza para poder obtener el id y el tipo de sala para luego poder cargarlo a un combobox
        //Fecha de asignación: 10/08/2015
        //Fecha de entrega: 10/08/2015
        public DataTable salasCine()
        {
            DataTable dt = new DataTable();
            string query = "SELECT vtipoSala FROM MATIPOSALA;";
            MySqlCommand comando = new MySqlCommand(query, classCrearConexion.obtenerConexion());
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            csalasCine.DisplayMember = "vtipoSala";
            csalasCine.ValueMember = "iidTipo";
            da.Fill(dt);
            classCrearConexion.obtenerConexion().Close();
            return dt;
        }

       
       

        

        //Programador y Analista: José Wilfredo Chacon Cartagena
        //La siguiente función se utiliza para poder insertar los datos ingresados de la pelicula dentro de la base de datos
        //Fecha de asignación: 03/08/2015
        //Fecha de entrega: 03/08/2015
        private void bguardar_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrEmpty(txttitulo.Text) || String.IsNullOrEmpty(txtcosto.Text) || String.IsNullOrEmpty(txtdescuento.Text) || String.IsNullOrEmpty(csalasCine.Text) || String.IsNullOrEmpty(cclasificacionContenidos.Text) || String.IsNullOrEmpty(ccategoriaPelicula.Text) || String.IsNullOrEmpty(txtelencoPelicula.Text) || String.IsNullOrEmpty(cidioma.Text) || String.IsNullOrEmpty(csubtitulo.Text) || String.IsNullOrEmpty(txtpuntosBonificacion.Text))
            {
                MessageBox.Show("Debe completar todos los campos"); 
            }
            else
            {
                try
                {
                    string sdireccion = this.txtrutaImagen.Text;
                    MySqlCommand cmd = new MySqlCommand();
                    int iFileSize;
                    byte[] brawData;
                    FileStream fs;
                    try
                    {
                        fs = new FileStream(sdireccion, FileMode.Open, FileAccess.Read);
                        iFileSize = Convert.ToInt32(fs.Length);

                        brawData = new byte[iFileSize];
                        fs.Read(brawData, 0, iFileSize);
                        fs.Close();

                        string query = string.Format("INSERT INTO MAPELICULA (`vtitulo`, `dcosto`, `ddescuento`, `vtipoSala`, `vclasificacion`, `vcategoria`, `velenco`, `vidioma`, `vsubtitulo`, `ipuntos`, `bimagen`) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}',@FILE)", txttitulo.Text, txtcosto.Text, txtdescuento.Text, csalasCine.SelectedValue, cclasificacionContenidos.SelectedItem, ccategoriaPelicula.SelectedItem, txtelencoPelicula.Text, cidioma.SelectedItem, csubtitulo.SelectedItem, txtpuntosBonificacion.Text);


                        cmd.Connection = dllConexion.dllConexion.Conexion();
                        cmd.CommandText = query;

                        cmd.Parameters.AddWithValue("@File", brawData);

                        cmd.ExecuteNonQuery();
                        //Ingreso de cuidad en laa bitacora
                        claseEmp.Bita(claseEmp.MyUserName, 2, "MAPELICULA");

                        MessageBox.Show("Pelicula registrada con Exito ");
                        txttitulo.ResetText();
                        txtcosto.ResetText();
                        txtdescuento.ResetText();
                        csalasCine.ResetText();
                        cclasificacionContenidos.ResetText();
                        ccategoriaPelicula.ResetText();
                        txtelencoPelicula.ResetText();
                        cidioma.ResetText();
                        csubtitulo.ResetText();
                        txtpuntosBonificacion.ResetText();
                        txtrutaImagen.ResetText();
                        pimagenPelicula.Image = null;

                    }
                    catch
                    {
                        MessageBox.Show("Ocurrió un Error");
                    }
                }
                catch 
                {
                    MessageBox.Show("Ocurrió un Error");
                }
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
            MemoryStream ms = new MemoryStream();
            MySqlCommand cmd = new MySqlCommand();
            pimagenPelicula.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);


            string updatePeli = ("UPDATE MAPELICULA set vtitulo = '" + txttitulo.Text + "', dcosto = '" + txtcosto.Text + "', ddescuento = '" + txtdescuento.Text + "', vtipoSala = '" + csalasCine.Text + "', vclasificacion = '" + cclasificacionContenidos.Text + "', vcategoria = '" + ccategoriaPelicula.Text + "', velenco = '" + txtelencoPelicula.Text + "', vidioma = '" + cidioma.Text + "', vsubtitulo = '" + csubtitulo.Text + "', ipuntos = '" + txtpuntosBonificacion.Text + "', bimagen = @FILE where iidpelicula ='" + txtidPelicula.Text + "'");
            cmd.Connection = dllConexion.dllConexion.Conexion();
            cmd.CommandText = updatePeli;

            cmd.Parameters.AddWithValue("@File", ms.GetBuffer());

            cmd.ExecuteNonQuery();
            MessageBox.Show("La pelicula " + txttitulo.Text + " se actualizo correctamente");
            txttitulo.ResetText();
            txtcosto.ResetText();
            txtdescuento.ResetText();
            csalasCine.ResetText();
            cclasificacionContenidos.ResetText();
            ccategoriaPelicula.ResetText();
            txtelencoPelicula.ResetText();
            cidioma.ResetText();
            csubtitulo.ResetText();
            txtpuntosBonificacion.ResetText();
            txtrutaImagen.ResetText();
            pimagenPelicula.Image = null;
        }

        private void beliminar_Click(object sender, EventArgs e)
        {
            try
            {

                String delete = "Delete from MAPELICULA WHERE IIDPELICULA ='" + txtidPelicula.Text + "'";
                dllConexion.dllConexion.inserta(delete);
                MessageBox.Show("La pelicula " + txttitulo.Text + " se eliminó correctamente");
                txttitulo.ResetText();
                txtcosto.ResetText();
                txtdescuento.ResetText();
                csalasCine.ResetText();
                cclasificacionContenidos.ResetText();
                ccategoriaPelicula.ResetText();
                txtelencoPelicula.ResetText();
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
                dllConexion.dllConexion.Conexion().Close();
            }

        }

        private void bcancelar_Click(object sender, EventArgs e)
        {
            txttitulo.ResetText();
            txtcosto.ResetText();
            txtdescuento.ResetText();
            csalasCine.ResetText();
            cclasificacionContenidos.ResetText();
            ccategoriaPelicula.ResetText();
            txtelencoPelicula.ResetText();
            cidioma.ResetText();
            csubtitulo.ResetText();
            txtpuntosBonificacion.ResetText();
            txtrutaImagen.ResetText();
            beditar.Enabled = false;
            beliminar.Enabled = false;
            bguardar.Enabled = true;

        }

        private void txtcosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }
            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtcosto.Text.Length; i++)
            {
                if (txtcosto.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }
            }
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true; 
        }

        private void txtdescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }
            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtdescuento.Text.Length; i++)
            {
                if (txtdescuento.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }
            }
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true; 
        }


    }
}