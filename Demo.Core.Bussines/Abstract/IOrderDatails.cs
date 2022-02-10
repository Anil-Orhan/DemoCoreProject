using Demo.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Core.Bussines.Abstract
{
    public interface IOrderDatails
    {
        OrderDatails GetById(int orderDetailId);
        List<OrderDatails> GetAll();

        void Add(OrderDatails orderDatails);
        void Delete(OrderDatails orderDatails);
        void Update(OrderDatails orderDatails);

    }
}
