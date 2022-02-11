using Demo.Core.Bussines.Concrete;
using Demo.Core.Dal.Concrete;
using Demo.Core.MvcUI.Data;
using Demo.Core.MvcUI.Model;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Core.MvcUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            OrderInfo orderInfo = new OrderInfo();
            return View(orderInfo);
        }

        public IActionResult ProductTable()
        {

           

            return View(ProductRepository.GetAll());




        }
        public IActionResult EmployeeTable()
        {

            //EmployeeManager employeeManager = new EmployeeManager(new EfEmployeeDal());

            //var employees = employeeManager.GetAll();
           
            return View(EmployeeRepository.GetAll());




        }



        public IActionResult OrderTable()
        {

           

            return View(OrderRepository.GetAll());




        }


        public IActionResult CategoriesTable()
        {



            return View(CategoryRepository.GetAll());




        }
    }
}

