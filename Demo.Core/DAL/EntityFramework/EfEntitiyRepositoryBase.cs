using Demo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Demo.Core.DAL.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entitiy)
        {
            using (var context=new TContext())
            {

                try
                {
                    var addedEntity = context.Entry(entitiy);
                    addedEntity.State = EntityState.Added;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

               
            }
        }

        public void Delete(TEntity entitiy)
        {

            using (var context = new TContext())
            {

                try
                {
                    var addedEntity = context.Entry(entitiy);
                    addedEntity.State = EntityState.Deleted;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }


            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())

            {

                return context.Set<TEntity>().FirstOrDefault(filter);

                 

            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())

            {

                return filter == null

                    ? context.Set<TEntity>().ToList()

                    : context.Set<TEntity>().Where(filter).ToList();

            }
        }

        public void Update(TEntity entitiy)
        {

            using (var context = new TContext())
            {

                try
                {
                    var addedEntity = context.Entry(entitiy);
                    addedEntity.State = EntityState.Modified;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }


            }
        }
    }
}
