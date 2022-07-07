using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class YorumController : Controller
    {
        Context context = new Context();
        public ActionResult Index()
        {
            var yorumlar = context.Yorums.ToList();
            return View(yorumlar);
        }
        public ActionResult YorumSil(int id)
        {
            var yorum = context.Yorums.Find(id);
            context.Yorums.Remove(yorum);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YorumGetir(int id)
        {
            var yorum = context.Yorums.Find(id);
            return View("YorumGetir", yorum);
        }
        public ActionResult YorumGuncelle(Yorum yorum)
        {
            var yeniYorum = context.Yorums.Find(yorum.ID);
            yeniYorum.KullaniciAdi = yorum.KullaniciAdi;
            yeniYorum.YorumYazi = yorum.YorumYazi;
            yeniYorum.Mail = yorum.Mail;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}