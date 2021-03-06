using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Demo.Core.Bussines.Abstract;
using Demo.Core.Dal.Concrete;
using Demo.Core.Entities;
using Demo.Core.Entities.Concrete;
using Demo.Core.Entities.DTO;

namespace Demo.Core.Bussines.Concrete
{
    public class DtoManager:IDtoService
    {
        OrderManager orderManager = new OrderManager(new EfOrderDal());
        OrderDetailManager orderDetailManager = new OrderDetailManager(new EfOrderDetailsDal());
        ProductManager productManager = new ProductManager(new EfProductDal());

        public List<EmployeeSalesReport> GetEmployeesReports()
        {
            List<EmployeeSalesReport> result=new List<EmployeeSalesReport>();
            EmployeeManager employeeManager = new EmployeeManager(new EfEmployeeDal());
            foreach (var item in employeeManager.GetAll())
            {
                result.Add(EmployeeSaleReport(item));
            }

            return result;
        }
        public EmployeeSalesReport EmployeeSaleReport(Employee employee)
        {
          
            EmployeeManager employeeManager = new EmployeeManager(new EfEmployeeDal());

            var resultOrders = orderManager.GetAll().Where(p=>p.EmployeeID==employee.EmployeeID); // Seçilen Çalışanın Tüm Siparişleri
            decimal total=0;
            foreach (var item in resultOrders)
            {
                var r= orderDetailManager.GetById(item.OrderID);
                total += r.Quantity *(r.UnitPrice * Convert.ToDecimal(1-r.Discount)) ;
            }

            EmployeeSalesReport employeeSales = new EmployeeSalesReport {EmployeeID = employee.EmployeeID,FirstName = employee.FirstName,LastName = employee.LastName,TotalSale = total,OrderAmounth = resultOrders.Count() };









            return employeeSales;


        }


        public List<ProductReport> ProductSaleReport()
        {
            

            List<ProductReport> productReport = new List<ProductReport>();





            foreach (var item in productManager.GetAll())
            {

                productReport.Add(
                    
                    new ProductReport
                    {
                        ProductID = item.ProductID,
                        ProductName = item.ProductName,
                        OrderAmounth = orderDetailManager.GetAll().Where(i=>i.ProductID==item.ProductID).Count(),
                        ProductAmounth = orderDetailManager.GetAll().Where(i => i.ProductID == item.ProductID).Sum(i=>i.Quantity)



                    }
                    
                    
                    );


            }


            return productReport;



        }


    }
}
