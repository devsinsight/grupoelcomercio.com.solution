using grupoelcomercio.com.OrdenDePago.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace grupoelcomercio.com.OrdenDePago.Contracts
{
    public interface IOrdenRepository
    {
        List<Orden> ObtenerOrdenes(string tipoMoneda, string nombreSucursal);
        List<Sucursal> ObtenerSucursalesPorBanco(string nombreBanco);
        Task RegistrarOrdenDePago(Orden orden);

        Task RegistrarSucursal(Sucursal sucursal);

        Task RegistrarBanco(Banco banco);
        List<Banco> ObtenerBancos();

        Banco ObtenerBancoPorId(Guid Id);

    }
}
