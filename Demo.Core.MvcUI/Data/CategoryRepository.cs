using System.Collections.Generic;
using Demo.Core.Bussines.Concrete;
using Demo.Core.Dal.Concrete;
using Demo.Core.Entities.Concrete;

namespace Demo.Core.MvcUI.Data
{
    public static class CategoryRepository
    {

        private static readonly List<Categories> _categories = null;

        static CategoryRepository()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            _categories = categoryManager.GetAll();
        }

        public static List<Categories> GetAll()
        {
            return _categories;
        }



    }
}