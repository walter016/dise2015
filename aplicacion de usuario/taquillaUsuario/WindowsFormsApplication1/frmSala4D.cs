//Programador y Analista: Walter Ivan Flores Guzman
//Fecha de Asignación: 12/08/2015
//Fecha de Entrega: 17/08/2015
//programacion inicial 12/8/2015 Cargar los datos de los asientos asignados
//modificacion 21/08/2015 Obtener los tipos y numeros de asientos de la reservacion
//Modificacion 29/08/2015 Agregar reloj cuenta regresiva
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Creacion de dataReaders y Comandos en mysql
using MySql.Data.MySqlClient;
// Manejo de la conexion a la base de datos
using dllConexion;
// Hilos que manejan el tiempo que estara disponible el formulario
using System.Threading;

namespace WindowsFormsApplication1
{   
    public partial class frmSala4D : Form
    {
        //definicion de variables y metodos
       EventArgs sa = new EventArgs();
       private DateTime dfechaFin = DateTime.Now;
       private TimeSpan ttiempo = new TimeSpan();
       private Thread oThread;
       public int iasientos = 0;
       private void Form1_Load(object sender, EventArgs e)
       {
           asientos();
           ocupados();
           tiempo();
       }

       public frmSala4D()
       {
           InitializeComponent();
       }
        
        //Se recorre todo el formularia en busca del control de contexto
        private List<Control> tomaControl(string contexto, Control donde)
        {
            List<Control> controles = new List<Control>();
            foreach (Control c in donde.Controls)
            {
                if (c.GetType().Name == contexto)
                {
                    controles.Add(c);
                }
                else if (c.Controls.Count > 0)
                {
                    controles.AddRange(tomaControl(contexto, c));
                }
            }
            return controles;
        }
        //Se dinamiza el evento click de todos los botones para que sea solo un metodo
        //Se pinta de color verde cuando se selecciona un boton
        private void asientos()
        {
            tomaControl("Button", this).ForEach(p =>
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
        //Funcion en la cual obtenemos todos los asientos que estan ocupados en dicha sala y se pintan de color rojo
        public void ocupados()
        {
            string query = "SELECT CONCAT(`vfila`,`icolumna`) AS ASIENTO , iestado FROM `TRASIENTOS` WHERE `iidSala`=3 ORDER BY ASIENTO ASC ";
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand(query, dllConexion.dllConexion.Conexion());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tomaControl("Button", this).ForEach(p =>
                {
                    if (p.Text == Convert.ToString(reader["ASIENTO"]) && Convert.ToString(reader["iestado"]) == "1")
                    {
                        p.BackColor = Color.Red;
                    }
                });
            }
        }

        //cerrar la aplicacion y detener el reloj
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oThread.Abort();
            Application.Exit();
        }

        //vamos al menu principal de la aplicacion
        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oThread.Abort();
            Application.Restart();
        }
        //se carga el formulario anterior
        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oThread.Abort();
            this.Close();
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmreservacion);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                frm.WindowState = FormWindowState.Maximized;
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frmreservacion();
            frm.Show();
        }
       
        //se envia al usuario una advertencia que solo tiene de 2 minutos para seleccionar su asiento
        private void tiempo()
        {
            MessageBox.Show("Tiene 2 Minutos para seleccionar sus asientos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            dfechaFin = DateTime.Now.AddMinutes(2);
            ttiempo = dfechaFin - DateTime.Now;
            oThread = new Thread(new ThreadStart(CalcularTime));
            oThread.Start();     
        }
        //colocar en un label el tiempo que dispone el usuario para seleccion de su asiento
        private void CalcularTime()
        {
            while (DateTime.Now < dfechaFin)
            {
                ttiempo = dfechaFin - DateTime.Now;
                try
                {
                    lblcontador.Invoke((MethodInvoker)(() => lblcontador.Text = ttiempo.TotalSeconds.ToString()));
                }
                catch
                { 

                }
            }
        }
    }
}