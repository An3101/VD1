﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoscoWebsite.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [Authorize(Roles = "Admin,Employee")]
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}