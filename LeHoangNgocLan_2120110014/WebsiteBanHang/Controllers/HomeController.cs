using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanHang.Context;

namespace WebsiteBanHang.Controllers
{
    public class HomeController : Controller
    {
        WebsiteBHEntities3 obj = new WebsiteBHEntities3();
        public ActionResult Index()
        {
            var lstProduct = obj.tb_Product.ToList();
            return View(lstProduct);
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