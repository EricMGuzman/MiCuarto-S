using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiCuarto_S.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Authorize]
        public ActionResult Transacciones()
        {
            ViewBag.Message = "Pagina de transacciones.";
            return View();
        }

        [Authorize]
        public ActionResult Presupuesto()
        {
            ViewBag.Message = "Pagina de Presupuesto.";
            return View();
        }

        [Authorize]
        public ActionResult Opciones()
        {
            ViewBag.Message = "Pagina de Opciones.";
            return View();
        }
    }
}