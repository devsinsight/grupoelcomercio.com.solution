using grupoelcomercio.com.api.CommandHandler;
using grupoelcomercio.com.api.Commands;
using grupoelcomercio.com.OrdenDePago.Contracts;
using System.Web.Http;
using System.Web.Http.Cors;

namespace grupoelcomercio.com.api.Api
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/sucursal")]
    public class SucursalController : ApiController
    {

        private readonly ICommandHandler<RegistrarSucursal> _handler;
        private readonly IOrdenRepository _ordenRepository;
        public SucursalController(ICommandHandler<RegistrarSucursal> handler, IOrdenRepository ordenRepository)
        {
            _handler = handler;
            _ordenRepository = ordenRepository;
        }

        [HttpPost]
        [Route("RegistrarSucursal")]
        public IHttpActionResult RegistrarBanco([FromBody]RegistrarSucursal registrarSucursal)
        {
            _handler.Handle(registrarSucursal);

            return Ok(registrarSucursal);
        }

        [HttpGet]
        [Route("{nombreBanco}")]
        public IHttpActionResult ObtenerSucursalPorBanco(string nombreBanco)
        {
            var result = _ordenRepository.ObtenerSucursalesPorBanco(nombreBanco);

            return Ok(result);
        }
    }
}
