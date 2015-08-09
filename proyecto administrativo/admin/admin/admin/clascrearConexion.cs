using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace admin
{
    class clascrearConexion
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=taquilla; Uid=root; pwd=;");
            conectar.Open();
            return conectar;
        }
        public static MySqlCommand inserta(string comand)
        {
            MySqlCommand comando = new MySqlCommand(comand, clascrearConexion.ObtenerConexion());
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
