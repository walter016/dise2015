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
using dllConexion;

namespace WindowsFormsApplication1
{
    public partial class cartelera : Form
    {

        public cartelera()
        {
            InitializeComponent();
            
            
        }
        //Carga el combobox de los idiomas de las peliculas
        public DataTable idiomas()
        {
            DataTable dt = new DataTable();
            string query = "SELECT DISTINCT vidioma FROM MAPELICULA;";
            MySqlCommand comando = new MySqlCommand(query, dllConexion.dllConexion.Conexion());
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            cmbIdioma.DisplayMember = "vidioma";
            cmbIdioma.ValueMember = "vidioma";
            da.Fill(dt);
            dllConexion.dllConexion.Conexion().Close();
            return dt;
        }
        //carga el combobox de los subtitulos de las peliculas
        public DataTable subtitulo()
        {
            DataTable dt = new DataTable();
            string query = "SELECT DISTINCT vsubtitulo FROM MAPELICULA;";
            MySqlCommand comando = new MySqlCommand(query, dllConexion.dllConexion.Conexion());
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            cmbSubti.DisplayMember = "vsubtitulo";
            cmbSubti.ValueMember = "vsubtitulo";
            da.Fill(dt);
            dllConexion.dllConexion.Conexion().Close();
            return dt;
        }

        // carga el combobox de los diferentes tipos de salas que hay
        public DataTable tipoSala()
        {
            DataTable dt = new DataTable();
            string query = "SELECT DISTINCT vtiposala FROM TRHORARIO;";
            MySqlCommand comando = new MySqlCommand(query, dllConexion.dllConexion.Conexion());
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            cmbtipoSala.DisplayMember = "vtiposala";
            cmbtipoSala.ValueMember = "vtiposala";
            da.Fill(dt);
            dllConexion.dllConexion.Conexion().Close();
            return dt;
        }
        // carga el combobox de los diferentes horarios que hay
        public DataTable Horario()
        {
            DataTable dt = new DataTable();
            string query = "SELECT DISTINCT CONCAT(thorainicio,' - ',thorafinal) AS Hora FROM TRHORARIO;";
            MySqlCommand comando = new MySqlCommand(query, dllConexion.dllConexion.Conexion());
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            cmbHora.DisplayMember = "Hora";
            cmbHora.ValueMember = "Hora";
            da.Fill(dt);
            dllConexion.dllConexion.Conexion().Close();
            return dt;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmCiudad);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                frm.Show();
                frm.WindowState = FormWindowState.Normal;

                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frmCiudad();
            frm.Show();

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void cartelera_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Programador y Analista: Luis Fernando Linares Garzaro
        //Fecha de Asignación: 21/08/2015
        //Fecha de Entrega: 26/08/2015
        //Esta funcion se utiliza para mostrar los datos de la pelicula dinamicamente acorde a la sucursal seleecionada
        private void cartelera_Load(object sender, EventArgs e)
        {
            //se cargan los datos al combobox predestinado para mostrarlos en el formulario
            cmbIdioma.DataSource = idiomas();
            cmbSubti.DataSource = subtitulo();
            cmbtipoSala.DataSource = tipoSala();
            cmbHora.DataSource = Horario();
            //claseEmp.idioma = cmbIdioma.SelectedValue.ToString();
            
            //Muestra el total de peliculas acorde ala sucursal seleccionada
            String numeroSucursal = lblsucursal.Text;
            // Esta parte ejecuta la consulta de la sucursal seleccionada
            string sql = "SELECT count(*) FROM TRHORARIO TRHORA, MAPELICULA MAPELI WHERE TRHORA.iidpelicula=MAPELI.iidpelicula and TRHORA.idSucursal = '" + numeroSucursal + "' ";
            MySqlCommand cmd = new MySqlCommand(sql, dllConexion.dllConexion.Conexion());
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                int n = reader.GetInt32(0);


                //En esta consulta Obtiene los datos y la imagen para mostrar en los picture box
                string query = string.Format("SELECT DISTINCT TRHORA.iidpelicula, MAPELI.bimagen FROM TRHORARIO TRHORA, MAPELICULA MAPELI WHERE TRHORA.iidpelicula=MAPELI.iidpelicula and TRHORA.idSucursal = '" + numeroSucursal + "'");
                MySqlCommand comando = new MySqlCommand(query, dllConexion.dllConexion.Conexion());
                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                DataSet ds = new DataSet("MAPELICULA");
                da.Fill(ds, "MAPELICULA");
                dt = ds.Tables["MAPELICULA"];
                byte[] datos = new byte[0];
                int i = -1;
                foreach (DataRow dr in dt.Rows)
                {
                    // se hace incrementable la variable I
                    i++;
                    datos = (byte[])dr["bimagen"];
                    // se captura el id de la pelicula
                    string peli = dr["iidpelicula"].ToString();
                    PictureBox pb = new PictureBox();
                    //dibuja los picture box con sus  propiedades 
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                    pb.Image = System.Drawing.Bitmap.FromStream(ms);
                    // se multiplica por la variable i para que valla aumentando el ancho  de la imagen en la pelicula
                    pb.Size = new System.Drawing.Size(250, 320);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    // ala hora de hacer click en el picturebox se envia la variable de la pelicula
                    pb.Click += new EventHandler((sender1, e1) => PB_Click(sender1, e1, peli));
                    flowLayoutPanel1.Controls.Add(pb);

                }
            }
        }

