using System;
using System.Runtime.Serialization;

namespace grupoelcomercio.com.OrdenDePago.Entities
{
    [DataContract]
    public class Orden : IEntity
    {
        public Orden(decimal monto, TipoMoneda tipoMoneda, Estado estado)
        {
            Monto = monto;
            TipoMoneda = tipoMoneda;
            Estado = Estado;
        }
        [DataMember]
        public Guid Id { get; set; } = Guid.NewGuid();

        [DataMember]
        public Banco Banco { get; set; }

        [DataMember]
        public decimal Monto { get; set; }

        [DataMember]
        public TipoMoneda TipoMoneda { get; set; }

        [DataMember]
        public Estado Estado { get; set; }

        public void CrearBanco(string nombre, string direccion)
        {
            Banco = new Banco(nombre, direccion);
        }

    }
}
