using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using grupoelcomercio.com.OrdenDePago.Contracts;
using grupoelcomercio.com.OrdenDePago.Entities;
using System.Linq;

namespace grupoelcomercio.com.Repository
{
    public class OrdenRepository : IOrdenRepository
    {
        private IDbContext _dbContext;

        public OrdenRepository(IDbContext dbContext) {
            _dbContext = dbContext;
        }

        public Banco ObtenerBancoPorId(Guid Id)
        {
            return _dbContext.Bancos.Where(x => x.Id == Id).FirstOrDefault();
        }

        public List<Banco> ObtenerBancos()
        {
            return _dbContext.Bancos;
        }

        public List<Orden> ObtenerOrdenes(string nombreSucursal, string tipoMoneda)
        {
            TipoMoneda moneda = tipoMoneda.Equals("Soles", StringComparison.CurrentCultureIgnoreCase) ? TipoMoneda.Soles : TipoMoneda.Dolares;
            return _dbContext.Ordenes.Where(orden => 
                    orden.TipoMoneda == moneda && 
                    orden.Banco.Sucursales.Any(s => s.Nombre == nombreSucursal)).ToList();
        }

        public List<Sucursal> ObtenerSucursalesPorBanco(string nombreBanco)
        {
            return _dbContext.Sucursales.Where(sucursal => sucursal.Banco.Nombre == nombreBanco).ToList();
        }

        public Task RegistrarBanco(Banco banco)
        {
            _dbContext.Bancos.Add(banco);

            return Task.FromResult(banco);
        }

        public Task RegistrarOrdenDePago(Orden orden)
        {
            _dbContext.Ordenes.Add(orden);

            return Task.FromResult(orden);
        }

        public Task RegistrarSucursal(Sucursal sucursal)
        {
            _dbContext.Sucursales.Add(sucursal);

            return Task.FromResult(sucursal);
        }
    }
}
