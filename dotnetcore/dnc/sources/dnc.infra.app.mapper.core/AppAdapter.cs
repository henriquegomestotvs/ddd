using FastMapper.NetCore;
using System.Collections.Generic;

namespace dnc.infra.app.mapper.core
{
  public abstract class AppAdapter<TEntity, TViewModel>
    where TEntity : class
    where TViewModel : class
  {
    protected AppAdapter()
    {

    }

    public virtual TViewModel To(TEntity entity)
    {
      return TypeAdapter.Adapt<TEntity, TViewModel>(entity);
    }

    public virtual IEnumerable<TViewModel> To(IEnumerable<TEntity> entities)
    {
      return TypeAdapter.Adapt<IEnumerable<TEntity>, IEnumerable<TViewModel>>(entities);
    }

    public virtual TEntity To(TViewModel viewModel)
    {
      return TypeAdapter.Adapt<TViewModel, TEntity>(viewModel);
    }

    public virtual IEnumerable<TEntity> To(IEnumerable<TViewModel> viewModels)
    {
      return TypeAdapter.Adapt<IEnumerable<TViewModel>, IEnumerable<TEntity>>(viewModels);
    }
  }
}
