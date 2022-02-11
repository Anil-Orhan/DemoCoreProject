using System.Collections.Generic;
using Demo.Core.Entities.Concrete;
using Demo.Core.MvcUI.Data;

namespace Demo.Core.MvcUI.Model
{
    public class OrderInfo
    {

        public List<OrderDetails> OrderDetails
        {
            get { return OrderDetailsRepository.GetAll(); }
        }

        public List<Order> Order
        {
            get { return OrderRepository.GetAll(); }
        }

        public List<Employee> Employee
        {
            get { return EmployeeRepository.GetAll(); }
        }

    }
}
