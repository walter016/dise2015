using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;


namespace Bitacora
{
    #region Conexión A Datos - CAD
    public class CAD
    {
        private static OdbcConnection mySqlConeccion;
        public static OdbcConnection ObtenerConexion()
        {
            mySqlConeccion = new OdbcConnection("Driver={MySQL ODBC 5.3 ANSI Driver};Server=localhost;Database=colchoneria;User=root;Password=; Option=3;");
            mySqlConeccion.Open();

            return mySqlConeccion;
        }

        #region Insertar Registro

        public static OdbcCommand inserta(string comand)
        {
            OdbcCommand comando = new OdbcCommand(comand, CAD.ObtenerConexion());
            try
            {
                comando.ExecuteNonQuery();
            }
            catch
            {

            }
            return comando;
        }
        #endregion
    }
    #endregion
}

