using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace grupoelcomercio.com.OrdenDePago.Entities
{
    [DataContract]
    public class Banco : IEntity
    {
        public Banco(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
            FechaDeRegistro = DateTime.Now;
            Sucursales = new List<Sucursal>();
        }

        [DataMember]
        public Guid Id { get; set; } = Guid.NewGuid();

        public List<Sucursal> Sucursales { get; set; }

        [DataMember]
        public string Nombre { get; set; }

        [DataMember]
        public string Direccion { get; set; }
        [DataMember]
        public DateTime FechaDeRegistro { get; set; }


    }
}
