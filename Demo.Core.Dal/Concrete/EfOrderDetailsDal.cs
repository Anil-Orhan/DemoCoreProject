using Demo.Core.Dal.Abstract;
using Demo.Core.DAL.EntityFramework;
using Demo.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Demo.Core.Dal.Concrete
{
   public class EfOrderDetailsDal: EfEntityRepositoryBase<OrderDetails, NorthwindContext>, IOrderDetailsDal
    {
       
    }
}
