using Demo.Core.Bussines.Abstract;
using Demo.Core.Dal.Abstract;
using Demo.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Core.Bussines.Concrete
{
    public class CategoryManager : ICategoryService
    {

        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal; 
        }


        public void Add(Categories category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(Categories category)
        {
            _categoryDal.Delete(category);
        }

        public List<Categories> GetAll()
        {
            return _categoryDal.GetList();
        }

        public Categories GetById(int categoryId)
        {
          return  _categoryDal.Get(p=>p.CategoryID==categoryId);
        }

        public void Update(Categories category)
        {
           _categoryDal.Update(category);   
        }
    }
}
