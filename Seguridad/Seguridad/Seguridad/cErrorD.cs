using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;

namespace Errores
{
    class cErrorD:ConexionODBC.Datos
    {
        public static int Agregar(cError pError)
        {
            int iValorRetorno = 0;
            string sTabla="MaTIPOERROR";
            string sCampos="dhora, dfecha, iidAplicacion, iidUsuario,iidAccion";
            string sDatos = string.Format("DATE_FORMAT(CURTIME(), '%h:%i:%s'),CURDATE(),{0},{1},{2}", pError.iAplicacion, pError.iIdUsuario, pError.iIdAccion);
            ConexionODBC.Datos.insert(sTabla, sCampos, sDatos);
            return iValorRetorno;
        }

        public static cError Consultar(cError eError)
        {
            cError pError = new cError();
            try
            {

                OdbcDataReader Lector = ConexionODBC.Datos.reader();

                if (Lector.Read())
                {
                    if (Lector.HasRows)
                    {
                        pError.iIdUsuario = (int)Lector["Usuario"];
                        pError.iIdAccion = (int)Lector["Aplicacion"];
                        pError.iAplicacion = (int)Lector["Accion Realizada"];
                        pError.sFecha = Convert.ToString(Lector["Hora"]);
                        pError.sHora = Convert.ToString(Lector["Fecha"]);
                    }
                }
            }
            catch (Exception e)
            {
            }

            return pError;
        }

        public static DataTable Registros()
        {
            cError pError = new cError();
            DataTable dtRegistros = new DataTable();

            try
            {
                string sTabla = "MaTIPOERROR";
                string sCampos = "dhora, dfecha, iidAplicacion, iidUsuario,iidAccion";
                string sDatos = string.Format("DATE_FORMAT(CURTIME(), '%h:%i:%s'),CURDATE(),{0},{1},{2}", pError.iAplicacion, pError.iIdUsuario, pError.iIdAccion);
                string sValidacion = "Where iidUsuario=" + pError.iIdUsuario;
                dtRegistros = ConexionODBC.Datos.datatable(sTabla, sCampos, sDatos, sValidacion);

            }
            catch (Exception Ex)
            {

            }

            return dtRegistros;
        }
    }
}
