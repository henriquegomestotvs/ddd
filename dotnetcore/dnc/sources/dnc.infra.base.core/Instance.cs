namespace dnc.infra.@base.core
{
  public static class Instance
  {
    public static TClass Get<TClass>() where TClass : class, new() =>
      new TClass();

    public static void Set<TClass>(out TClass instance) where TClass : class, new() =>
      instance = Get<TClass>();

    public static bool IsInstance<TClass>(this TClass instance) where TClass : class =>
      instance != null;

  }
}
