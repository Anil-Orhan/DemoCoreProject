using Demo.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Core.Bussines.Abstract
{
    public interface IProductService
    {
        Products GetById(int productId);
        List<Products> GetAll();
        List<Products> GetByCategory(int categoryId);
        void Add(Products products);
        void Delete(Products products);
        void Update(Products products);



    }
}
