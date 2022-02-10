using Demo.Core.Bussines.Abstract;
using Demo.Core.Dal.Abstract;
using Demo.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Core.Bussines.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;

        }


        public void Add(Products products)
        {
           _productDal.Add(products);
        }

        public void Delete(Products products)
        {
            _productDal.Delete(products);
        }

        public List<Products> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Products> GetByCategory(int categoryId)
        {
           return _productDal.GetList(p=>p.CategoryID==categoryId);
        }

        public Products GetById(int productId)
        {
            return _productDal.Get(p=>p.ProductID==productId);
        }

        public void Update(Products products)
        {
             _productDal.Update(products);
        }
    }
}
