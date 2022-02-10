using Demo.Core.Bussines.Abstract;
using Demo.Core.Dal.Abstract;
using Demo.Core.Dal.Concrete;
using Demo.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Core.Bussines.Concrete
{
    public class OrderDetailManager : IOrderDatails
    {
        IOrderDetailsDal _orderDal;

        public OrderDetailManager(IOrderDetailsDal orderDal)
        {
            _orderDal = orderDal;
        }


        public void Add(OrderDatails orderDatails)
        {
            _orderDal.Add(orderDatails);
        }

        public void Delete(OrderDatails orderDatails)
        {
            _orderDal.Delete(orderDatails);  
        }

        public List<OrderDatails> GetAll()
        {
          return _orderDal.GetList();   
        }

        public OrderDatails GetById(int orderDetailId)
        {
            return _orderDal.Get(p=>p.OrderID==orderDetailId);
        }

        public void Update(OrderDatails orderDatails)
        {
            _orderDal.Update(orderDatails);
        }
    }
}
