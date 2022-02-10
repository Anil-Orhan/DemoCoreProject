using System.Collections.Generic;
using Demo.Core.Bussines.Concrete;
using Demo.Core.Dal.Concrete;
using Demo.Core.Entities.Concrete;

namespace Demo.Core.MvcUI.Data
{
    public static class ProductRepository
    {

        private static readonly List<Products> _products = null;

        static ProductRepository()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            _products = productManager.GetAll();
        }

        public static List<Products> GetAll()
        {
            return _products;
        }



    }
}
