using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyectoweb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
				public ActionResult ingresar()
				{
					return View();
				}
				public ActionResult ActionIn()
				{
					return View();
				}
				public ActionResult register()
				{
					return View();
				}
				public ActionResult Automovil()
				{
					return View();
				}
    }
}