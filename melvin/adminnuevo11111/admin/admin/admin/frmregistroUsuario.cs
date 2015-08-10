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
    public partial class frmregistroUsuario : Form
    {
        String ora_connect = "server=127.0.0.1; database=taquilla; Uid=root; pwd=;";
        MySqlConnection con = new MySqlConnection();
        public frmregistroUsuario()
        {
            InitializeComponent();
            con.ConnectionString = ora_connect;
        
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            string query = string.Format("INSERT INTO MAREGISTROPERSONAL (vnombre, vapellido, vtipo, vusuario, vcontrasenia) VALUES('{0}','{1}','{2}','{3}','{4}')", txtnombre.Text, txtapellido.Text, cmbtipousuario.Text, txtusuario.Text, txtpassword.Text); 
           
            try
            {
                clascrearConexion.inserta(query);
                

                txtnombre.ResetText();
                txtapellido.ResetText();
                cmbtipousuario.ResetText();
                txtusuario.ResetText();
                txtpassword.ResetText();
              
                MessageBox.Show("Usuario registrado Exitosamente");
            }
            catch
            {
                MessageBox.Show("Ocurrió un Error");
            }
        }

        

        private void btnbuscaremp_Click(object sender, EventArgs e)
        {
            try
            {
                String idempleado = "";   //Variables para el Almacenamineto de resultados de los Querys
                String nombre = "";
                String apellido = "";
                String tipo = "";
                String usuario = "";
                String contrasenia = "";

                string sql = "SELECT IIDREGISTRO,VNOMBRE as 'Nombre Empleado',VAPELLIDO,VTIPO,VUSUARIO,VCONTRASENIA FROM MAREGISTROPERSONAL WHERE IIDREGISTRO ='" + txtbidemp.Text + "' OR VNOMBRE = '" + txtbnombre.Text + "' OR VAPELLIDO= '" + txtbapellido.Text + "'OR VTIPO='" +cmbbtipo.Text + "'OR VUSUARIO='" + txtbusuario.Text + "'OR VCONTRASENIA='" + txtbpassword.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, clascrearConexion.ObtenerConexion());

                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable buscarempleado = new DataTable();               //Creacion de objeto de una tabla auxiliar para sustituir por la tabla real
                buscarempleado.Columns.Add("Codigo Empleado", typeof(string));
                buscarempleado.Columns.Add("Nombre Empleado", typeof(string));
                buscarempleado.Columns.Add("Apellido Empleado", typeof(string));
                buscarempleado.Columns.Add("Tipo Usuario", typeof(string));
                buscarempleado.Columns.Add("Usuario", typeof(string));
                buscarempleado.Columns.Add("Password", typeof(string));
                

                buscarempleado.Rows.Clear();                              //Limpia datos de la Tabla

                if (reader.Read())
                {
                    idempleado = reader.GetString(0).ToString();
                    nombre = reader.GetString(1).ToString();
                    apellido = reader.GetString(2).ToString();
                    tipo = reader.GetString(3).ToString();
                    usuario = reader.GetString(4).ToString();
                    contrasenia= reader.GetString(5).ToString();
                    
                    buscarempleado.Rows.Add(idempleado, nombre, apellido, tipo, usuario, contrasenia);

                    MessageBox.Show("Empleado Encontrado");

                }
                else
                {
                    MessageBox.Show("No existe empleado con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);


                }
                grdbuscarempleado.DataSource = buscarempleado;
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void baceptarPelicula_Click(object sender, EventArgs e)
        {
            frmregistroUsuario regempleado = new frmregistroUsuario();
            
            regempleado.txtidempleado .Text = this.grdbuscarempleado.CurrentRow.Cells[0].Value.ToString();
            regempleado.txtnombre.Text = this.grdbuscarempleado.CurrentRow.Cells[1].Value.ToString();
            regempleado.txtapellido.Text = this.grdbuscarempleado.CurrentRow.Cells[2].Value.ToString();
            regempleado.cmbtipousuario.Text = this.grdbuscarempleado.CurrentRow.Cells[3].Value.ToString();
            regempleado.txtusuario.Text = this.grdbuscarempleado.CurrentRow.Cells[4].Value.ToString();
            regempleado.txtpassword.Text = this.grdbuscarempleado.CurrentRow.Cells[5].Value.ToString();
            
            regempleado.bguardar.Enabled = false;
            regempleado.beditar.Enabled = true;
            regempleado.beliminar.Enabled = true;
            this.Hide();
            regempleado.ShowDialog();
           
        }

        private void grdbuscarempleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void beditar_Click(object sender, EventArgs e)
        {
            frmregistroUsuario regempleado = new frmregistroUsuario();
            string updateRegistro = ("UPDATE MAREGISTROPERSONAL set vnombre = '" + txtnombre.Text + "', vapellido = '" + txtapellido.Text + "', vtipo = '" + cmbtipousuario.Text + "', vusuario = '" + txtusuario.Text + "', vcontrasenia = '" + txtpassword.Text +"' WHERE iidregistro = '" + txtidempleado.Text + "'");
            clascrearConexion.inserta(updateRegistro);
            MessageBox.Show("El empleado " + txtnombre.Text + " se actualizo correctamente");
            
            txtidempleado.ResetText();
            txtnombre.ResetText();
            txtapellido.ResetText();
            cmbtipousuario.ResetText();
            txtusuario.ResetText();
            txtpassword.ResetText();

            
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void beliminar_Click(object sender, EventArgs e)
        {
            frmregistroUsuario regempleado = new frmregistroUsuario();
            String delete = "Delete from MAREGISTROPERSONAL WHERE IIDREGISTRO ='" + txtidempleado.Text + "'";
            clascrearConexion.inserta(delete);
            MessageBox.Show("El empleado " + txtnombre.Text + " se eliminó correctamente");
            txtidempleado.ResetText();
            txtnombre.ResetText(); 
            txtapellido.ResetText();
            cmbtipousuario.ResetText();
            txtusuario.ResetText();
            txtpassword.ResetText();

            regempleado.bguardar.Enabled = true;
            regempleado.beditar.Enabled = false;
            regempleado.beliminar.Enabled = false;
            regempleado.button1.Enabled = false;
                    
        }

        private void bguardar_Click_1(object sender, EventArgs e)
        {

            if (txtnombre.Text.Length == 0 && txtapellido.Text.Length == 0 && cmbtipousuario.Text.Length == 0 && txtusuario.Text.Length == 0 && txtpassword.Text.Length == 0)
            {

                MessageBox.Show("Debe ingresar todos los datos solicitados");
            }
            else
            {

                string query = string.Format("INSERT INTO MAREGISTROPERSONAL (vnombre, vapellido, vtipo, vusuario, vcontrasenia) VALUES('{0}','{1}','{2}','{3}','{4}')", txtnombre.Text, txtapellido.Text, cmbtipousuario.Text, txtusuario.Text, txtpassword.Text);

                try
                {

                    clascrearConexion.inserta(query);

                    txtnombre.ResetText();
                    txtapellido.ResetText();
                    cmbtipousuario.ResetText();
                    txtusuario.ResetText();
                    txtpassword.ResetText();

                    MessageBox.Show("Empleado Registrado Exitosamente");
                }
                catch
                {

                    MessageBox.Show("Ocurrió un Error");
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            beditar.Enabled = false;
            beliminar.Enabled = false;
            bguardar.Enabled = true;
        }

     
            
        }

       
    }