        protected void PB_Click(object sender, EventArgs e, string pelicula)
        {
            frmInformacion info = new frmInformacion();
            //se asigna la variable pelicula hacia la variable My id Movie
            claseEmp.MyIdMovie = pelicula;
            // se muestra el formulario informacion
            info.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // cuando selecciona el combobox activa este metodo el el cual carga los idiomas  de las peliculas
        private void cmbIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            claseEmp.idioma = cmbIdioma.SelectedValue.ToString();
            
            //limpia el flowlayout
            flowLayoutPanel1.Controls.Clear();
            // llama al metodo que carga el flowlayout para mostrar las peliculas correspondientes 
            CargarIdiomas(claseEmp.idioma);
            
        }

        // cuando selecciona el combobox activa este metodo el el cual carga los subtitulos  de las peliculas
        private void cmbSubti_SelectedIndexChanged(object sender, EventArgs e)
        {
            claseEmp.subti = cmbSubti.SelectedValue.ToString();
         
            //limpia el flowlayout
            flowLayoutPanel1.Controls.Clear();
            // llama al metodo que carga el flowlayout para mostrar las peliculas correspondientes
            CargarSubti(claseEmp.subti);
        }

        // cuando selecciona el combobox activa este metodo el el cual carga los tipos de salas  de las peliculas
        private void cmbtipoSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            claseEmp.tipoSala = cmbtipoSala.SelectedValue.ToString();
           
