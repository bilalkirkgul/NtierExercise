using Ntier.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ntier.BLL.Abstract
{
    interface IBaseBLL<TEntity>
        where TEntity: IEntity
    {
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void DeleteById(int entityId);
        TEntity Get(int entityId);
        ICollection<TEntity> GetAll();

    }
}
