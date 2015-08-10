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

        public static int Autentificar (String txtUsuario, String txtContra)
        {
            int resultado = -1;

            MySqlConnection conexion = clascrearConexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(String.Format("select * from MAREGISTROPERSONAL where vusuario = '{0}' and vcontrasenia = '{1}'", txtUsuario, txtContra),conexion);

            MySqlDataReader reader = comando.ExecuteReader();

            while(reader.Read())
            {
                resultado = 50;
            }
            conexion.Close();
            return resultado;
        }

    }

    }

