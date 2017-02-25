using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace grupoelcomercio.com.web.Models
{
    public class OrdenViewModel
    {
        [Required]
        public Guid BancoId { get; set; }

        
        public TipoMoneda TipoMoneda { get; set; }

        [Required]
        public decimal Monto { get; set; }

    }
}