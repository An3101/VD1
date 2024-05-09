using BoscoWebsite.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoscoWebsite.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class OrderController : Controller
    {
        private ApplicationDbContext dbConnect = new ApplicationDbContext();
        // GET: Admin/Order
        public ActionResult Index(int? page)
        {
            var items = dbConnect.Orders.OrderByDescending(x => x.CreatedDate).ToList();

            if (page == null)
            {
                page = 1;
            }
            var pageNumber = page ?? 1;
            var pageSize = 10;
            ViewBag.PageSize = pageSize;
            ViewBag.Page = pageNumber;
            return View(items.ToPagedList(pageNumber, pageSize));
        }
        public ActionResult View(int id)
        {
            var item = dbConnect.Orders.Find(id);
            return View(item);
        }

        public ActionResult Partial_SanPham(int id)
        {
            var items = dbConnect.orderDetails.Where(x => x.OrderId == id).ToList();
            return PartialView(items);
        }

        [HttpPost]
        public ActionResult UpdateTT(int id, int trangthai)
        {
            var item = dbConnect.Orders.Find(id);
            if (item != null)
            {
                dbConnect.Orders.Attach(item);
                item.TypePayment = trangthai;
                dbConnect.Entry(item).Property(x => x.TypePayment).IsModified = true;
                dbConnect.SaveChanges();
                return Json(new { message = "Success", Success = true });
            }
            return Json(new { message = "Unsuccess", Success = false });
        }

        [HttpPost]
        public ActionResult PlaceOrder(int orderId)
        {
            var order = dbConnect.Orders.FirstOrDefault(x => x.Id == orderId);
            if(order != null)
            {
                var product = dbConnect.products.FirstOrDefault(x => x.Id == order.Id);
                if(product != null)
                {
                    product.Quantity -= order.Quantity;
                }
                dbConnect.SaveChanges();
                return Json(new { message = "Success", Success = true });

            }

            return Json(new { message = "Unsuccess", Success = false });
        }

    }
}