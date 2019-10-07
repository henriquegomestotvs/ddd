using dnc.infra.app.viewmodel.core.ViewModels;
using dnc.infra.domain.core.Entities;
using FastMapper.NetCore;
using System.Collections.Generic;

namespace dnc.infra.app.mapper.core
{
  public abstract class AppAdapter<TEntity, TViewModel>
    where TEntity : Entity
    where TViewModel : ViewModel
  {
    protected AppAdapter()
    {

    }

    public TViewModel To(TEntity entity)
    {
      return TypeAdapter.Adapt<TEntity, TViewModel>(entity);
    }

    public IEnumerable<TViewModel> To(IEnumerable<TEntity> entities)
    {
      return TypeAdapter.Adapt<IEnumerable<TEntity>, IEnumerable<TViewModel>>(entities);
    }

    public TEntity To(TViewModel viewModel)
    {
      return TypeAdapter.Adapt<TViewModel, TEntity>(viewModel);
    }

    public IEnumerable<TEntity> To(IEnumerable<TViewModel> viewModels)
    {
      return TypeAdapter.Adapt<IEnumerable<TViewModel>, IEnumerable<TEntity>>(viewModels);
    }
  }
}
