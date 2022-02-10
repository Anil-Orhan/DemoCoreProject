using Demo.Core.Bussines.Abstract;
using Demo.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Demo.Core.Dal.Abstract;

namespace Demo.Core.Bussines.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private IEmployeeDal _EmployeeDal;


        public EmployeeManager(IEmployeeDal employeeDal)
        {
                _EmployeeDal = employeeDal;
        }

        public void Add(Employee employee)
        {
           _EmployeeDal.Add(employee);
        }

        public void Delete(Employee employee)
        {
           _EmployeeDal.Delete(employee);
        }

        public List<Employee> GetAll()
        {
            return _EmployeeDal.GetList().ToList();
        }

        public Employee GetById(int employeeId)
        {
            return _EmployeeDal.Get(p => p.EmployeeID == employeeId);
        }

        public void Update(Employee employee)
        {
            _EmployeeDal.Update(employee);
        }
    }
}
