/*
 programacion Walter Flores 
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
    public partial class frmbuscarSucursal : Form
    {
        public frmbuscarSucursal()
        {
            InitializeComponent();
        }

        private void bbuscarSucursal_Click(object sender, EventArgs e)
        {
            grdinformacionSucursal.DataSource = null;
            grdinformacionSucursal.Refresh();
            DataTable ds = new DataTable();
            string box = string.Format("SELECT CID.vnombreCiudad AS Ciudad,SUC.vnombre AS Sucursal, CASE WHEN SUC.iestado <=0 THEN 'No Disponible' ELSE 'Disponible' END Estado FROM MASUCURSAL SUC, MACIUDAD CID WHERE SUC.iidCiudad=CID.iidCiudad ");
            try
            {
                MySqlCommand com = new MySqlCommand(box, clascrearConexion.ObtenerConexion());
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = com;
                da.Fill(ds);
                grdinformacionSucursal.DataSource = null;
                grdinformacionSucursal.Refresh();
                grdinformacionSucursal.DataSource = ds;
                grdinformacionSucursal.Columns["Ciudad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                grdinformacionSucursal.Columns["Sucursal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                grdinformacionSucursal.Columns["Estado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch
            {

            }
        }
    }
}
