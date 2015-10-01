using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errores
{
    class cError
    {
        public int iIdUsuario { get; set; }
        public string sFecha { get; set; }
        public string sHora { get; set; }
        public int iAplicacion { get; set; }
        public int iIdAccion { get; set; }
        public cError(int iUser, string sFec,string sHor,int iApp,int iAc)
        {
            this.iIdUsuario = iUser;
            this.sFecha = sFec;
            this.sHora = sHor;
            this.iAplicacion = iApp;
            this.iIdAccion = iAc;
        }

        public cError()
        {
    
        }
    }
}
