using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MyWS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class WSPersonas : IWSPersonas
    {
        
        public Persona ObtenerPersona(string Contrato)
        {
            if (Contrato == "001")
            {
                return new Persona() { Nombre = "Diego",Edad = 50, Estado = "InActivo" };
            }
            else if (Contrato == "002")
            {
                return new Persona() { Nombre = "Tocayo",Edad = 200,  Estado = "Activo" };
            }
            else
            {
                return new Persona() { Error = "Contrato no encontrado" };
            }
        }
    }
}
