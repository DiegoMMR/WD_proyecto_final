using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Test2.Models;

namespace Test2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "INumerosAleatorios" in both code and config file together.
    [ServiceContract]
    public interface INumerosAleatorios
    {
        [OperationContract]
        prueba ObtenerNumeros();
    }
}
