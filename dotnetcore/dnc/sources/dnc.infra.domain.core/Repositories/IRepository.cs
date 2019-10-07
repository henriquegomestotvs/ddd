using dnc.infra.domain.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace dnc.infra.domain.core.Repositories
{
  public interface IRepository<TEntity> : IDisposable
    where TEntity : Entity
  {
    TEntity Get(Guid id);
    IEnumerable<TEntity> Get();
    IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);
    TEntity Add(TEntity entity);
    TEntity Update(TEntity entity);
    TEntity Delete(TEntity entity);
  }
}
