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

namespace admin
{
    public partial class frmingresarHorario : Form
    {
        public frmingresarHorario()
        {
            InitializeComponent();
            cnombrePelicula.DataSource = nombrePelicula();
            csucursal.DataSource = nombreSucursal();
            cnoSala.DataSource = numeroSala();

        }


        public DataTable nombrePelicula()
        {
            DataTable dt = new DataTable();
            string query = "SELECT iidpelicula,vtitulo from MAPELICULA;";
            MySqlCommand comando = new MySqlCommand(query, dllConexion.dllConexion.Conexion());
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            cnombrePelicula.DisplayMember = "vtitulo";
            cnombrePelicula.ValueMember = "iidpelicula";
            da.Fill(dt);
            dllConexion.dllConexion.Conexion().Close();
            return dt;
        }

        public DataTable nombreSucursal()
        {
            DataTable dt = new DataTable();
            string query = "SELECT iidsucursal,vnombre from MASUCURSAL;";
            MySqlCommand comando = new MySqlCommand(query, dllConexion.dllConexion.Conexion());
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            csucursal.DisplayMember = "vnombre";
            csucursal.ValueMember = "iidsucursal";
            da.Fill(dt);
            dllConexion.dllConexion.Conexion().Close();
            return dt;
        }

        public DataTable numeroSala()
        {
            DataTable dt = new DataTable();
            string query = "SELECT iidsala from TRSALA;";
            MySqlCommand comando = new MySqlCommand(query, dllConexion.dllConexion.Conexion());
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            cnoSala.DisplayMember = "iidsala";
            cnoSala.ValueMember = "iidsala";
            da.Fill(dt);
            dllConexion.dllConexion.Conexion().Close();
            return dt;
        }

        


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmingresarHorario_Load(object sender, EventArgs e)
        {
            string nopeli;
            string snombrepeli;
            string snombresucursal;
            string snumerosala;
            string stiposala;
            string sfecha;
            string sestadopeli;
            string shorainicio;
            string shorafinal;
            string sqlb = "SELECT trhora.iidHorario as 'No.',mapeli.vtitulo AS 'Nombre Pelicula',masoc.vnombre AS 'Nombre Sucursal',trhora.inumerosala AS 'Numero Sala',trhora.vtiposala AS 'Tipo Sala',trhora.dfecha as 'Fecha',trhora.vestado AS 'Estado Pelicula',trhora.thorainicio as 'Hora Inicio',trhora.thorafinal as 'Hora Final' From MAPELICULA mapeli, MASUCURSAL masoc, TRHORARIO trhora WHERE mapeli.iidpelicula = trhora.iidpelicula AND masoc.iidsucursal=trhora.idSucursal";
            MySqlCommand cmdl = new MySqlCommand(sqlb, dllConexion.dllConexion.Conexion());

            MySqlDataReader reader = cmdl.ExecuteReader();

            DataTable horario = new DataTable();    
           //Creacion de objeto de una tabla auxiliar para sustituir por la tabla real
            horario.Columns.Add("No.", typeof(string));
            horario.Columns.Add("Nombre Pelicula", typeof(string));
            horario.Columns.Add("Nombre Sucursal", typeof(string));
            horario.Columns.Add("Numero Sala", typeof(string));
            horario.Columns.Add("Tipo Sala", typeof(string));
            horario.Columns.Add("Fecha", typeof(DateTime));
            horario.Columns.Add("Estado Pelicula", typeof(string));
            horario.Columns.Add("Hora Inicio", typeof(string));
            horario.Columns.Add("Hora Final", typeof(string));



            //horario.Rows.Clear();                              //Limpia datos de la Tabla
            while (reader.Read())
            {
                nopeli = reader.GetString(0).ToString();
                snombrepeli = reader.GetString(1).ToString();
                snombresucursal = reader.GetString(2).ToString();
                snumerosala = reader.GetString(3).ToString();
                stiposala = reader.GetString(4).ToString();
                sfecha = reader.GetString(5).ToString();
                sestadopeli = reader.GetString(6).ToString();
                shorainicio = reader.GetString(7).ToString();
                shorafinal = reader.GetString(8).ToString();


                horario.Rows.Add(nopeli,snombrepeli, snombresucursal, snumerosala, stiposala, sfecha, sestadopeli, shorainicio, shorafinal);




            }
            dgvinfoPeliculas.DataSource = horario;
        }

