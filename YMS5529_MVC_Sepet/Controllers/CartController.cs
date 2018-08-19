using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YMS5529_MVC_Sepet.Models;
using YMS5529_MVC_Sepet.Models.Cart;

namespace YMS5529_MVC_Sepet.Controllers
{
    public class CartController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// aaaaaaaaaaaaaaaaaaaaaaaaaaa
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult add(int id)
        {
            Product sepetEklenecekUrun = db.Products.Find(id);

            ProductVM model = new ProductVM
            {
                ID = sepetEklenecekUrun.ProductID,
                ProductName = sepetEklenecekUrun.ProductName,
                UnitPrice = (decimal)sepetEklenecekUrun.UnitPrice,
                Quantity = 1
            };
            if (Session["sepet"]!=null)
            {
                ProductCart cart = Session["sepet"] as ProductCart;
                Session["sepet"] = cart;

            }
            else
            {
                ProductCart cart = new ProductCart();
                cart.AddCart(model);
                Session.Add("sepet", cart);
            }

            return Json("sepete eklendi");
        }
    }
}