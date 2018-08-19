using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YMS5529_MVC_Sepet.Models;

namespace YMS5529_MVC_Sepet.Controllers
{
    public class ProductController : Controller
    {
        NorthwindEntities db;

        public ProductController()
        {
            db = new NorthwindEntities();
        }

        public ActionResult List(int? id)
        {
            if (id == null) return RedirectToAction("List", "Category");


            return View(db.Products.Where(x => x.CategoryID == id).ToList());
        }
    }
}