        private void refrescarhorario()
        {
            string nopeli;
            string snombrepeli;
            string snombresucursal;
            string snumerosala;
            string stiposala;
            string sfecha;
            string sestadopeli;
            string shorainicio;
            string shorafinal;
            string sqlb = "SELECT trhora.iidHorario as 'No.',mapeli.vtitulo AS 'Nombre Pelicula',masoc.vnombre AS 'Nombre Sucursal',trhora.inumerosala AS 'Numero Sala',trhora.vtiposala AS 'Tipo Sala',trhora.dfecha as 'Fecha',trhora.vestado AS 'Estado Pelicula',trhora.thorainicio as 'Hora Inicio',trhora.thorafinal as 'Hora Final' From MAPELICULA mapeli, MASUCURSAL masoc, TRHORARIO trhora WHERE mapeli.iidpelicula = trhora.iidpelicula AND masoc.iidsucursal=trhora.idSucursal";
            MySqlCommand cmdl = new MySqlCommand(sqlb, dllConexion.dllConexion.Conexion());

            MySqlDataReader reader = cmdl.ExecuteReader();

            DataTable horario = new DataTable();
            //Creacion de objeto de una tabla auxiliar para sustituir por la tabla real
            horario.Columns.Add("No.", typeof(string));
            horario.Columns.Add("Nombre Pelicula", typeof(string));
            horario.Columns.Add("Nombre Sucursal", typeof(string));
            horario.Columns.Add("Numero Sala", typeof(string));
            horario.Columns.Add("Tipo Sala", typeof(string));
            horario.Columns.Add("Fecha", typeof(DateTime));
            horario.Columns.Add("Estado Pelicula", typeof(string));
            horario.Columns.Add("Hora Inicio", typeof(string));
            horario.Columns.Add("Hora Final", typeof(string));



            //horario.Rows.Clear();                              //Limpia datos de la Tabla
            while (reader.Read())
            {
                nopeli = reader.GetString(0).ToString();
                snombrepeli = reader.GetString(1).ToString();
                snombresucursal = reader.GetString(2).ToString();
                snumerosala = reader.GetString(3).ToString();
                stiposala = reader.GetString(4).ToString();
                sfecha = reader.GetString(5).ToString();
                sestadopeli = reader.GetString(6).ToString();
                shorainicio = reader.GetString(7).ToString();
                shorafinal = reader.GetString(8).ToString();


                horario.Rows.Add(nopeli, snombrepeli, snombresucursal, snumerosala, stiposala, sfecha, sestadopeli, shorainicio, shorafinal);




            }
            dgvinfoPeliculas.DataSource = horario;
        }


        private void cnoSala_TextChanged(object sender, EventArgs e)
        {
            string query = "select iidsala,vtipo from TRSALA where iidsala ='" + cnoSala.Text + "';";

            MySqlCommand cmd = new MySqlCommand(query, dllConexion.dllConexion.Conexion());
            MySqlDataReader myreader;

            try
            {
                
                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    string tiposala = myreader.GetString("vtipo").ToString();
                    txttipoSala.Text = tiposala;
                    
                }
            }
            catch (MySqlException ex)
            {
            }
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            

