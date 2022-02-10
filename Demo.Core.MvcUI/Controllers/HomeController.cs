using Demo.Core.Bussines.Concrete;
using Demo.Core.Dal.Concrete;
using Demo.Core.MvcUI.Data;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Core.MvcUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
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
    }
}

