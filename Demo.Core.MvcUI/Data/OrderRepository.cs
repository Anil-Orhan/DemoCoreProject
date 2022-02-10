using System.Collections.Generic;
using Demo.Core.Bussines.Concrete;
using Demo.Core.Dal.Concrete;
using Demo.Core.Entities.Concrete;

namespace Demo.Core.MvcUI.Data
{
    public static class OrderRepository
    {
        private static readonly List<Order> _orders = null;

        static OrderRepository()
        {
            OrderManager orderManager = new OrderManager(new EfOrderDal());
            _orders = orderManager.GetAll();
        }

        public static List<Order> GetAll()
        {
            return _orders;
        }



    }
}
