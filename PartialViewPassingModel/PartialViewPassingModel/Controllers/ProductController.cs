using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialViewPassingModel.Models;
using System.Data.Entity;
using System.Net;

namespace PartialViewPassingModel.Controllers
{
    public class ProductController:Controller
    {
         private ProductContext db = new ProductContext();

        public ActionResult Index()
        {
            var product = db.Aproducts;
            return View(product.ToList());
        }



        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                db.Aproducts.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(product);
        }
    }
}