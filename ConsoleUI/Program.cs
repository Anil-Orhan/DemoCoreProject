using System;
using Demo.Core.Bussines.Concrete;
using Demo.Core.Dal.Concrete;
using Demo.Core.Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderDetailManager orderManager = new OrderDetailManager(new EfOrderDetailsDal());
            EmployeeManager employeeManager = new EmployeeManager(new EfEmployeeDal());
            //ProductManager productManager = new ProductManager(new EfProductDal());

            //foreach (var item in productManager.GetAll())
            //{
            //    Console.WriteLine(item.ProductID);

            //}



            DtoManager dtoManager = new DtoManager();
            var result = dtoManager.EmployeeSaleReport(employeeManager.GetById(1));
            Console.WriteLine(result.EmployeeID);
            Console.WriteLine(result.FirstName);
            Console.WriteLine(result.LastName);
            Console.WriteLine(result.OrderAmounth);
            Console.WriteLine(result.TotalSale);




        }
    }
}