            if (String.IsNullOrEmpty(cestadopeli.Text) || String.IsNullOrEmpty(chorarioPelicula.Text)) 
            {
                MessageBox.Show("Debe ingresar estado o horario de pelicula");
            }
            else
            {
                // comprueba si la pelicua ya esta asignada en una sala y hora 
                string snombrepeli;
                string snombresucursal;
                string snumerosala;
                string stiposala;
                string sfecha;
                string sestadopeli;
                string shorainicio;
                string shorafinal;
                string[] str;
                str = chorarioPelicula.Text.Split(' ', '-', 'P', 'M');
                string horainicio = str[0];
                string horafinal = str[6];
                string sqlb = "SELECT mapeli.vtitulo AS 'Nombre Pelicula',masoc.vnombre AS 'Nombre Sucursal',trhora.inumerosala AS 'Numero Sala',trhora.vtiposala AS 'Tipo Sala',trhora.dfecha as 'Fecha',trhora.vestado AS 'Estado Pelicula',trhora.thorainicio as 'Hora Inicio',trhora.thorafinal as 'Hora Final' From MAPELICULA mapeli, MASUCURSAL masoc, TRHORARIO trhora WHERE mapeli.iidpelicula = trhora.iidpelicula AND masoc.iidsucursal=trhora.idSucursal AND trhora.inumerosala='" + cnoSala.Text + "' AND trhora.thorainicio ='" + horainicio + "'AND trhora.thorafinal ='" + horafinal + "'";
                MySqlCommand cmdl = new MySqlCommand(sqlb, dllConexion.dllConexion.Conexion());

                MySqlDataReader reader = cmdl.ExecuteReader();

                DataTable horario = new DataTable();               //Creacion de objeto de una tabla auxiliar para sustituir por la tabla real
                horario.Columns.Add("Nombre Pelicula", typeof(string));
                horario.Columns.Add("Nombre Sucursal", typeof(string));
                horario.Columns.Add("Numero Sala", typeof(string));
                horario.Columns.Add("Tipo Sala", typeof(string));
                horario.Columns.Add("Fecha", typeof(DateTime));
                horario.Columns.Add("Estado Pelicula", typeof(string));
                horario.Columns.Add("Hora Inicio", typeof(string));
                horario.Columns.Add("Hora Final", typeof(string));



                //horario.Rows.Clear();                              //Limpia datos de la Tabla
                if (reader.Read())
                {
                    snombrepeli = reader.GetString(0).ToString();
                    snombresucursal = reader.GetString(1).ToString();
                    snumerosala = reader.GetString(2).ToString();
                    stiposala = reader.GetString(3).ToString();
                    sfecha = reader.GetString(4).ToString();
                    sestadopeli = reader.GetString(5).ToString();
                    shorainicio = reader.GetString(6).ToString();
                    shorafinal = reader.GetString(7).ToString();


                    horario.Rows.Add(snombrepeli, snombresucursal, snumerosala, stiposala, sfecha, sestadopeli, shorainicio, shorafinal);


                    MessageBox.Show("Ya existe esta asignacion de pelicula");
                    dgvinfoPeliculas.DataSource = horario;

                }
                else
                {
                    // si en tal caso la sala y el horario no son iguales guarda la pelicula
                    try
                    {
                        
                       

                        string fecha;
                        fecha = dtpfecha.Value.Year + "/" + dtpfecha.Value.Month + "/" + dtpfecha.Value.Day;
                        string query = string.Format("INSERT INTO TRHORARIO (idSucursal,iidPelicula,inumerosala,vtiposala,dfecha,vestado,thorainicio,thorafinal) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", csucursal.SelectedValue, cnombrePelicula.SelectedValue, cnoSala.SelectedValue, txttipoSala.Text, fecha, cestadopeli.SelectedItem, horainicio, horafinal);
                        dllConexion.dllConexion.inserta(query);
                        MessageBox.Show("el registro se inserto exitosamente");

                        refrescarhorario();
                        cnombrePelicula.ResetText();
                        csucursal.ResetText();
                        cnoSala.ResetText();
                        txttipoSala.ResetText();
                        txtid.ResetText();
                        dtpfecha.ResetText();
                        cestadopeli.ResetText();
                        chorarioPelicula.ResetText();

                    }
                    catch
                    {
                        MessageBox.Show("Ocurrio algun error! Lo sentimos");
                    }

                }






            }

        }

        

