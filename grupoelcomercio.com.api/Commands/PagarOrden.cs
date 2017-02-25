using grupoelcomercio.com.OrdenDePago.Entities;
using System;

namespace grupoelcomercio.com.api.Commands
{
    public class PagarOrden : ICommand
    {
        public Guid Id => Guid.NewGuid();

		public Guid BancoId { get;set; }

        public decimal Monto { get; set; }
        public TipoMoneda TipoMoneda { get; set; }

    }
}