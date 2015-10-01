using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Bitacora
{
    class claseEmp
    {
        public static string MyUserName;
        public static string IdUsuario;
        public static int Autentificar(String txtUsuario, String txtContra)
        {
            int resultado = -1;

            OdbcConnection conexion = CAD.ObtenerConexion();

            OdbcCommand comando = new OdbcCommand(String.Format("SELECT * FROM USUARIO WHERE usuario COLLATE latin1_bin = '{0}' AND password COLLATE latin1_bin = '{1}'", txtUsuario, txtContra), conexion);

            OdbcDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                IdUsuario = reader.GetString(0).ToString();
                resultado = 50;
            }
            conexion.Close();
            return resultado;
        }

        public static void Bita(String txtUsuario, int Accion, String table)
        {
            string sMachineName = Environment.MachineName;
            string query = string.Format("INSERT INTO BITACORA (hora, fecha, nombreEquipo) VALUES(DATE_FORMAT(CURTIME(), '%h:%i:%s'),CURDATE(),'{0}')", sMachineName);
            CAD.inserta(query);
        }
    }
}