            //limpia el flowlayout
            flowLayoutPanel1.Controls.Clear();
            // llama al metodo que carga el flowlayout para mostrar las peliculas correspondientes 
            CargartipoSala(claseEmp.tipoSala);
        }

        private void cmbHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            claseEmp.Horario = cmbHora.SelectedValue.ToString();

            //limpia el flowlayout
            flowLayoutPanel1.Controls.Clear();
            // llama al metodo que carga el flowlayout para mostrar las peliculas correspondientes 
            CargarHorario(claseEmp.Horario);
        }

        public void CargarIdiomas(string idioma)
        {
            String numeroSucursal = lblsucursal.Text;
            // Esta parte ejecuta la consulta de la sucursal seleccionada
            string sql = "SELECT count(*) FROM TRHORARIO TRHORA, MAPELICULA MAPELI WHERE TRHORA.iidpelicula=MAPELI.iidpelicula and TRHORA.idSucursal = '" + numeroSucursal + "' and  MAPELI.vidioma = '" + idioma + "' ";
            MySqlCommand cmd = new MySqlCommand(sql, dllConexion.dllConexion.Conexion());
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                int n = reader.GetInt32(0);


                //En esta consulta Obtiene los datos y la imagen para mostrar en los picture box
                string query = string.Format("SELECT  TRHORA.iidpelicula, MAPELI.bimagen FROM TRHORARIO TRHORA, MAPELICULA MAPELI WHERE TRHORA.iidpelicula=MAPELI.iidpelicula and TRHORA.idSucursal = '" + numeroSucursal + "' and  MAPELI.vidioma = '" + idioma + "'");
                MySqlCommand comando = new MySqlCommand(query, dllConexion.dllConexion.Conexion());
                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                DataSet ds = new DataSet("MAPELICULA");
                da.Fill(ds, "MAPELICULA");
                dt = ds.Tables["MAPELICULA"];
                byte[] datos = new byte[0];
                int i = -1;
                foreach (DataRow dr in dt.Rows)
                {
                    // se hace incrementable la variable I
                    i++;
                    datos = (byte[])dr["bimagen"];
                    // se captura el id de la pelicula
                    string peli = dr["iidpelicula"].ToString();
                    PictureBox pb = new PictureBox();
                    //dibuja los picture box con sus  propiedades 
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                    pb.Image = System.Drawing.Bitmap.FromStream(ms);
                    // se multiplica por la variable i para que valla aumentando el ancho  de la imagen en la pelicula
                    pb.Size = new System.Drawing.Size(250, 320);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    // ala hora de hacer click en el picturebox se envia la variable de la pelicula
                    pb.Click += new EventHandler((sender1, e1) => PB_Click(sender1, e1, peli));
                    flowLayoutPanel1.Controls.Add(pb);

                }
            }
        }

            public void CargarSubti(string subti)
            {
            String numeroSucursal = lblsucursal.Text;
            // Esta parte ejecuta la consulta de la sucursal seleccionada
            string sql = "SELECT count(*) FROM TRHORARIO TRHORA, MAPELICULA MAPELI WHERE TRHORA.iidpelicula=MAPELI.iidpelicula and TRHORA.idSucursal = '" + numeroSucursal + "' and  MAPELI.vsubtitulo  = '" + subti + "' ";
            MySqlCommand cmd = new MySqlCommand(sql, dllConexion.dllConexion.Conexion());
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                int n = reader.GetInt32(0);


                //En esta consulta Obtiene los datos y la imagen para mostrar en los picture box
                string query = string.Format("SELECT  TRHORA.iidpelicula, MAPELI.bimagen FROM TRHORARIO TRHORA, MAPELICULA MAPELI WHERE TRHORA.iidpelicula=MAPELI.iidpelicula and TRHORA.idSucursal = '" + numeroSucursal + "' and  MAPELI.vsubtitulo  = '" + subti + "'");
                MySqlCommand comando = new MySqlCommand(query, dllConexion.dllConexion.Conexion());
                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                DataSet ds = new DataSet("MAPELICULA");
                da.Fill(ds, "MAPELICULA");
                dt = ds.Tables["MAPELICULA"];
                byte[] datos = new byte[0];
                int i = -1;
                foreach (DataRow dr in dt.Rows)
                {
                    // se hace incrementable la variable I
                    i++;
                    datos = (byte[])dr["bimagen"];
                    // se captura el id de la pelicula
                    string peli = dr["iidpelicula"].ToString();
                    PictureBox pb = new PictureBox();
                    //dibuja los picture box con sus  propiedades 
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                    pb.Image = System.Drawing.Bitmap.FromStream(ms);
                    // se multiplica por la variable i para que valla aumentando el ancho  de la imagen en la pelicula
                    pb.Size = new System.Drawing.Size(250, 320);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    // ala hora de hacer click en el picturebox se envia la variable de la pelicula
                    pb.Click += new EventHandler((sender1, e1) => PB_Click(sender1, e1, peli));
                    flowLayoutPanel1.Controls.Add(pb);

                }
            }
        }

            public void CargartipoSala(string tipoSala)
            {
                String numeroSucursal = lblsucursal.Text;
                // Esta parte ejecuta la consulta de la sucursal seleccionada
                string sql = "SELECT count(*) FROM TRHORARIO TRHORA, MAPELICULA MAPELI WHERE TRHORA.iidpelicula=MAPELI.iidpelicula and TRHORA.idSucursal = '" + numeroSucursal + "' and  TRHORA.vtiposala   = '" + tipoSala + "' ";
                MySqlCommand cmd = new MySqlCommand(sql, dllConexion.dllConexion.Conexion());
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    int n = reader.GetInt32(0);


                    //En esta consulta Obtiene los datos y la imagen para mostrar en los picture box
                    string query = string.Format("SELECT  TRHORA.iidpelicula, MAPELI.bimagen FROM TRHORARIO TRHORA, MAPELICULA MAPELI WHERE TRHORA.iidpelicula=MAPELI.iidpelicula and TRHORA.idSucursal = '" + numeroSucursal + "' and  TRHORA.vtiposala  = '" + tipoSala + "'");
                    MySqlCommand comando = new MySqlCommand(query, dllConexion.dllConexion.Conexion());
                    MySqlDataAdapter da = new MySqlDataAdapter(comando);
                    DataTable dt = new DataTable();
                    DataSet ds = new DataSet("MAPELICULA");
                    da.Fill(ds, "MAPELICULA");
                    dt = ds.Tables["MAPELICULA"];
                    byte[] datos = new byte[0];
                    int i = -1;
                    foreach (DataRow dr in dt.Rows)
                    {
                        // se hace incrementable la variable I
                        i++;
                        datos = (byte[])dr["bimagen"];
                        // se captura el id de la pelicula
                        string peli = dr["iidpelicula"].ToString();
                        PictureBox pb = new PictureBox();
                        //dibuja los picture box con sus  propiedades 
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                        pb.Image = System.Drawing.Bitmap.FromStream(ms);
                        // se multiplica por la variable i para que valla aumentando el ancho  de la imagen en la pelicula
                        pb.Size = new System.Drawing.Size(250, 320);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        // ala hora de hacer click en el picturebox se envia la variable de la pelicula
                        pb.Click += new EventHandler((sender1, e1) => PB_Click(sender1, e1, peli));
                        flowLayoutPanel1.Controls.Add(pb);

                    }
                }
            }

            public void CargarHorario(string Horari)
            {
                String numeroSucursal = lblsucursal.Text;
                // Esta parte ejecuta la consulta de la sucursal seleccionada
                string sql = "SELECT count(*) FROM TRHORARIO TRHORA, MAPELICULA MAPELI WHERE TRHORA.iidpelicula=MAPELI.iidpelicula and TRHORA.idSucursal = '" + numeroSucursal + "' and CONCAT(thorainicio,' - ',thorafinal) = '" + Horari + "' ";
                MySqlCommand cmd = new MySqlCommand(sql, dllConexion.dllConexion.Conexion());
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    int n = reader.GetInt32(0);


                    //En esta consulta Obtiene los datos y la imagen para mostrar en los picture box
                    string query = string.Format("SELECT  TRHORA.iidpelicula, MAPELI.bimagen FROM TRHORARIO TRHORA, MAPELICULA MAPELI WHERE TRHORA.iidpelicula=MAPELI.iidpelicula and TRHORA.idSucursal = '" + numeroSucursal + "' and CONCAT(thorainicio,' - ',thorafinal) = '" + Horari + "'");
                    MySqlCommand comando = new MySqlCommand(query, dllConexion.dllConexion.Conexion());
                    MySqlDataAdapter da = new MySqlDataAdapter(comando);
                    DataTable dt = new DataTable();
                    DataSet ds = new DataSet("MAPELICULA");
                    da.Fill(ds, "MAPELICULA");
                    dt = ds.Tables["MAPELICULA"];
                    byte[] datos = new byte[0];
                    int i = -1;
                    foreach (DataRow dr in dt.Rows)
                    {
                        // se hace incrementable la variable I
                        i++;
                        datos = (byte[])dr["bimagen"];
                        // se captura el id de la pelicula
                        string peli = dr["iidpelicula"].ToString();
                        PictureBox pb = new PictureBox();
                        //dibuja los picture box con sus  propiedades 
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                        pb.Image = System.Drawing.Bitmap.FromStream(ms);
                        // se multiplica por la variable i para que valla aumentando el ancho  de la imagen en la pelicula
                        pb.Size = new System.Drawing.Size(250, 320);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        // ala hora de hacer click en el picturebox se envia la variable de la pelicula
                        pb.Click += new EventHandler((sender1, e1) => PB_Click(sender1, e1, peli));
                        flowLayoutPanel1.Controls.Add(pb);

                    }
                }
            }

            private void btnBusq_Click(object sender, EventArgs e)
            {
                //limpia el flowlayout
                flowLayoutPanel1.Controls.Clear();
                // llama al metodo que carga el flowlayout para mostrar las peliculas correspondientes 
                CargarBusqComple();
            }

            public void CargarBusqComple()
            {
                String numeroSucursal = lblsucursal.Text;
                // Esta parte ejecuta la consulta de la sucursal seleccionada
                string sql = "SELECT count(*) FROM TRHORARIO TRHORA, MAPELICULA MAPELI WHERE TRHORA.iidpelicula=MAPELI.iidpelicula and TRHORA.idSucursal = '" + numeroSucursal + "' and  MAPELI.vidioma = '" + cmbIdioma.SelectedValue.ToString() + "' and  MAPELI.vsubtitulo  = '" + cmbSubti.SelectedValue.ToString() + "'  and  TRHORA.vtiposala   = '" + cmbtipoSala.SelectedValue.ToString() + "'  and CONCAT(thorainicio,' - ',thorafinal) = '" + cmbHora.SelectedValue.ToString() + "'";
                MySqlCommand cmd = new MySqlCommand(sql, dllConexion.dllConexion.Conexion());
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    int n = reader.GetInt32(0);


                    //En esta consulta Obtiene los datos y la imagen para mostrar en los picture box
                    string query = string.Format("SELECT DISTINCT TRHORA.iidpelicula, MAPELI.bimagen FROM TRHORARIO TRHORA, MAPELICULA MAPELI WHERE TRHORA.iidpelicula=MAPELI.iidpelicula and TRHORA.idSucursal = '" + numeroSucursal + "' and  MAPELI.vidioma = '" + cmbIdioma.SelectedValue.ToString() + "' and  MAPELI.vsubtitulo  = '" + cmbSubti.SelectedValue.ToString() + "'  and  TRHORA.vtiposala   = '" + cmbtipoSala.SelectedValue.ToString() + "'  and CONCAT(thorainicio,' - ',thorafinal) = '" + cmbHora.SelectedValue.ToString() + "'");
                    MySqlCommand comando = new MySqlCommand(query, dllConexion.dllConexion.Conexion());
                    MySqlDataAdapter da = new MySqlDataAdapter(comando);
                    DataTable dt = new DataTable();
                    DataSet ds = new DataSet("MAPELICULA");
                    da.Fill(ds, "MAPELICULA");
                    dt = ds.Tables["MAPELICULA"];
                    byte[] datos = new byte[0];
                    int i = -1;
                    foreach (DataRow dr in dt.Rows)
                    {
                        // se hace incrementable la variable I
                        i++;
                        datos = (byte[])dr["bimagen"];
                        // se captura el id de la pelicula
                        string peli = dr["iidpelicula"].ToString();
                        PictureBox pb = new PictureBox();
                        //dibuja los picture box con sus  propiedades 
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                        pb.Image = System.Drawing.Bitmap.FromStream(ms);
                        // se multiplica por la variable i para que valla aumentando el ancho  de la imagen en la pelicula
                        pb.Size = new System.Drawing.Size(250, 320);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        // ala hora de hacer click en el picturebox se envia la variable de la pelicula
                        pb.Click += new EventHandler((sender1, e1) => PB_Click(sender1, e1, peli));
                        flowLayoutPanel1.Controls.Add(pb);

                    }
                }
            }

            

            

            

          

       
       


       

        
       

    }
}