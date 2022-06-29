using System;
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
        BlogYorum blogYorum = new BlogYorum();
        SonBlog sonBlog = new SonBlog();
        public ActionResult Index()
        {
            //var bloglar = context.Blogs.ToList();
            blogYorum.Deger1 = context.Blogs.ToList();
            IEnumerable<Blog> blogs = context.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            ViewBag.Deger2 = blogs;
            return View(blogYorum);
        }
        public ActionResult BlogDetay(int id)
        {
            //var blogBul = context.Blogs.Where(x => x.ID == id).ToList();
            blogYorum.Deger1 = context.Blogs.Where(x => x.ID == id).ToList();
            blogYorum.Deger2 = context.Yorums.Where(x => x.BlogId == id).ToList();
            return View(blogYorum);
        }
    }
}