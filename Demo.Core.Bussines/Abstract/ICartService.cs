using Demo.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Core.Bussines.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart, Products product);
        void RemoveToCart(Cart cart, int productID);
        List<CartLine> List(Cart cart);

        void Order(Cart cart);


    }
}
