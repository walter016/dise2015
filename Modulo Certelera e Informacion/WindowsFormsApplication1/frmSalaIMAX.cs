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
    public partial class frmSalaIMAX : Form
    {
       EventArgs sa = new EventArgs();
        public int ass=0;
        private List<Control> getControls(string what, Control where)
        {
            List<Control> controles = new List<Control>();
            foreach (Control c in where.Controls)
            {
                if (c.GetType().Name == what)
                {
                    controles.Add(c);
                }
                else if (c.Controls.Count > 0)
                {
                    controles.AddRange(getControls(what, c));
                }
            }
            return controles;
        }
        public int iasientos = 20;
        private void asientos()
        {
            getControls("Button", this).ForEach(p =>
            {
                p.Click += new EventHandler(delegate(object s, EventArgs args)
                {
                    if (p.BackColor == Color.Red)
                    {
                    }
                    else if (p.BackColor == Color.Green)
                    {
                        iasientos++;
                        p.BackColor = Color.LightGray;
                    }
                    else if (iasientos > 0)
                    {
                        p.BackColor = Color.Green;
                        iasientos--;
                    }
                });
            });
        }
        public void ocupados()
        {
            string query = "SELECT CONCAT(`vfila`,`icolumna`) AS ASIENTO , iestado FROM `TRASIENTOS` WHERE `iidSala`=3 ORDER BY ASIENTO ASC ";
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand(query, dllConexion.dllConexion.Conexion());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                getControls("Button", this).ForEach(p =>
                {
                    if (p.Text == Convert.ToString(reader["ASIENTO"]) && Convert.ToString(reader["iestado"]) == "1")
                    {
                        p.BackColor = Color.Red;
                    }
                });
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ocupados();
            asientos();
        }

        public frmSalaIMAX() 
        {
            InitializeComponent();
        }
    }
}