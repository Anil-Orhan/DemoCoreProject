using Demo.Core.Bussines.Concrete;
using Demo.Core.Dal.Concrete;
using Demo.Core.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Core.MvcUI.Controllers
{
    public class ReportsController : Controller
    {
        DtoManager dtoManager = new DtoManager();
        public IActionResult EmployeeSaleReport()
        {
           
            
            var result = dtoManager.GetEmployeesReports();


            return View(result);
        }

        public IActionResult ProductReport()
        {
           

            var result = dtoManager.ProductSaleReport();


            return View(result);
        }
    }
}
