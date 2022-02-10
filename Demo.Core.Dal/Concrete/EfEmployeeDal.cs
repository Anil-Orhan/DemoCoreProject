using Demo.Core.Dal.Abstract;
using Demo.Core.DAL.EntityFramework;
using Demo.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Demo.Core.Dal.Concrete
{
    public class EfEmployeeDal : EfEntityRepositoryBase<Employee, NorthwindContext>, IEmployeeDal
    {
       
    }



}
