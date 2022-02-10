using Demo.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Core.Bussines.Abstract
{
    public interface IEmployeeService
    {
        Employee GetById(int employeeId);
        List<Employee> GetAll();

        void Add(Employee employee);
        void Delete(Employee employee);
        void Update(Employee employee);
        

    }






}
