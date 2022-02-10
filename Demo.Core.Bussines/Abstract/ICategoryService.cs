using Demo.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Core.Bussines.Abstract
{
    public interface ICategoryService
    {


        Categories GetById(int categoryId);
        List<Categories> GetAll();
     
        void Add(Categories category);
        void Delete(Categories category);
        void Update(Categories category);

    }
}
