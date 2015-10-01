using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Errores
{
    class cErrorN:cErrorD
    {
        public void insert(cError pEreor)
        {
            if ((pEreor.iIdUsuario==null) || (pEreor.iIdAccion==null))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                int resultado = cErrorD.Agregar(pEreor);

                if (resultado > 0)
                {
                    MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        public cError ErrorUsuario(int id)
        {
            cError pCliente = new cError();
            pCliente.iIdUsuario = id;
            return cErrorD.Consultar(pCliente);
        }
        public DataTable ErrorAdmin()
        {
            cError pCliente = new cError();
            return cErrorD.Registros();
        }
    }
}
