using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;

namespace admin
{
    class classCrearConexion
    {
        public static MySqlConnection obtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=taquilla; Uid=root; pwd=;");
            conectar.Open();
            return conectar;
        }
        public static MySqlCommand inserta(string comand)
        {
            MySqlCommand comando = new MySqlCommand(comand, classCrearConexion.obtenerConexion());
            try
            {
                comando.ExecuteNonQuery();
            }
            catch
            {

            }
            return comando;
        }
    }
}
