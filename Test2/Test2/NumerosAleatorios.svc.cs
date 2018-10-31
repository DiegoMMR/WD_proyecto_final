using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Test2.Models;

namespace Test2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "NumerosAleatorios" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select NumerosAleatorios.svc or NumerosAleatorios.svc.cs at the Solution Explorer and start debugging.
    public class NumerosAleatorios : INumerosAleatorios
    {
   


        public prueba ObtenerNumeros()
        {
            var aleatorio = new Random();

            var numberobject = new prueba
            {
                number1 = aleatorio.Next(-10000, 8),
                number2 = aleatorio.Next(-10000, 8),
                number3 = aleatorio.Next(-10000, 8)
            };

            return numberobject;
        }
    }
}
