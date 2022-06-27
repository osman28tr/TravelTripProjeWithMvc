﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class BlogController : Controller
    {

        Context context = new Context();
        public ActionResult Index()
        {
            var bloglar = context.Blogs.ToList();
            return View(bloglar);
        }
    }
}