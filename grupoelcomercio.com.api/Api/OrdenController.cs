using grupoelcomercio.com.api.CommandHandler;
using grupoelcomercio.com.api.Commands;
using grupoelcomercio.com.OrdenDePago.Contracts;
using grupoelcomercio.com.OrdenDePago.Entities;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Web.Http;
using System.Web.Http.Cors;
using System;

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
        public HttpResponseMessage ObtenerOrdenes(string nombreSucursal, string nombreTipoMoneda)
        {
            var result = _ordenRepository.ObtenerOrdenes(nombreSucursal, nombreTipoMoneda);
            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new ObjectContent<List<Orden>>(result, new JsonMediaTypeFormatter(), "application/json");
            return response;

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
