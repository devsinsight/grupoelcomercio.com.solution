using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Mvc;

namespace grupoelcomercio.com.web.Controllers
{
    public class BaseController : Controller
    {
        internal HttpClient client = new HttpClient();
        internal const string PartialViewResult = "~/Views/Common/Resultado.cshtml";
        internal const string SuccessMessage = "Se Registró Correctamente ☻";
        internal const string ErrorMessage = "Ocurrió un Error :'(";
        public BaseController()
        {
            client.BaseAddress = new Uri("http://localhost:21753");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }


    }
}
