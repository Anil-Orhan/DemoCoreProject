using Demo.Core.Bussines.Concrete;
using Demo.Core.Dal.Concrete;
using Demo.Core.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Core.MvcUI.Controllers
{
    public class ReportsController : Controller
    {
        public IActionResult EmployeeSaleReport()
        {
            DtoManager dtoManager = new DtoManager();
            
            var result = dtoManager.GetEmployeesReports();


            return View(result);
        }
    }
}
