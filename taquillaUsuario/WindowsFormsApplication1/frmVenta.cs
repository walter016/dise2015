using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmVenta : Form
    {
        public frmVenta()
        {
            InitializeComponent();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void venta_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmInformacion);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                frm.Show();
                frm.WindowState = FormWindowState.Normal;

                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frmInformacion();
            frm.Show();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            Form frm = new frmCompra();
            frm.Show();
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void btna1_Click(object sender, EventArgs e)
        {
            switch (Convert.ToInt16(comboBox1.SelectedItem))
            {
                case 1:
                    {
                        if (btna2.BackColor == Color.Green || btna3.BackColor == Color.Green || btna4.BackColor == Color.Green) 
                        {
                            btna2.BackColor = Color.Transparent;
                            btna3.BackColor = Color.Transparent;
                            btna4.BackColor = Color.Transparent;
                            btna1.BackColor = Color.Green; 
                        }
                        else
                            btna1.BackColor = Color.Green; 
                        break;
                    }

            };

            
        }

        private void btna2_Click(object sender, EventArgs e)
        {
            switch (Convert.ToInt16(comboBox1.SelectedItem))
            {
                case 1:
                    {
                        if (btna1.BackColor == Color.Green || btna3.BackColor == Color.Green || btna4.BackColor == Color.Green)
                        {
                            btna1.BackColor = Color.Transparent;
                            btna3.BackColor = Color.Transparent;
                            btna4.BackColor = Color.Transparent;
                            btna2.BackColor = Color.Green;
                        }
                        else
                            btna2.BackColor = Color.Green; 
                        break;
                    }

            };
        }

        private void btna3_Click(object sender, EventArgs e)
        {
            switch (Convert.ToInt16(comboBox1.SelectedItem))
            {
                case 1:
                    {
                        if (btna2.BackColor == Color.Green || btna1.BackColor == Color.Green || btna4.BackColor == Color.Green)
                        {
                            btna2.BackColor = Color.Transparent;
                            btna1.BackColor = Color.Transparent;
                            btna4.BackColor = Color.Transparent;
                            btna3.BackColor = Color.Green;
                        }
                        else
                            btna3.BackColor = Color.Green; 
                        break;
                    }

            };
        }

        private void btna4_Click(object sender, EventArgs e)
        {
            switch (Convert.ToInt16(comboBox1.SelectedItem))
            {
                case 1:
                    {
                        if (btna2.BackColor == Color.Green || btna3.BackColor == Color.Green || btna1.BackColor == Color.Green)
                        {
                            btna2.BackColor = Color.Transparent;
                            btna3.BackColor = Color.Transparent;
                            btna1.BackColor = Color.Transparent;
                            btna4.BackColor = Color.Green;
                        }
                        else
                            btna4.BackColor = Color.Green; 
                        break;
                    }

            };
        }
    }
}
