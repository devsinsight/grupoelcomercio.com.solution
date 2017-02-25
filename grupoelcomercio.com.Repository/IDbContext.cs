using grupoelcomercio.com.OrdenDePago.Entities;
using System.Collections.Generic;

namespace grupoelcomercio.com.Repository
{
    public interface IDbContext
    {

        List<Orden> Ordenes { get; set; }
        List<Banco> Bancos { get; set; }
        List<Sucursal> Sucursales { get; set; }
    }
}
