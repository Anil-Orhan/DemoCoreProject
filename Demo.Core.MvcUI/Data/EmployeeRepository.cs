using System.Collections.Generic;
using Demo.Core.Bussines.Concrete;
using Demo.Core.Dal.Concrete;
using Demo.Core.Entities.Concrete;

namespace Demo.Core.MvcUI.Data
{
    public static class EmployeeRepository
    {
        private static readonly List<Employee> _employees = null;

         static EmployeeRepository()
         {
             EmployeeManager employeeManager = new EmployeeManager(new EfEmployeeDal());
             _employees = employeeManager.GetAll();
         }

         public static List<Employee> GetAll()
         {
             return _employees;
         }



    }
}
