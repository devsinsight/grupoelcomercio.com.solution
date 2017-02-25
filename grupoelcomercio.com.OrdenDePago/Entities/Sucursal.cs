using System;
using System.Runtime.Serialization;

namespace grupoelcomercio.com.OrdenDePago.Entities
{
    [DataContract]
    public class Sucursal : IEntity
    {
        [DataMember]
        public Guid Id { get; set; } = Guid.NewGuid();
        public Sucursal(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
            FechaDeRegistro = DateTime.Now;
        }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Direccion { get; set; }
        [DataMember]
        public DateTime FechaDeRegistro { get; set; }
        [DataMember]
        public Banco Banco { get; set; }
    }
}
