using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories
{
    public class EfRepositoryBase<T, TContext> : IRepositoryDal<T> where T : class, IEntity, new() where TContext : DbContext, new()
    {
        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<T>().ToList() : context.Set<T>().Where(filter).ToList();
            }
        }

        public T Get(Expression<Func<T, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return context.Set<T>().SingleOrDefault(filter);

            }
        }

        public void Add(T entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(T entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
             using (TContext context = new TContext())
             {
                 var deletedEntity = context.Entry(entity);
                 deletedEntity.State = EntityState.Deleted;
                 context.SaveChanges();
             }
        }
    }
}
