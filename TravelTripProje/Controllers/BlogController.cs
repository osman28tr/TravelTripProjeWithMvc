using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;
using TravelTripProje.Models.Siniflar.BlogDetayModels;

namespace TravelTripProje.Controllers
{
    public class BlogController : Controller
    {

        Context context = new Context();
        BlogBlogDetayViewModel blogDetayViewModel = new BlogBlogDetayViewModel();
        public ActionResult Index()
        {
            //var bloglar = context.Blogs.ToList();
            blogDetayViewModel.Deger1 = context.Blogs.ToList();
            IEnumerable<Blog> blogs = context.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            ViewBag.Deger2 = blogs;
            return View(blogDetayViewModel);
        }
        public ActionResult BlogDetay(int id)
        {
            //var blogBul = context.Blogs.Where(x => x.ID == id).ToList();
            blogDetayViewModel.Deger1 = context.Blogs.Where(x => x.ID == id).ToList();
            blogDetayViewModel.Deger2 = context.Yorums.Where(x => x.BlogId == id).ToList();
            return View(blogDetayViewModel);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult YorumYap(Yorum yorum)
        {
            context.Yorums.Add(yorum);
            context.SaveChanges();
            return PartialView();
        }
    }
}