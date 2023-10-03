using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanHang.Context;
using WebsiteBanHang.Models;

namespace WebsiteBanHang.Controllers
{
    public class HomeController : Controller
    {
        WebsiteBHEntities3 obj = new WebsiteBHEntities3();
        public ActionResult Index()
        {
            HomeModel home = new HomeModel();
            home.ListProduct = obj.tb_Product.ToList();
            home.ListCategory = obj.tb_Category.ToList();
            return View(home);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}