using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestaoComercial.Web.Controllers
{
    public class HomeController : Controller
    {
        [Route("~/")]
        public ActionResult Index()
        {
            return View();
        }

        //[Route("~/redirecionar")]
        //public ActionResult Redirecionar()
        //{
        //    return RedirectToAction("Index");
        //}

        //[Route("~/partial")]
        //public ActionResult Partial()
        //{
        //    return PartialView("_LoginPartial");
        //}

        [Route("~/sobre")]
        public ActionResult About()
        {
            ViewBag.Message = "Esta é a descrição da minha aplicação.";

            return View();
        }

        [HttpGet]
        [Route("~/contato")]
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [Route("~/contato")]
        public ActionResult Contact(FormCollection model)
        {
            return View();
        }
    }
}