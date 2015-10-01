using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data.Common;
using System.Data;

namespace ConexionODBC
{
    class Datos
    {
        #region Insercion
        public static OdbcCommand insert(string tabla, string campos, string datos)
        {
            string query = string.Format("INSERT INTO {0} ({1}) VALUES({2});) ", tabla, campos, datos);
            OdbcCommand comando = new OdbcCommand(query, Conexion.ObtenerConexion());

            //MaUsuario
            //iidtabla,vnombre,vapellido;
            //'1',juan,lopez
            //where iidtabla=1;

            //INSERT INTO MaUsuario (iidtabla,vnombre,vapellido) VALUES('1',juan,lopez) where iidtabla=1; 
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return null;
            }
            return comando;
        }
        #endregion

        #region Borrado
        public static OdbcCommand delete(string tabla, string campo,int id)
        {

            string query = string.Format("UPDATE {0} SET beliminado=1 WHERE {1}={2};", tabla, campo, id);
            OdbcCommand comando = new OdbcCommand(query, Conexion.ObtenerConexion());
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            return comando;
        }
        #endregion

        #region Actualizacion
        public static OdbcCommand actualizar(string tabla, string datos, string validaciones)
        {
            string query = string.Format("UPDATE {0} SET {1} WHERE {2};", tabla, datos, validaciones);
            OdbcCommand comando = new OdbcCommand(query, Conexion.ObtenerConexion());
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            return comando;
        }
        #endregion

        //hacerlo funcionar
        #region DataSet
        public static OdbcCommand dataset(string tabla, string campos, string datos, string validaciones)
        {
            string query = string.Format("UPDATE {0} SET {1} {2};", tabla, datos, validaciones);
            OdbcCommand comando = new OdbcCommand(query, Conexion.ObtenerConexion());
            try
            {/*
                comando.ExecuteNonQuery();
                DataAdapter adapter = new DataAdapter(queryString, connection);
                DataSet customers = new DataSet();
                adapter.Fill(customers, "Customers");*/
            }
            catch (Exception ex)
            {

            }
            return comando;
        }
        #endregion

        #region Datatable
        public static DataTable datatable(string tabla, string campos, string datos, string validaciones)
        {
            DataTable dt = new DataTable();
            string query = string.Format("SELECT {0} FROM {1} {2};", datos, tabla, validaciones);
            OdbcCommand comando = new OdbcCommand(query, Conexion.ObtenerConexion());
            OdbcDataAdapter da = new OdbcDataAdapter();
            da.SelectCommand = comando;
            da.Fill(dt);

            return dt;
        }
        #endregion

        #region Reader
        public static DbDataReader reader()
        {
            
            return reader;
        }
        #endregion
    }
}
