﻿using System;
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

namespace WindowsFormsApplication1
{
    public partial class cartelera : Form
    {
        String numero = null;
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
            frmInformacion info = new frmInformacion();
            info.pictureBox1.Image = Properties.Resources.El_Destino_de_Júpite;
            info.pictureBox1.Refresh();
            info.Show();          
            this.WindowState = FormWindowState.Minimized;
        }

        private void cartelera_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void cartelera_Load(object sender, EventArgs e)
        {
            //frmCiudad ciudad = new frmCiudad();
            String numeroSucursal = lblsucursal.Text;

            string query = string.Format("select TRHORA.idSucursal,MAPELI.iidpelicula, MAPELI.bimagen FROM TRHORARIO TRHORA, MAPELICULA MAPELI WHERE TRHORA.iidpelicula=MAPELI.iidpelicula and TRHORA.idSucursal = '"+ numeroSucursal +"'");
            MySqlCommand comando = new MySqlCommand(query, classCrearConexion.Conexion());
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataSet ds = new DataSet("MAPELICULA");
            da.Fill(ds, "MAPELICULA");
            byte[] datos = new byte[0];
            DataRow dr = ds.Tables["MAPELICULA"].Rows[0];
            datos = (byte[])dr["bimagen"];
            System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
            pb1.Image = System.Drawing.Bitmap.FromStream(ms);
            /*pb1.Image = Properties.Resources.El_Destino_de_Júpite;
            pb1.Refresh();
            pb2.Image = Properties.Resources.FF2;
            pb2.Refresh();
            pb3.Image = Properties.Resources.In_to_the_Woods_En_el_Bosqu;
            pb3.Refresh();
            pb4.Image = Properties.Resources.Ombis_Alien_Invasion__2015_;
            pb4.Refresh();
            pb5.Image = Properties.Resources.peliculas_2015_15_e1422754101215;
            pb5.Refresh();
            pb6.Image = Properties.Resources.peliculas_2015_rapido_furioso_4;
            pb6.Refresh();
            pb7.Image = Properties.Resources.images;
            pb7.Refresh();*/

        }

        private void pb2_Click(object sender, EventArgs e)
        {
            frmInformacion info = new frmInformacion();
            info.pictureBox1.Image = Properties.Resources.FF2;
            info.pictureBox1.Refresh();
            info.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            frmInformacion info = new frmInformacion();
            info.pictureBox1.Image = Properties.Resources.In_to_the_Woods_En_el_Bosqu;
            info.pictureBox1.Refresh();
            info.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            frmInformacion info = new frmInformacion();
            info.pictureBox1.Image = Properties.Resources.Ombis_Alien_Invasion__2015_;
            info.pictureBox1.Refresh();
            info.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            frmInformacion info = new frmInformacion();
            info.pictureBox1.Image = Properties.Resources.peliculas_2015_15_e1422754101215;
            info.pictureBox1.Refresh();
            info.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            frmInformacion info = new frmInformacion();
            info.pictureBox1.Image = Properties.Resources.peliculas_2015_rapido_furioso_4;
            info.pictureBox1.Refresh();
            info.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            frmInformacion info = new frmInformacion();
            info.pictureBox1.Image = Properties.Resources.images;
            info.pictureBox1.Refresh();
            info.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            frmInformacion info = new frmInformacion();

            info.Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
