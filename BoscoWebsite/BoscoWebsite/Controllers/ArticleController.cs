using BoscoWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoscoWebsite.Controllers
{
    public class ArticleController : Controller
    {
        private ApplicationDbContext dbConnect = new ApplicationDbContext();
        // GET: Article
        public ActionResult Index(string alias)
        {
            var item = dbConnect.posts.FirstOrDefault(x => x.Alias == alias);
            return View(item);
        }
    }
}