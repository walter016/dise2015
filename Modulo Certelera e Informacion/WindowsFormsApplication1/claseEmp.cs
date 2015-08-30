using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using dllConexion;

namespace WindowsFormsApplication1
{
    class claseEmp
    {
        public static string MyIdMovie;
        public static string idschedule;
        public static string idioma;
        public static string subti;
        public static string tipoSala;
        public static string Horario;
        public static int Autentificar(String txtUsuario, String txtContra)
        {
            int resultado = -1;

            MySqlConnection conexion = dllConexion.dllConexion.Conexion();

            MySqlCommand comando = new MySqlCommand(String.Format("SELECT * FROM MAREGISTROPERSONAL WHERE vusuario COLLATE latin1_bin = '{0}' AND vcontrasenia COLLATE latin1_bin = '{1}'", txtUsuario, txtContra), conexion);

            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                resultado = 50;
            }
            conexion.Close();
            return resultado;
        }


    }

}

