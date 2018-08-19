using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YMS5529_MVC_Sepet.Models;

namespace YMS5529_MVC_Sepet.Controllers
{
    public class CategoryController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        public ActionResult List()
        {
            return View(db.Categories.ToList());
        }
    }
}