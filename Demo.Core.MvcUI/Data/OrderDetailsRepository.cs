using System.Collections.Generic;
using Demo.Core.Bussines.Concrete;
using Demo.Core.Dal.Concrete;
using Demo.Core.Entities.Concrete;

namespace Demo.Core.MvcUI.Data
{
    public static class OrderDetailsRepository
    {
        private static readonly List<OrderDetails> _orderDeList = null;

        static OrderDetailsRepository()
        {
            OrderDetailManager orderDetailManager = new OrderDetailManager(new EfOrderDetailsDal());
            _orderDeList = orderDetailManager.GetAll();
        }

        public static List<OrderDetails> GetAll()
        {
            return _orderDeList;
        }



    }
}
