using System;

namespace dnc.infra.app.mapper.core
{
  public class ManualAdapter
  {
    public static TDestination To<TSource,TDestination>(TSource source, Func<TSource, TDestination> adapter)
    {
      return adapter(source);
    }
  }
}
