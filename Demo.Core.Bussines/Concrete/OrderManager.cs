using Demo.Core.Bussines.Abstract;
using Demo.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Demo.Core.Dal.Abstract;

namespace Demo.Core.Bussines.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderService;
        public OrderManager(IOrderDal orderService)
        {
            _orderService = orderService;
        }


        public void Add(Order order)
        {
           _orderService.Add(order);
        }

        public void Delete(Order order)
        {
            _orderService.Delete(order);
        }

        public List<Order> GetAll()
        {
            return _orderService.GetList();
        }

        public Order GetById(int orderId)
        {
            return _orderService.Get(p=>p.OrderID==orderId);  
        }

        public void Update(Order order)
        {
           _orderService.Update(order);
        }
    }
}
