using grupoelcomercio.com.web.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Mvc;

namespace grupoelcomercio.com.web.Controllers
{
    public class SucursalController : BaseController
    {

        public ActionResult Index()
        {
            SucursalViewModel model = new SucursalViewModel();
            var response = client.GetAsync("api/banco/ObtenerBancos").Result;
            if (response.IsSuccessStatusCode)
                ViewBag.Bancos = response.Content.ReadAsAsync<List<object>>().Result;
            

            return View();
        }

        [HttpPost]
        public ActionResult Registrar(SucursalViewModel model)
        {
            
            string message = "";
            if (ModelState.IsValid)
            {
                message = SuccessMessage;
                client.PostAsJsonAsync("api/sucursal/RegistrarSucursal", model);
            }
            else
            {
                message = ErrorMessage;
            }


            return PartialView(PartialViewResult, new ResultadoViewModel() { Mensage = message });
        }

        
    }
}
