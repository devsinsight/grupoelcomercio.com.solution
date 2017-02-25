using System.Collections.Generic;
using grupoelcomercio.com.OrdenDePago.Entities;

namespace grupoelcomercio.com.Repository
{
    public class InMemoryDatabase : IDbContext
    {

        public InMemoryDatabase() {
            Bancos = new List<Banco>();
            Ordenes = new List<Orden>();
            Sucursales = new List<Sucursal>();
        }

        public List<Banco> Bancos { get; set; }

        public List<Orden> Ordenes { get; set; }

        public List<Sucursal> Sucursales { get; set; }
    }
}
