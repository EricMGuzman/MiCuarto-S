using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiCuarto_S.Controllers
{
    public class TransactionController : Controller
    {
        //
        // GET: /Transaction/
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
	}
}