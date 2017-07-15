using System.Web.Mvc;

namespace GestaoComercial.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        [Route("~/")]
        public ActionResult Index()
        {
            return View();
        }

        //[Route("~/sobre")]
        //public ActionResult About()
        //{
        //    ViewBag.Message = "Esta é a descrição da minha aplicação.";

        //    return View();
        //}

        //[HttpGet]
        //[Route("~/contato")]
        //public ActionResult Contact()
        //{
        //    return View();
        //}

        //[HttpPost]
        //[Route("~/contato")]
        //public ActionResult Contact(FormCollection model)
        //{
        //    return View();
        //}
    }
}