using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace website_pertama.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.variable_pertama = "Hello world";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult halaman_pertama()
        {
            ViewBag.nama_saya = "Rio Chandra";
            ViewBag.umur_saya = 19;
            ViewBag.alamat = "bandung";

            ViewData["is_logged_in"] = true;

            return View();
        }

        public ActionResult custom_template()
        {
            return View();
        }
    }
}