/* Diseñador y Creador: Hector Joannes Gil Cardona
 * Fecha de Creacion y Modificacion:25/08/2015

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

namespace admin
{
    public partial class frmtipoUsuario : Form
    {
        public frmtipoUsuario()
        {
            InitializeComponent();
        }
        //metodo para guardar el registro por medio de una dll
        private void bguardar_Click(object sender, EventArgs e)
        {

            String resultado = null;// varible de resultado para limpiar el textbox 
            insertTypeUser.insertTyperUser insercion = new insertTypeUser.insertTyperUser();//instanciado de la dll
            insercion.insertar(txttipoUsuario.Text);// llamando al void de la dll y mandando su parametro
            resultado = insercion.numero.ToString(); // obteniendo el resultado de la dll

            if (resultado == "1") // si en tal caso la dll le manda 1 se limpia el textbox
            {
                txttipoUsuario.ResetText();
            }
        }
    }
}
