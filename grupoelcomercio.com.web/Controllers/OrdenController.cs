using grupoelcomercio.com.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace grupoelcomercio.com.web.Controllers
{
    public class OrdenController : BaseController
    {
        

        public ActionResult Index()
        {
            ViewBag.TipoMonedas = from c in Enum.GetValues(typeof(TipoMoneda)).Cast<TipoMoneda>()
                                  select new { Id = (int)c, Value = c };

            var response = client.GetAsync("api/banco/ObtenerBancos").Result;
            if (response.IsSuccessStatusCode)
                ViewBag.Bancos = response.Content.ReadAsAsync<List<object>>().Result;




            return View();
        }

        [HttpPost]
        public ActionResult Registrar(OrdenViewModel model)
        {
            Task<HttpResponseMessage> response = null;
            string message = SuccessMessage;
            if (ModelState.IsValid)
                response = client.PostAsJsonAsync("api/orden/PagarOrden", model);
            else
                message = ErrorMessage;

            return PartialView(PartialViewResult, new ResultadoViewModel() { Mensage = message });
        }
    }
}
