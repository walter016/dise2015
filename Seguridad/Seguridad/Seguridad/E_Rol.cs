using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manejo_Rol
{
    public class E_Rol
    {
         #region Atributos y Encapsulamiento

        public int Id { get; set; }
        public string Nombre { get; set; }
       
       


        #endregion



        #region Constructor

        public E_Rol()
        {

        }

        public E_Rol(int pId, string pNombre )
        {
            this.Id = pId;
            this.Nombre = pNombre;
           
            
        }

        #endregion
    
    }
}
