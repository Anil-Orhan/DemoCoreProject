using Demo.Core.Dal.Abstract;
using Demo.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Demo.Core.DAL.EntityFramework;



namespace Demo.Core.Dal.Concrete
{
    public class EfProductDal :EfEntityRepositoryBase<Products,NorthwindContext>,IProductDal
    {
       
    }
}
