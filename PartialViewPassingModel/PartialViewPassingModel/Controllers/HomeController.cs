using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialViewPassingModel.Models;

namespace PartialViewPassingModel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            Product product1 = new Product() { Name = "Pen", Price = 10 };
            Product product2 = new Product() { Name = "Marker", Price = 40 };
            List<Product> productList = new List<Product>();
            productList.Add(product1);
            productList.Add(product2);
            return View(productList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
