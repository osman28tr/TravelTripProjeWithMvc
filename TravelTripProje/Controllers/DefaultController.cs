using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class DefaultController : Controller
    {
        Context context = new Context();
        public ActionResult Index()
        {
            var degerler = context.Blogs.ToList();
            return View(degerler);
        }

        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            return PartialView();
        }
    }
}