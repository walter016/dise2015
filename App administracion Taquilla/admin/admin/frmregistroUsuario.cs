/*Autor: Melvin A. Batz Farfan
  Carné: 0901-12-1049
  */
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

        public frmregistroUsuario()
        {
            InitializeComponent();
            cmbtipousuario.DataSource = tipoUsuario();
        }



        public DataTable tipoUsuario()
        {
            DataTable dt = new DataTable();
            string query = "SELECT  iidtipoUsuario,vtipoUsuario FROM TRTIPOUSUARIO;";
            MySqlCommand comando = new MySqlCommand(query, dllConexion.dllConexion.Conexion());
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            cmbtipousuario.DisplayMember = "vtipoUsuario";
            cmbtipousuario.ValueMember = "iidtipoUsuario";
            da.Fill(dt);
            dllConexion.dllConexion.Conexion().Close();
            return dt;
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
           //Query para realizar la insercion para registrar a un nuevo empleado
            string query = string.Format("INSERT INTO MAREGISTROPERSONAL (vnombre, vapellido, vtipo, vusuario, vcontrasenia) VALUES('{0}','{1}','{2}','{3}','{4}')", txtnombre.Text, txtapellido.Text, cmbtipousuario.Text, txtusuario.Text, txtpassword.Text); 
           
            try
            {

                dllConexion.dllConexion.inserta(query); //Utilizacion de una dll para la conexion con la BD
                txtidempleado.ResetText();
                txtnombre.ResetText();
                txtapellido.ResetText();
                cmbtipousuario.ResetText();
                txtusuario.ResetText();
                txtpassword.ResetText();
              
                MessageBox.Show("Usuario registrado Exitosamente");

                claseEmp.Bita(claseEmp.MyUserName, 2, "MAREGISTROPERSONAL");//Registrar la insercion en la Bitacora de Ingresos
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

                // query para realizar la busqueda de un empleado, asi mismo asignandole un alias para que no se muestren los campos de la BD
                string sql = "SELECT IIDREGISTRO,VNOMBRE as 'Nombre Empleado',VAPELLIDO,VTIPO,VUSUARIO,VCONTRASENIA FROM MAREGISTROPERSONAL WHERE IIDREGISTRO ='" + txtbidemp.Text + "' OR VNOMBRE = '" + txtbnombre.Text + "' OR VAPELLIDO= '" + txtbapellido.Text + "''OR VUSUARIO='" + txtbusuario.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, dllConexion.dllConexion.Conexion());// Utilizacion de la dllconexion para realiar conexion con la BD

                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable buscarempleado = new DataTable();               //Creacion de objeto de una tabla auxiliar para sustituir por la tabla real
                buscarempleado.Columns.Add("Codigo Empleado", typeof(string));
                buscarempleado.Columns.Add("Nombre Empleado", typeof(string));
                buscarempleado.Columns.Add("Apellido Empleado", typeof(string));
                buscarempleado.Columns.Add("Tipo Usuario", typeof(string));
                buscarempleado.Columns.Add("Usuario", typeof(string));
                buscarempleado.Columns.Add("Password", typeof(string));
                

                buscarempleado.Rows.Clear();   //Limpia datos de la Tabla

                if (reader.Read())
                {
                    idempleado = reader.GetString(0).ToString();
                    nombre = reader.GetString(1).ToString();
                    apellido = reader.GetString(2).ToString();
                    tipo = reader.GetString(3).ToString();
                    usuario = reader.GetString(4).ToString();
                    contrasenia= reader.GetString(5).ToString();
                    
                    buscarempleado.Rows.Add(idempleado, nombre, apellido, tipo, usuario, contrasenia);//Asignamos el nombre de los campos que tendra en DatagridView

                    MessageBox.Show("Empleado Encontrado");

                }
                else
                {
                    MessageBox.Show("No existe empleado con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);


                }
                grdbuscarempleado.DataSource = buscarempleado;//Llenamos el DataGridView con los datos del empleado seleccionado
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void baceptarEmpleado_Click(object sender, EventArgs e)
        {
            //Boton que nos perimitira realizar una eliminacion o edicion de campos, luego de haber realizado una busqueda en la BD
            frmregistroUsuario regempleado = new frmregistroUsuario();
            
           //Seleccionamos todos los campos que se encuentran en el DataGridView para ser enviados a los campos de la busqueda de empleados
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

        

        private void beditar_Click(object sender, EventArgs e)
        {
            frmregistroUsuario regempleado = new frmregistroUsuario();
            //Query para realizar una modificacion sobre un empleado 
            string updateRegistro = ("UPDATE MAREGISTROPERSONAL set vnombre = '" + txtnombre.Text + "', vapellido = '" + txtapellido.Text + "', vtipo = '" + cmbtipousuario.Text + "', vusuario = '" + txtusuario.Text + "', vcontrasenia = '" + txtpassword.Text +"' WHERE iidregistro = '" + txtidempleado.Text + "'");
            dllConexion.dllConexion.inserta(updateRegistro);
            MessageBox.Show("El empleado " + txtnombre.Text + " se actualizo correctamente");
            
            //Limpiamos todas las cajas de texto
            txtidempleado.ResetText();
            txtnombre.ResetText();
            txtapellido.ResetText();
            cmbtipousuario.ResetText();
            txtusuario.ResetText();
            txtpassword.ResetText();

            //Activamos y Desactivamos ciertos botones
            regempleado.bguardar.Enabled = true;
            regempleado.beditar.Enabled = false;
            regempleado.beliminar.Enabled = false;
            regempleado.brefrescar.Enabled = false;            
          
        }

      

        private void beliminar_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text.Length == 0 && txtapellido.Text.Length == 0 && cmbtipousuario.Text.Length == 0 && txtusuario.Text.Length == 0 && txtpassword.Text.Length == 0)
            {

                MessageBox.Show("Debe ingresar todos los datos solicitados");
            }
            else
            {
                frmregistroUsuario regempleado = new frmregistroUsuario();
                //Realizamos una eliminacion por medio del codigo del empleado.
                String delete = "Delete from MAREGISTROPERSONAL WHERE IIDREGISTRO ='" + txtidempleado.Text + "'";
                dllConexion.dllConexion.inserta(delete);
                MessageBox.Show("El empleado " + txtnombre.Text + " se eliminó correctamente");
                
                //Limpiamos todas las cajas de Texto
                txtidempleado.ResetText();
                txtnombre.ResetText();
                txtapellido.ResetText();
                cmbtipousuario.ResetText();
                txtusuario.ResetText();
                txtpassword.ResetText();

                regempleado.bguardar.Enabled = true;
                regempleado.beditar.Enabled = false;
                regempleado.beliminar.Enabled = false;
                regempleado.brefrescar.Enabled = false;

            }
        }
        private void bguardar_Click_1(object sender, EventArgs e)
        {

            if (txtnombre.Text.Length == 0 && txtapellido.Text.Length == 0 && cmbtipousuario.Text.Length == 0 && txtusuario.Text.Length == 0 && txtpassword.Text.Length == 0)
            {

                MessageBox.Show("Debe ingresar todos los datos solicitados");
            }
            else
            {
                //Insercion de todos los datos de un nuevo empleado
                string query = string.Format("INSERT INTO MAREGISTROPERSONAL (vnombre, vapellido, vtipo, vusuario, vcontrasenia) VALUES('{0}','{1}','{2}','{3}','{4}')", txtnombre.Text, txtapellido.Text, cmbtipousuario.SelectedValue.ToString(), txtusuario.Text, txtpassword.Text);

                try
                {

                    dllConexion.dllConexion.inserta(query);//utilizacion de la dllconexion

                    //Limpieza de las cajas de Texto
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
          //Limpieza de las cajas de texto para un refresh del formulario
            txtidempleado.Text = "";
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtusuario.Text = "";
            txtpassword.Text = "";
            cmbtipousuario.Text = "";
            
            beditar.Enabled = false;
            beliminar.Enabled = true;
            bguardar.Enabled = true;
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtbidemp.Text = "";
            txtbnombre.Text = "";
            txtbapellido.Text = "";
            txtbusuario.Text = "";


            DataTable refrescars = (DataTable)grdbuscarempleado.DataSource;

            refrescars.Clear(); //Limpiamos el Grid View cuando el usuario no desee realizar ninguna accion con los datos buscados.
        }

     
            
        }

       
    }

