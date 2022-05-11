
using Core.DataAccess.EntityFramework.Abstract;
using Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {

            using (TContext dbContext = new TContext())
            {
                var AddedEntity = dbContext.Entry(entity);
                AddedEntity.State = EntityState.Added;
                dbContext.SaveChanges();
            }

        }
        public void Delete(TEntity entity)
        {
            using (TContext dbContext = new TContext())
            {
                var DeletedEntity = dbContext.Entry(entity);
                DeletedEntity.State = EntityState.Deleted;
                dbContext.SaveChanges();
            }
        }
        public void Update(TEntity entity)
        {
            using (TContext dbContext = new TContext())
            {
                var UpdateEntity = dbContext.Entry(entity);
                UpdateEntity.State = EntityState.Modified;
                dbContext.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext dbContext = new TContext())
            {
                return dbContext.Set<TEntity>().SingleOrDefault(filter);

            }
        }

        public List<TEntity> getAll(Expression<Func<TEntity, bool>> filter = null)
        {

            using (TContext dbContext = new TContext())
            {
                return filter == null ? dbContext.Set<TEntity>().ToList() : dbContext.Set<TEntity>().Where(filter).ToList();

            }

        }
    }
}
