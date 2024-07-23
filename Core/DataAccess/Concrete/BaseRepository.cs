using Core.DataAccess.Abstract;
using Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Concrete
{
    public class BaseRepository<TEntity, TContext> : IBaseRepository<TEntity>
        where TEntity : class , IEntity , new()
        where TContext : DbContext , new()
    {
        public void Add(TEntity entity)
        {
            using TContext context = new TContext();
            var added = context.Entry(entity);
            added.State = EntityState.Added;
            context.SaveChanges();
        }
        public void Delete(TEntity entity)
        {
            using TContext context = new TContext();
            var deleted = context.Entry(entity);
            deleted.State = EntityState.Deleted;
            context.SaveChanges();
            
        }
        public void Update(TEntity entity)
        {
            using TContext context = new TContext();
            var updated = context.Entry(entity);
            updated.State = EntityState.Modified;
            context.SaveChanges();
        }
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using TContext context = new TContext();
            return context.Set<TEntity>().SingleOrDefault(filter);
        }
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using TContext context = new TContext();
            return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
        }
    }
}
