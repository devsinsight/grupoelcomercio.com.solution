using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace grupoelcomercio.com.web.Models
{
    public class SucursalViewModel
    {
        [Required]
        public string NombreSucursal { get; set; }

        public string DireccionSucursal { get; set; }

        [Required]
        public Guid BancoId { get; set; }

    }
}