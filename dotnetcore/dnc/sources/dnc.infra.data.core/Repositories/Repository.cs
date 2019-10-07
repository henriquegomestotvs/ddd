using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using dnc.infra.domain.core.Entities;
using dnc.infra.domain.core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace dnc.infra.data.core.Repositories
{
  public abstract class Repository<TEntity> : IRepository<TEntity>
    where TEntity : Entity
  {
    private readonly DbContext _context;

    public TEntity Add(TEntity entity)
    {
      throw new NotImplementedException();
    }

    public TEntity Delete(TEntity entity)
    {
      throw new NotImplementedException();
    }

    public void Dispose()
    {
      throw new NotImplementedException();
    }

    public TEntity Get(Guid id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<TEntity> Get()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
    {
      throw new NotImplementedException();
    }

    public TEntity Update(TEntity entity)
    {
      throw new NotImplementedException();
    }
  }
}
