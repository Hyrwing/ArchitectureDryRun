using ArchitectureDryRun.Framework.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ArchitectureDryRun.Framework.Data
{
    public abstract class Repository<TEntity> : IRepository<IEntity> where TEntity : IEntity
    {
        protected readonly DbContext Context;
        protected readonly DbSet<IEntity> Entities;

        public Repository(DbContext context)
        {
            Context = context;
            Entities = Context.Set<IEntity>();
        }
        public IEntity Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IEntity> Find(Expression<Func<IEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Add(IEntity entity)
        {
            Entities.Add(entity);
        }

        public void Add(IEnumerable<IEntity> entities)
        {
            throw new NotImplementedException();
        }

        public void Remove(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Remove(IEnumerable<IEntity> entities)
        {
            throw new NotImplementedException();
        }

        public void Remove(IEnumerable<Guid> ids)
        {
            throw new NotImplementedException();
        }
    }
}
