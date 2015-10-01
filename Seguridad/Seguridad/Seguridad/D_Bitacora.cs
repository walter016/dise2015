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
    public class D_Bitacora
    {
        private static OdbcCommand mySqlComando;
        private static OdbcDataAdapter mySqlDAdAdaptador;

        #region Agregar Registro a la Bitacora
        public static int Agregar(E_Bitacora eBitacora)
        {
            int iValorRetorno = 0;

            string sMachineName = Environment.MachineName;

            mySqlComando = new OdbcCommand(string.Format("INSERT INTO BITACORA (hora, fecha, nombreEquipo) VALUES(DATE_FORMAT(CURTIME(), '%h:%i:%s'),CURDATE(),'{1}',{2},'{3}')", sMachineName,
                eBitacora.hora, eBitacora.fecha),
                CAD.ObtenerConexion());

            iValorRetorno = mySqlComando.ExecuteNonQuery();
            return iValorRetorno;
        }
        #endregion

        #region Obtener Datos de la Bitacora
        public static DataTable ObtenerRegistros()
        {
            DataTable bitacora = new DataTable();

            mySqlComando = new OdbcCommand(string.Format("SELECT nombreEquipo AS 'Nombre del Equipo', hora AS 'Hora', fecha AS 'Fecha' FROM BITACORA"),CAD.ObtenerConexion());
            mySqlDAdAdaptador = new OdbcDataAdapter();
            mySqlDAdAdaptador.SelectCommand = mySqlComando;
            mySqlDAdAdaptador.Fill(bitacora);

            return bitacora;
        }
        #endregion
    }

}
