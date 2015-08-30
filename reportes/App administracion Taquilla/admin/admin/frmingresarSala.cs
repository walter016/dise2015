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
    public partial class frmingresarSala : Form
    {

        public frmingresarSala()
        {
            InitializeComponent();
        }
        private void sucursales()
        {
            DataSet dsd = new DataSet();
            MySqlDataAdapter sql2 = new MySqlDataAdapter("SELECT IIDSUCURSAL,VNOMBRE FROM MASUCURSAL", dllConexion.dllConexion.Conexion());
            sql2.Fill(dsd, "MASUCURSAL");
            csucursal.DataSource = dsd.Tables[0].DefaultView;
            csucursal.ValueMember = "IIDSUCURSAL";
            csucursal.DisplayMember = "VNOMBRE";
        }
        private void salas()
        {
            DataSet dsd = new DataSet();
            MySqlDataAdapter sql2 = new MySqlDataAdapter("SELECT IIDTIPO,VTIPOSALA FROM MATIPOSALA", dllConexion.dllConexion.Conexion());
            sql2.Fill(dsd, "MATIPOSALA");
            ctipoSala.DataSource = dsd.Tables[0].DefaultView;
            ctipoSala.ValueMember = "IIDTIPO";
            ctipoSala.DisplayMember = "VTIPOSALA";

        }
        private void bguardar_Click(object sender, EventArgs e)
        {
            string query = string.Format("INSERT INTO TRSALA (idSucursal,itipo) VALUES('{0}','{1}')",csucursal.SelectedValue, ctipoSala.SelectedValue);
            try
            {
                dllConexion.dllConexion.inserta(query);




                MessageBox.Show("Sala registrada con Exito");
                //Ingreso de cuidad en laa bitacora
                claseEmp.Bita(claseEmp.MyUserName, 2, "TRSALA");
            }
            catch
            {
                MessageBox.Show("Ocurrió un Error");
            }
        }

        private void frmingresarSala_Load(object sender, EventArgs e)
        {
            sucursales();
            salas();
            
        }
    }
}
