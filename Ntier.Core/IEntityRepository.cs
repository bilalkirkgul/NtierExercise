using Ntier.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Ntier.Core
{
   public interface IEntityRepository<TEntity>
        where TEntity:IEntity
    {

        bool Insert(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
       
        TEntity GetEntity(Expression<Func<TEntity, bool>> filter,params Expression<Func<TEntity, object>>[] includes);

        ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null,params Expression<Func<TEntity,object>>[] includes);

    }
}
