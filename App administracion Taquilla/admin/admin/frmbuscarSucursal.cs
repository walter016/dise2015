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
            string box = string.Format("SELECT CID.vnombreCiudad AS Ciudad,SUC.vnombre AS Sucursal, CASE WHEN SUC.iestado <=0 THEN 'No Disponible' ELSE 'Disponible' END Estado FROM MASUCURSAL SUC, MACIUDAD CID WHERE SUC.iidCiudad=CID.iidCiudad AND SUC.vnombre COLLATE latin1_bin ='{0}'", txtbuscarSucursal.Text);
            try
            {
                //Ingreso de busqueda de sucursal en la bitacora
                claseEmp.Bita(claseEmp.MyUserName, 3, "MASUCURSAL");
                MySqlCommand com = new MySqlCommand(box, dllConexion.dllConexion.Conexion());
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = com;
                da.Fill(ds);
                grdinformacionSucursal.DataSource = ds;
                grdinformacionSucursal.Columns["Ciudad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                grdinformacionSucursal.Columns["Sucursal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                grdinformacionSucursal.Columns["Estado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                if(ds.Rows.Count>0)
                {
                    MessageBox.Show("Sucursal Encontrada");
                }
                else
                {
                    grdinformacionSucursal.DataSource = null;
                    grdinformacionSucursal.Refresh();
                    MessageBox.Show("No Existe Tal Sucursal");

                }
                
            }
            catch
            {
                MessageBox.Show("Ocurrio algun error! Lo sentimos");
            }
        }

        private void bnuevabusqueda_Click(object sender, EventArgs e)
        {
            txtbuscarSucursal.ResetText();

            grdinformacionSucursal.DataSource = null;
            grdinformacionSucursal.Rows.Clear();
            grdinformacionSucursal.Refresh();
        }
    }
}
