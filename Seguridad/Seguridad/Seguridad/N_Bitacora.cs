using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Bitacora
{
    public class N_Bitacora : D_Bitacora
    {
        public System.Data.DataTable GetAll()
        {
            return D_Bitacora.ObtenerRegistros();
        }

        public void Insertar_Registro(E_Bitacora pBitacora)
        {
            int resultado = D_Bitacora.Agregar(pBitacora);
        }
    }
}
