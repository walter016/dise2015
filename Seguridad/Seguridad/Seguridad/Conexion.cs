using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace ConexionODBC
{
    public class Conexion
    {
        private static OdbcConnection Con()
        {
            string connetionString = "Driver={MySQL ODBC 5.3 ANSI Driver};DBQ=COLCHONERIA;";
            OdbcConnection cnn = new OdbcConnection(connetionString);
            try
            {
                cnn.Open();
                
            }
            catch (Exception ex)
            {
                
            }
            return cnn;
        }

        public static OdbcConnection ObtenerConexion()
        {
            return Con();
        }

    }

}
