using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class AdminIletisimController : Controller
    {
        // GET: AdminIletisim
        Context context = new Context();
        public ActionResult Index()
        {
            var mesajlar = context.İletisims.ToList();
            return View(mesajlar);
        }
    }
}