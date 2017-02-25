using grupoelcomercio.com.api.CommandHandler;
using grupoelcomercio.com.api.Commands;
using grupoelcomercio.com.OrdenDePago.Contracts;
using System.Web.Http;
using System.Web.Http.Cors;

namespace grupoelcomercio.com.api.Api
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/orden")]
    public class OrdenController : ApiController
    {

        private readonly IOrdenRepository _ordenRepository;
        private readonly ICommandHandler<PagarOrden> _handler;
        public OrdenController(IOrdenRepository ordenRepository, ICommandHandler<PagarOrden> handler)
        {
            _ordenRepository = ordenRepository;
            _handler = handler;
        }

        [HttpGet]
        [Route("{nombreSucursal}/{nombreTipoMoneda}")]
        public IHttpActionResult ObtenerOrdenes(string nombreSucursal, string nombreTipoMoneda)
        {
            var result = _ordenRepository.ObtenerOrdenes(nombreSucursal, nombreTipoMoneda);

            return Ok(result);
        }

        [HttpPost]
        [Route("PagarOrden")]
        public IHttpActionResult PagarOrden([FromBody] PagarOrden pagarOrden)
        {
            _handler.Handle(pagarOrden);

            return Ok(pagarOrden);
        }

    }
}
