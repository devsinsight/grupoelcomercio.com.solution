using System.Runtime.Serialization;

namespace grupoelcomercio.com.OrdenDePago.Entities
{
    [DataContract]
    public enum Estado
    {
        [EnumMember]
        Pagada,
        [EnumMember]
        Declinada,
        [EnumMember]
        Fallida,
        [EnumMember]
        Anulada
    }
}