        private void baceptarPelicula_Click(object sender, EventArgs e)
        {
            frmingresarHorario horario = new frmingresarHorario();
            string noid = this.dgvinfoPeliculas.CurrentRow.Cells[0].Value.ToString();
            txtid.Text = noid;
            string nombrePelicula = this.dgvinfoPeliculas.CurrentRow.Cells[1].Value.ToString();
            cnombrePelicula.Text = nombrePelicula;
            string sucursal = this.dgvinfoPeliculas.CurrentRow.Cells[2].Value.ToString();
            csucursal.Text = sucursal;
            string numerosala = this.dgvinfoPeliculas.CurrentRow.Cells[3].Value.ToString();
            cnoSala.Text = numerosala;
            horario.txttipoSala.Text = this.dgvinfoPeliculas.CurrentRow.Cells[4].Value.ToString();
            String fecha = Convert.ToString(dgvinfoPeliculas.CurrentRow.Cells[5].Value);
            dtpfecha.Text = fecha;
            string estado = this.dgvinfoPeliculas.CurrentRow.Cells[6].Value.ToString();
            cestadopeli.Text = estado;
            String hora = this.dgvinfoPeliculas.CurrentRow.Cells[7].Value.ToString() +" - "+ this.dgvinfoPeliculas.CurrentRow.Cells[8].Value.ToString();
            chorarioPelicula.Text = hora;
            beditar.Enabled = true;
            beliminar.Enabled = true;
            bcancelar.Enabled = true;

            
        }

        private void beliminar_Click(object sender, EventArgs e)
        {
            String delete = "Delete from TRHORARIO WHERE iidHorario ='" + txtid.Text + "'";
            dllConexion.dllConexion.inserta(delete);
            MessageBox.Show("Registro Eliminado Exitosamente");
            refrescarhorario();
            beditar.Enabled = false;
            beliminar.Enabled = false;
            bcancelar.Enabled = false;
            cnombrePelicula.ResetText();
            csucursal.ResetText();
            cnoSala.ResetText();
            txttipoSala.ResetText();
            txtid.ResetText();
            dtpfecha.ResetText();
            cestadopeli.ResetText();
            chorarioPelicula.ResetText();
        }

        private void beditar_Click(object sender, EventArgs e)
        {
            string[] str;
            str = chorarioPelicula.Text.Split(' ', '-', 'P', 'M');
            string horainicio = str[0];
            string horafinal = str[6];
            string fecha;
            fecha = dtpfecha.Value.Year + "/" + dtpfecha.Value.Month + "/" + dtpfecha.Value.Day;
            string updatePeli = ("UPDATE TRHORARIO set iidPelicula = '" + cnombrePelicula.SelectedValue + "', idSucursal = '" + csucursal.SelectedValue + "', inumerosala = '" + cnoSala.SelectedValue + "', vtiposala = '" + txttipoSala.Text + "', dfecha = '" + fecha + "', vestado = '" + cestadopeli.SelectedItem + "', thorainicio = '" + horainicio + "', thorafinal = '" + horafinal  + "' where iidHorario ='" + txtid.Text + "'");
            dllConexion.dllConexion.inserta(updatePeli);
            MessageBox.Show("Registro Editado Exitosamente");
            refrescarhorario();
            beditar.Enabled = false;
            beliminar.Enabled = false;
            bcancelar.Enabled = false;
            cnombrePelicula.ResetText();
            csucursal.ResetText();
            cnoSala.ResetText();
            txttipoSala.ResetText();
            txtid.ResetText();
            dtpfecha.ResetText();
            cestadopeli.ResetText();
            chorarioPelicula.ResetText();

        }

        private void bcancelar_Click(object sender, EventArgs e)
        {
            beditar.Enabled = false;
            beliminar.Enabled = false;
            cnombrePelicula.ResetText();
            csucursal.ResetText();
            cnoSala.ResetText();
            txttipoSala.ResetText();
            txtid.ResetText();
            dtpfecha.ResetText();
            cestadopeli.ResetText();
            chorarioPelicula.ResetText();
        }

       
    }
}


