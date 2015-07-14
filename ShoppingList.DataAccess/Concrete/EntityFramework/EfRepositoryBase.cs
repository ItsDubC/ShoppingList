using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingListApp.DataAccess.Abstract;
using ShoppingListApp.Abstract;
using System.Data.Entity;

namespace ShoppingListApp.DataAccess.Concrete.EntityFramework
{
    public abstract class EfRepositoryBase<TEntity, TContext> : IEntitityRepositoryBase<TEntity> 
        where TEntity : class, IEntity, new() 
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public TEntity GetById(int id)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().Find(id);
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new TContext())
            {
                var entityToDelete = GetById(id);
                context.Set<TEntity>().Remove(entityToDelete);
                //var entity = context.Entry(entityToDelete);
                //entity.State = EntityState.Deleted;
                
                context.SaveChanges();
            }
        }
    }
}
