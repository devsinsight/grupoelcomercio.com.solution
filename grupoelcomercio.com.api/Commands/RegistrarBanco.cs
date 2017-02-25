using System;

namespace grupoelcomercio.com.api.Commands
{
    public class RegistrarBanco : ICommand
    {
        public Guid Id => Guid.NewGuid();

        public string NombreBanco { get; set; }
        public string DireccionBanco { get; set; }

    }
}