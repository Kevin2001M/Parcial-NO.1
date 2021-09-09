using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KevinMauricioAlvarengaHenriquez.Controllers
{
    public class CajeroController : Controller
    {
        // GET: Cajero

        [HttpPost]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Error()
        {
            return View();
        }
        public ActionResult Correcto()
        {
            return View();
        }
    }
}