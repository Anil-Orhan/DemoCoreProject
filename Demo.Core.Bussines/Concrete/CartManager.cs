using Demo.Core.Bussines.Abstract;
using Demo.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.Core.Bussines.Concrete
{
    public class CartManager : ICartService
    {
        List<OrderDatails> _od=new List<OrderDatails>();
        public void AddToCart(Cart cart, Products product)
        {
            CartLine cartLine = cart.CartLine.FirstOrDefault(x => x.Product.ProductID == product.ProductID);
            if (cartLine!=null) { cartLine.Quantity++;
                return;
            }
        }

        public List<CartLine> List(Cart cart)
        {
            return cart.CartLine.ToList();
        }

        public void Order(Cart cart)
        {
            if (PaymentSystem.Pay(cart))
            {
                foreach (var item in cart.CartLine)
                {
                    OrderDatails orderDatails = new OrderDatails();
                    orderDatails.ProductID = item.Product.ProductID;
                    orderDatails.Quantity = item.Quantity;
                    orderDatails.UnitPrice = item.Product.UnitPrice;
                    _od.Add(orderDatails);
                }
            }
            else { Console.WriteLine("PARANIZ YOK!"); }
        }

        public void RemoveToCart(Cart cart, int productID)
        {
            cart.CartLine.Remove(cart.CartLine.FirstOrDefault(x => x.Product.ProductID == productID));
        }


    }
}
