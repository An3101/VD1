using BoscoWebsite.Models;
using BoscoWebsite.Models.EntityFrame;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoscoWebsite.Controllers
{
    public class NewsController : Controller
    {
        private ApplicationDbContext dbConnect = new ApplicationDbContext();
        // GET: News
        public ActionResult Index(int? page)
        {
            var pageSize = 3;
            if (page == null)
            {
                page = 1;
            }
            IEnumerable<New> items = dbConnect.News.OrderByDescending(x => x.CreatedDate);
            var pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            items = items.ToPagedList(pageIndex, pageSize);
            ViewBag.PageSize = pageSize;
            ViewBag.Page = page;
            return View(items);
        }
        public ActionResult Detail(int id)
        {
            var item = dbConnect.News.Find(id);
            return View(item);
        }
        public ActionResult Partial_News_Home()
        {
            var items = dbConnect.News.Take(3).ToList();
            return PartialView(items);
        }
    }
}