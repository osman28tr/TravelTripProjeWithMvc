using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar.BlogDetayModels
{
    public class BlogBlogDetayViewModel
    {
        public IEnumerable<Blog> Deger1 { get; set; }

        public IEnumerable<Yorum> Deger2 { get; set; }
    }
}