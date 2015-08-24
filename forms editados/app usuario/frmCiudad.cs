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

namespace WindowsFormsApplication1
{
    public partial class frmCiudad : Form
    {
        public frmCiudad()
        {
            InitializeComponent();

            //Se cargan los datos del datatable a los combobox
            cmbCiudad.DataSource = ciudades();
           
        }

        //Programador y Analista: José Wilfredo Chacón Cartagena
        //Fecha de Asignación: 14/08/2015
        //Fecha de Entrega: 16/08/2015
        //Esta funcion se utiliza para traer el id y el nombre de la ciudad para luego cargar esa informacion a un combobox automaticamente
        public DataTable ciudades()
        {
            DataTable dt = new DataTable();
            string query = "SELECT iidCiudad,vnombreCiudad FROM MACIUDAD;";
            MySqlCommand comando = new MySqlCommand(query, classCrearConexion.Conexion());
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            cmbCiudad.DisplayMember = "vnombreCiudad";
            cmbCiudad.ValueMember = "iidCiudad";
            da.Fill(dt);
            classCrearConexion.Conexion().Close();
            return dt;
        }

        //Programador y Analista: José Wilfredo Chacón Cartagena
        //Fecha de Asignación: 14/08/2015
        //Fecha de Entrega: 16/08/2015
        //Esta funcion se utiliza para traer el id y el nombre de la sucursal para luego cargar esa informacion a un combobox automaticamente
      
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void btnCartelera_Click(object sender, EventArgs e)
        {
            cartelera cartelera = new cartelera();
            cartelera.lblsucursal.Text = cmbCine.SelectedValue.ToString();
           
            cartelera.Show();
            this.WindowState = FormWindowState.Minimized;
           
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        //Programador y Analista: José Wilfredo Chacón Cartagena
        //Fecha de Asignación: 17/08/2015
        //Fecha de Entrega: 23/08/2015
        //Esta funcion se utiliza para cargar las salas de cine dependiendo de la ciudad o departamento
        private void cmbCiudad_TextChanged(object sender, EventArgs e)
        {
            DataSet data = new DataSet();
            MySqlDataAdapter query = new MySqlDataAdapter("select iidSucursal,iidCiudad,vnombre from MASUCURSAL where iidciudad ='" + cmbCiudad.SelectedValue.ToString() + "'", classCrearConexion.Conexion());

            query.Fill(data, "MASUCURSAL");
            cmbCine.DataSource = data.Tables[0].DefaultView;
            cmbCine.DisplayMember = "vnombre";
            cmbCine.ValueMember = "iidSucursal";
            
        }
    }
}
