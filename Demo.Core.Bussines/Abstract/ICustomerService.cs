using Demo.Core.Entities.Concrete;
using System.Collections.Generic;

namespace Demo.Core.Bussines.Abstract
{
    public interface ICustomerService
    {
        Customer GetById(int customerId);
        List<Customer> GetAll();

        void Add(Customer customer);
        void Delete(Customer customer);
        void Update(Customer customer);


    }






}
