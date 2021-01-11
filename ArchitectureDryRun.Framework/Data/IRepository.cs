using ArchitectureDryRun.Framework.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ArchitectureDryRun.Framework.Data
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        TEntity Get(Guid id);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        
        void Add(TEntity entity);
        void Add(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void Remove(Guid id);
        void Remove(IEnumerable<TEntity> entities);
        void Remove(IEnumerable<Guid> ids);
    }
}
