using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Demo.Core.Entities;

namespace Demo.Core.DAL
{
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        T Get(Expression<Func<T, bool>> filter = null);
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        void Add(T entitiy);
        void Update(T entitiy);
        void Delete(T entitiy);


    }
}
