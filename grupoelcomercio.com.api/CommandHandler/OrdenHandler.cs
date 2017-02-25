using grupoelcomercio.com.api.Commands;
using grupoelcomercio.com.OrdenDePago.Contracts;
using grupoelcomercio.com.OrdenDePago.Entities;
using System;
using System.Threading.Tasks;

namespace grupoelcomercio.com.api.CommandHandler
{
    public class OrdenHandler : 
        ICommandHandler<PagarOrden>,
        ICommandHandler<RegistrarBanco>,
        ICommandHandler<RegistrarSucursal>
    {

        private readonly IOrdenRepository _ordenRepository;
        public OrdenHandler(IOrdenRepository ordenRepository)
        {
            _ordenRepository = ordenRepository;
        }

        public async Task Handle(RegistrarSucursal command)
        {
            Sucursal sucursal = new Sucursal(command.NombreSucursal, command.DireccionSucursal);
            var banco = _ordenRepository.ObtenerBancoPorId(command.BancoId);
            sucursal.Banco = banco;
            sucursal.Banco.Sucursales.Add(sucursal);

            await _ordenRepository.RegistrarSucursal(sucursal);
        }

        public async Task Handle(RegistrarBanco command)
        {
            Banco banco = new Banco(command.NombreBanco, command.DireccionBanco);
            await _ordenRepository.RegistrarBanco(banco);
        }

        public async Task Handle(PagarOrden command)
        {
            Orden orden = new Orden(command.Monto, command.TipoMoneda, Estado.Pagada);
            var banco = _ordenRepository.ObtenerBancoPorId(command.BancoId);
            orden.Banco = banco;

            await _ordenRepository.RegistrarOrdenDePago(orden);
        }
    }
}