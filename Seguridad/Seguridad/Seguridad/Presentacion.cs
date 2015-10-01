using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitacora
{
    public partial class Presentacion : Form
    {
         public Presentacion()
        {
            InitializeComponent();
        }

         private void Presentacion_Load(object sender, EventArgs e)
         {
             ActualizarForm();
         }
         private void ActualizarForm()
         {
             try
             {
                 dGVBitacora.DataSource = new N_Bitacora().GetAll();
                 dGVBitacora.Refresh();
             }
             catch (Exception Ex)
             {
                 MessageBox.Show(Ex.Message);
             }
         }
    }
}
