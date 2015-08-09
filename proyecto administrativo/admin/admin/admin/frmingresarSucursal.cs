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
    public partial class frmingresarSucursal : Form
    {
        public frmingresarSucursal()
        {
            InitializeComponent();
        }

        public class Item
        {
            public string Name { get; set; }
            public int Value { get; set; }

            public Item(string name, int value)
            {
                Name = name;
                Value = value;
            }
            public override string ToString()
            {
                return Name;
            }
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            string query = string.Format("INSERT INTO TRSUCURSAL (vnombre, iestado, vdireccion) VALUES('{0}','{1}','{2}')", txtnombreSucursal.Text, cestadoSucursal.SelectedValue, txtdireccionSucursal.Text);
            try
            {
                clascrearConexion.inserta(query);

                txtnombreSucursal.ResetText();
                cestadoSucursal.ResetText();
                txtdireccionSucursal.ResetText();

                MessageBox.Show("Sucursal registrada con Exito");
            }
            catch
            {
                MessageBox.Show("Ocurrió un Error");
            }
        }

        private void frmingresarSucursal_Load(object sender, EventArgs e)
        {
            List<Item> lista = new List<Item>();
            lista.Add(new Item("Estado", 0));
            lista.Add(new Item("Disponible", 1));
            lista.Add(new Item("No Disponible", 2));

            cestadoSucursal.DisplayMember = "Name";
            cestadoSucursal.ValueMember = "Value";
            cestadoSucursal.DataSource = lista;
        }
    }
}
