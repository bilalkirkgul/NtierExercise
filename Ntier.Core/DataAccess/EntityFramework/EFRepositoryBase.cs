using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Ntier.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Ntier.Core.DataAccess.EntityFramework
{
    //DAL Repository'de işlem için public yapıldı
    public class EFRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity:class,IEntity
        where TContext:DbContext,new()
    {
        TContext context;

        public EFRepositoryBase() //Context Generic hale getirilmiştir...
        {
            IServiceCollection services = new ServiceCollection();
            services.AddDbContext<TContext>();
            ServiceProvider provider = services.BuildServiceProvider();
            context = provider.GetService<TContext>();
        }

        public bool Insert(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Added;
            return context.SaveChanges() > 0;
        }

        public bool Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            return context.SaveChanges()>0;
        }
        public bool Delete(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
            return context.SaveChanges() > 0;
        }
        //Include işlemi guncellemesi yapıldı

        public TEntity GetEntity(Expression<Func<TEntity, bool>> filter,params Expression<Func<TEntity,object>>[] includes)
        {
            return context.Set<TEntity>().Where(filter).MyInclude(includes).SingleOrDefault();
        }
        public ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null,params Expression<Func<TEntity,object>>[] includes)
        {
            if (filter==null)
            {
                return context.Set<TEntity>().MyInclude(includes).ToList();
            }
            else
            {
                return context.Set<TEntity>().Where(filter).MyInclude(includes).ToList();
            }
        }

        

      
    }
}
