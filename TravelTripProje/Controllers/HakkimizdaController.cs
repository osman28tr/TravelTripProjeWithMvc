﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class HakkimizdaController : Controller
    {
        // GET: Hakkimizda
        Context context = new Context();
        public ActionResult Index()
        {
            var degerler = context.Hakkimizdas.ToList();
            return View(degerler);
        }
    }
}