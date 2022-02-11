using Demo.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Core.Bussines.Abstract
{
    public interface IOrderDatails
    {
        OrderDetails GetById(int orderDetailId);
        List<OrderDetails> GetAll();

        void Add(OrderDetails orderDatails);
        void Delete(OrderDetails orderDatails);
        void Update(OrderDetails orderDatails);

    }
}
