using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YMS5529_MVC_Sepet.Models.Cart
{
    //Sepetimizdeki ürünler için sınıf
    public class ProductVM
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        //Sepetteki ürün miktarı içindir. Veritabanındaki yani product sınıfımızdaki quantityPerUnit ile alakası yoktur.
        public short Quantity { get; set; }
    }
}