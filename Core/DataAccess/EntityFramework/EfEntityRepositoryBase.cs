using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
          where TEntity : class, IEntity, new()
          where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
          
            using (TContext Dbcontext = new TContext())
            {
                var addedEntity = Dbcontext.Entry(entity);
                addedEntity.State = EntityState.Added;
                Dbcontext.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext Dbcontext = new TContext())
            {
                var deletedEntity = Dbcontext.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                Dbcontext.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext Dbcontext = new TContext())
            {
                return Dbcontext.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext Dbcontext = new TContext())
            {
                return filter == null
                    ? Dbcontext.Set<TEntity>().ToList()
                    : Dbcontext.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext Dbcontext = new TContext())
            {
                var updatedEntity = Dbcontext.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                Dbcontext.SaveChanges();
            }
        }
    }
}
