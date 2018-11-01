using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MyWS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IWSPersonas
    {

        [OperationContract] // sirve para exponer de forma publica los metodos en el WS
        Persona ObtenerPersona(String Contrato); 
        
        // TODO: Add your service operations here
    }

    [DataContract] // expone las clases de forma publica en el WS
    public class Persona : BaseRespuesta
    {
        [DataMember] // muestra informacion en el WS al cliente sin esto no mostrara info
        public string Nombre { get; set; }

        [DataMember]
        public int Edad { get; set; }

        [DataMember]
        public string Estado { get; set; }

        public string oculto { get; set; } // al no tener la propiedad "DataMember" no mostrara nada ni se reflejara en el Cliente
    }

    [DataContract]
    public class BaseRespuesta // propiedades de mensajeria
    {
        [DataMember]
        public string MensajeRespuesta { get; set; }
        [DataMember]
        public string Error { get; set; }
    }
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
