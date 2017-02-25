using System.Runtime.Serialization;

namespace grupoelcomercio.com.OrdenDePago.Entities
{

    [DataContract]
    public enum TipoMoneda
    {
        [EnumMember]
        Soles,
        [EnumMember]
        Dolares
    }
}
