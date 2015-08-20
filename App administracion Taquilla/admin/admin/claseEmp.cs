using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace admin
{
    class claseEmp
    {
        public static string MyUserName;
        public static int Autentificar (String txtUsuario, String txtContra)
        {
            int resultado = -1;

            MySqlConnection conexion = dllConexion.dllConexion.Conexion();

            MySqlCommand comando = new MySqlCommand(String.Format("SELECT * FROM MAREGISTROPERSONAL WHERE vusuario COLLATE latin1_bin = '{0}' AND vcontrasenia COLLATE latin1_bin = '{1}'", txtUsuario, txtContra), conexion);

            MySqlDataReader reader = comando.ExecuteReader();

            while(reader.Read())
            {
                resultado = 50;
            }
            conexion.Close();
            return resultado;
        }
        public static void Bita(String txtUsuario, int Accion, String table)
        {
            string sMachineName = Environment.MachineName;
            string query = string.Format("INSERT INTO TRBITACORA (vusuario, thora, dfecha, vNombreEquipo,vaccion,vTabla) VALUES('{0}',DATE_FORMAT(CURTIME(), '%h:%i:%s'),CURDATE(),'{1}',{2},'{3}')", txtUsuario, sMachineName, Accion, table);
            dllConexion.dllConexion.inserta(query);

        }

    }

    }

