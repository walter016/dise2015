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

        String ora_connect = "server=127.0.0.1; database=taquilla; Uid=root; pwd=;";
        MySqlConnection con = new MySqlConnection();
        public frmingresarSala()
        {
            InitializeComponent();
            con.ConnectionString = ora_connect;
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            string query = string.Format("INSERT INTO TRSALA (idSucursal,icapacidad, vtipo) VALUES('{0}','{1}','{2}')",csucursal.SelectedValue, txtcapacidadSala.Text, ctipoSala.SelectedItem);
            try
            {
                clascrearConexion.inserta(query);

                txtcapacidadSala.ResetText();
                ctipoSala.ResetText();

                MessageBox.Show("Sala registrada con Exito");
            }
            catch
            {
                MessageBox.Show("Ocurrió un Error");
            }
        }

        private void frmingresarSala_Load(object sender, EventArgs e)
        {
            con.Open();
            DataSet dsd = new DataSet();
            MySqlDataAdapter sql2 = new MySqlDataAdapter("SELECT IDSUCURSAL,VNOMBRE FROM TRSUCURSAL", con);

            sql2.Fill(dsd, "TRSUCURSAL");
            csucursal.DataSource = dsd.Tables[0].DefaultView;
            csucursal.ValueMember = "IDSUCURSAL";
            csucursal.DisplayMember = "VNOMBRE";

            
        }
    }
}
