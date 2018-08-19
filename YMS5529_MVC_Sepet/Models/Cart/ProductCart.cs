using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YMS5529_MVC_Sepet.Models.Cart
{
    //Sepet için sınıfımız
    public class ProductCart
    {
        //Dictionary isimli koleksiyon yapısını kullanıyoruz.

        private Dictionary<int, ProductVM> _cart = null;

        public ProductCart()
        {
            _cart = new Dictionary<int, ProductVM>();
        }

        public List<ProductVM> CartProductList
        {
            get
            {
                //Bunun sayesinde sınıf dışından sepeti istediğimizde hep kullandığımız List yapısı olarak teslim edilecek.
                return _cart.Values.ToList();
            }
        }


        #region Sepete Ürün Ekleme

        public void AddCart(ProductVM item)
        {
            //Eğer sepette yoksa yeni ürün ekle
            if (!_cart.ContainsKey(item.ID))
            {
                _cart.Add(item.ID, item);
            }
            else
            {
                //Eğer zaten varsa yeni ürün ekleme, var olanın miktarını arttır.
                _cart[item.ID].Quantity++;
            }
        }
        #endregion

        #region Sepetten Ürün Silme
        public void RemoveCart(int id)
        {
            _cart.Remove(id);
        }
        #endregion

        #region Sepetteki Ürün Miktarını Azaltma
        public void DecreaseCart(int id)
        {
            //Sepetteki ürün miktarını bir azaltıyoruz.
            //Eğer sepette o üründen hiç kalmadıysa sepetten siliyoruz.
            _cart[id].Quantity--;
            if (_cart[id].Quantity <= 0) _cart.Remove(id);
        }
        #endregion

        #region Sepetteki Ürün Miktarını Arttırma
        public void IncreaseCart(int id)
        {
            _cart[id].Quantity++;
        }
        #endregion

        #region Sepete Toplu Ürün Ekleme
        public void IncreaseCart(int id, short quantity)
        {
            //Sepete birden fazla(Toplu) ürün eklemek için parametreden istersek ürün miktarını alabiliriz.
            _cart[id].Quantity += quantity;
        }

        #endregion

    }
}