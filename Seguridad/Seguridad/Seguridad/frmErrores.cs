/* Creacion y Diseño: Hector Joannes Gil Cardona
 * Fecha:13/09/2015
 * 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Errores
{
    public partial class frmErrores : Form
    {
        public frmErrores()
        {
            InitializeComponent();
        }
        private void cargar()
        {
            dgvErroresSistema.DataSource =  new cErrorN().ErrorUsuario(id);
            dgvErroresSistema.Refresh();
        }
    }
}
