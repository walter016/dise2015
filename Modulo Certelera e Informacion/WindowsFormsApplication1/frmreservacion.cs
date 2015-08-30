using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class frmreservacion : Form
    {
        private int asientoninios = 0;
        private int asientoadulto = 0;
        public frmreservacion()
        {
            InitializeComponent();
        }

        
        private void pbimagencompra2_MouseLeave(object sender, EventArgs e)
        {
            pbimagenCompra.Show();
            pbimagencompra2.Hide();
        }

        private void pbimagenCompra_MouseEnter(object sender, EventArgs e)
        {
            pbimagenCompra.Hide();
            pbimagencompra2.Show();
            pbimagenCompra.Cursor = Cursors.Hand;
            pbimagencompra2.Cursor = Cursors.Hand;
        }

       

        

        private void frmreservacion_Load(object sender, EventArgs e)
        {
           

            try
            {
                // se ejecuta la consulta para mostrar la informacion de la pelicula
                string sql = "SELECT mapelicula.vtitulo, mapelicula.dcosto,trhorario.inumerosala, trhorario.vtipoSala, mapelicula.vclasificacion, mapelicula.vcategoria,mapelicula.velenco,mapelicula.vidioma,mapelicula.vsubtitulo,CONCAT(thorainicio,'         -             ',thorafinal) AS Hora ,mapelicula.bimagen FROM mapelicula" +
                " INNER JOIN trhorario ON mapelicula.iidpelicula = trhorario.iidPelicula WHERE  trhorario.iidHorario= '"+claseEmp.idschedule+"'";
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
                    string TipoSala = dr["vtipoSala"].ToString();
                    string ClasificacionSala = dr["vclasificacion"].ToString();
                    string CategPeli = dr["vcategoria"].ToString();
                    string ElencoPeli = dr["velenco"].ToString();
                    string IdiomaPeli = dr["vidioma"].ToString();
                    string SubtituloPeli = dr["vsubtitulo"].ToString();
                    string NumeroSala = dr["inumerosala"].ToString();
                    string HorarioPeli = dr["Hora"].ToString();



                    //asigna los datos para mostrarlos en pantalla
                    lblclasificacionPeli.Text = ClasificacionSala;
                    lblsalaPeli.Text = NumeroSala;
                    lbltituloPeli.Text = TituloPeli;
                    //costo boletos
                    lblcostoNinio.Text = CostoPeli;
                    lblcostoAdulto.Text = CostoPeli;

                    lblcategoriaPeli.Text = CategPeli;   
                    lblidiomaPeli.Text = IdiomaPeli;
                    lblsubtituloPeli.Text = SubtituloPeli;
                    lblhorarioPeli.Text = HorarioPeli;
                    lbltipoSalaPeli.Text = TipoSala;
                   
                    

                    datos = (byte[])dr["bimagen"];
                    //dibuja los picture box con sus  propiedades 
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                    PBpelicula.Image = System.Drawing.Bitmap.FromStream(ms);


                }




            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }


           

        }

        private void pbimagenMas1_MouseEnter(object sender, EventArgs e)
        {
            pbimagenMas1.Hide();
            pbimagenMas2.Show();
            pbimagenMas1.Cursor = Cursors.Hand;
            pbimagenMas2.Cursor = Cursors.Hand;
        }

        private void pbimagenMas2_MouseLeave(object sender, EventArgs e)
        {
            pbimagenMas1.Show();
            pbimagenMas2.Hide();
        }

        

       

        private void belegirAciento_Click(object sender, EventArgs e)
        {
            switch (lbltipoSalaPeli.Text) 
            
            {
                case "3D":
                    frmSala3D from = new frmSala3D();
                    from.iasientos = Convert.ToInt32(lblcantidadNinios.Text);
                    from.Show();
                    break;
                case "4D":
                    frmSala4D form4d = new frmSala4D();
                    form4d.iasientos = Convert.ToInt32(lblcantidadNinios.Text);
                    form4d.Show();
                    break;
                case "IMAX":
                    frmSalaIMAX formimax = new frmSalaIMAX();
                    formimax.iasientos = Convert.ToInt32(lblcantidadNinios.Text);
                    formimax.Show();
                    break;
            }

        }

        

        private void pbimagencompra2_MouseClick(object sender, MouseEventArgs e)
        {

            asientoninios = asientoninios + 1;

            lblcantidadNinios.Text = asientoninios.ToString();

         

            if (lblcantidadNinios.Text == "0" )
            {
                pbmenosHabilitado.Visible = false;
                pbmenosCompra2.Visible = false;
                pbmenosCompra.Visible = true;
                belegirAciento.Enabled = false;
                
            }
            else 
            {
                pbmenosHabilitado.Visible = true;
                pbmenosCompra2.Visible = true;
                pbmenosCompra.Visible = false;
                

            }

            if (pbmenosHabilitado.Visible == true || pbmenosHabilitado2.Visible == true)
            {
                belegirAciento.Enabled = true;
            }
            else
            {
                belegirAciento.Enabled = false;
            }
            
           

           
        }

        

       

        private void pbmenosHabilitado_MouseEnter(object sender, EventArgs e)
        {
            pbmenosHabilitado.Hide();
            pbmenosCompra2.Show();
            pbmenosHabilitado.Cursor = Cursors.Hand;
            pbmenosCompra2.Cursor = Cursors.Hand;
        }

        private void pbmenosCompra2_MouseClick(object sender, MouseEventArgs e)
        {
            asientoninios = asientoninios - 1;

            lblcantidadNinios.Text = asientoninios.ToString();
           
            if (lblcantidadNinios.Text == "0" )
            {
                pbmenosHabilitado.Visible = false;
                pbmenosCompra2.Visible = false;
                pbmenosCompra.Visible = true;
                belegirAciento.Enabled = false;
               
                
            }
            else
            {
                pbmenosHabilitado.Visible = true;
                pbmenosCompra2.Visible = true;
                pbmenosCompra.Visible = false;
                
                

            }

            if (pbmenosHabilitado.Visible == true || pbmenosHabilitado2.Visible == true )
            {
                belegirAciento.Enabled = true;
            }else
            {
                belegirAciento.Enabled = false;
            }

          
        }
     
        private void pbimagenMas2_MouseClick(object sender, MouseEventArgs e)
        {
            asientoadulto = asientoadulto + 1;
            lblcantidadAdulto.Text = asientoadulto.ToString();
            if (lblcantidadAdulto.Text == "0" )
            {
                pbimagenMenos2.Visible = false;
                pbmenosHabilitado2.Visible = false;
                pbimagenMenos1.Visible = true;
                belegirAciento.Enabled = false;
                

            }
            else
            {
                pbimagenMenos2.Visible = true;
                pbmenosHabilitado2.Visible = true;
                pbimagenMenos1.Visible = false;
                
               
            }
            if (pbmenosHabilitado.Visible == true || pbmenosHabilitado2.Visible == true)
            {
                belegirAciento.Enabled = true;
            }
            else
            {
                belegirAciento.Enabled = false;
            }

          
        }


        private void pbimagenMenos2_MouseClick(object sender, MouseEventArgs e)
        {
            asientoadulto = asientoadulto - 1;
            lblcantidadAdulto.Text = asientoadulto.ToString();
            if (lblcantidadAdulto.Text == "0" )
            {
                pbimagenMenos2.Visible = false;
                pbmenosHabilitado2.Visible = false;
                pbimagenMenos1.Visible = true;

                belegirAciento.Enabled = false;
               

            }
            else
            {
                pbimagenMenos2.Visible = true;
                pbmenosHabilitado2.Visible = true;
                pbimagenMenos1.Visible = false;
                
                
                
            }


            if (pbmenosHabilitado.Visible == true || pbmenosHabilitado2.Visible == true )
            {
                belegirAciento.Enabled = true;
            }
            else
            {
                belegirAciento.Enabled = false;
            }
           
        }

        private void pbmenosHabilitado2_MouseEnter(object sender, EventArgs e)
        {
            pbimagenMenos2.Show();
            pbmenosHabilitado2.Hide();
            pbimagenMenos2.Cursor = Cursors.Hand;
            pbmenosHabilitado2.Cursor = Cursors.Hand;
        }

        private void pbimagenMenos2_MouseLeave(object sender, EventArgs e)
        {
            pbimagenMenos2.Hide();
            pbmenosHabilitado2.Show();
            pbimagenMenos2.Cursor = Cursors.Hand;
            pbmenosHabilitado2.Cursor = Cursors.Hand;
        }

        private void lblcantidadNinios_TextChanged(object sender, EventArgs e)
        {
            Decimal resultadoninio = 0;

            int cantboletoninio = asientoninios;
            Decimal costoboletoninio = Convert.ToDecimal(lblcostoNinio.Text);

            resultadoninio = asientoninios * costoboletoninio;
            lblsubTotalNinio.Text = resultadoninio.ToString();

           

            

        }

        private void lblcantidadAdulto_TextChanged(object sender, EventArgs e)
        {
            Decimal resultadoAdulto = 0;

            int cantboletoAdulto = asientoadulto;
            Decimal costoboletoadulto = Convert.ToDecimal(lblcostoAdulto.Text);

            resultadoAdulto = asientoadulto * costoboletoadulto;
            lblsubtotalAdulto.Text = resultadoAdulto.ToString();

          
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmInformacion);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                frm.WindowState = FormWindowState.Maximized;
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frmInformacion();
            frm.Show();
        }

        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is cartelera);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                frm.WindowState = FormWindowState.Maximized;
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new cartelera();
            frm.Show();
           
           
            
        }
    }
}
