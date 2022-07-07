using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class IletisimController : Controller
    {
        // GET: Iletisim
        Context context = new Context();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(İletisim iletisim)
        {
            context.İletisims.Add(iletisim);
            context.SaveChanges();
            return RedirectToAction("Index", new { controller = "Default" });
        }
    }
}