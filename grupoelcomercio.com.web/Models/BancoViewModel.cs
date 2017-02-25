using System.ComponentModel.DataAnnotations;

namespace grupoelcomercio.com.web.Models
{
    public class BancoViewModel
    {
        [Required]
        public string NombreBanco { get; set; }
        public string DireccionBanco { get; set; }

    }
}