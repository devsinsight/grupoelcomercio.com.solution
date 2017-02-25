using grupoelcomercio.com.web.Models;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace grupoelcomercio.com.web.Controllers
{
    public class BancoController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(BancoViewModel model)
        { 
            string message = SuccessMessage;
            if (ModelState.IsValid)
                client.PostAsJsonAsync("api/banco/RegistrarBanco", model);
            else
                message = ErrorMessage;

            return PartialView(PartialViewResult, new ResultadoViewModel() { Mensage = message });
        }
    }
}
