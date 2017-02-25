using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace grupoelcomercio.com.api.Commands
{
    public class RegistrarSucursal : ICommand
    {
        public Guid Id => Guid.NewGuid();

        public Guid BancoId { get; set; }
        public string NombreSucursal { get; set; }

        public string DireccionSucursal { get; set; }
    }
}