
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Manejo_Rol
{
    public class D_Rol:Bitacora.CAD
    {
        private static OdbcCommand mySqlComando;
        private static OdbcDataAdapter mySqlDAdAdaptador;

        public static List<E_Rol> Buscar(string pNombre, string pApellido)
        {
            List<E_Rol> _lista = new List<E_Rol>();

          try
            {
            OdbcCommand _comando = new OdbcCommand(String.Format(
           "SELECT iidUsuario, vnombreUsuario, vapellidoUsuario, vemailUsuario FROM MAUSUARIO where vnombreUsuario ='{0}' or vapellidoUsuario='{1}'", pNombre, pApellido), Bitacora.CAD.ObtenerConexion());
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                E_Rol pEmpleado = new E_Rol();
                pEmpleado.Id = _reader.GetInt32(0);
                pEmpleado.Nombre = _reader.GetString(1);
               
              


                _lista.Add(pEmpleado);
            }
            }
          catch (Exception e)
          {
              MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }
            return _lista;
        }

        #region Consultar Perfiles
        public static DataTable consultaPerfil()
        {
            DataTable dt1 = new DataTable();
            dt1.Clear();
            string consulta = "select iidRole,vnombreRole from MAROLUSUARIO;";
            OdbcDataAdapter da = new OdbcDataAdapter(consulta, Bitacora.CAD.ObtenerConexion());
            da.Fill(dt1);
            return dt1;
        }
        #endregion

        #region Consultar Apps
        public static DataTable consultaApps()
        {
            DataTable dt2 = new DataTable();
            dt2.Clear();
            string consulta = "select iidAplicacion,vnombreAplicacion from MaAPLICACION;";
            OdbcDataAdapter da = new OdbcDataAdapter(consulta, Bitacora.CAD.ObtenerConexion());
            da.Fill(dt2);
            return dt2;
        }
        #endregion



    }
}
