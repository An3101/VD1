using BoscoWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoscoWebsite.Controllers
{
    public class ProductsController : Controller
    {
        private ApplicationDbContext dbConnect = new ApplicationDbContext();
        // GET: Products
        public ActionResult Index()
        {
            var items = dbConnect.products.ToList();

            return View(items);
        }
        public ActionResult Detail(string alias, int id)
        {
            var item = dbConnect.products.Find(id);
            if (item != null)
            {
                dbConnect.products.Attach(item);
                item.ViewCount = item.ViewCount + 1;
                dbConnect.Entry(item).Property(x => x.ViewCount).IsModified = true;
                dbConnect.SaveChanges();
            }

            return View(item);
        }
        public ActionResult ProductCategory(string alias, int id)
        {
            var items = dbConnect.products.ToList();
            if (id > 0)
            {
                items = items.Where(x => x.ProductCategoryId == id).ToList();
            }
            var cate = dbConnect.productCategories.Find(id);
            if (cate != null)
            {
                ViewBag.CateName = cate.Title;
            }

            ViewBag.CateId = id;
            return View(items);
        }

        public ActionResult Partial_ItemsByCateId()
        {
            var items = dbConnect.products.Where(x => x.IsHome && x.IsActive).Take(12).ToList();
            return PartialView(items);
        }

        public ActionResult Partial_ProductSales()
        {
            var items = dbConnect.products.Where(x => x.IsSale && x.IsActive).Take(12).ToList();
            return PartialView(items);
        }
    }
}