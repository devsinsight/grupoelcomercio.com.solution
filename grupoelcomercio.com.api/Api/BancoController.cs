using grupoelcomercio.com.api.CommandHandler;
using grupoelcomercio.com.api.Commands;
using grupoelcomercio.com.OrdenDePago.Contracts;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace grupoelcomercio.com.api.Api
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/banco")]
    public class BancoController : ApiController
    {

        private readonly ICommandHandler<RegistrarBanco> _handler;
        private readonly IOrdenRepository _ordenRepository;
        public BancoController(ICommandHandler<RegistrarBanco> handler, IOrdenRepository ordenRepository)
        {
            _handler = handler;
            _ordenRepository = ordenRepository;
        }

        [HttpPost]
        [Route("RegistrarBanco")]
        public IHttpActionResult RegistrarBanco([FromBody]RegistrarBanco registrarBanco)
        {
            _handler.Handle(registrarBanco);

            return Ok(registrarBanco);
        }


        [HttpGet]
        [Route("ObtenerBancos")]
        public IHttpActionResult ObtenerBancos()
        {
            var bancos =  _ordenRepository.ObtenerBancos();

            return Ok(bancos);
        }

    }
}
