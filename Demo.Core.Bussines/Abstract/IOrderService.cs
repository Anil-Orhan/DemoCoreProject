using Demo.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Core.Bussines.Abstract
{
    public interface IOrderService
    {

        Order GetById(int orderId);
        List<Order> GetAll();

        void Add(Order order);
        void Delete(Order order);
        void Update(Order order);
    }
}
