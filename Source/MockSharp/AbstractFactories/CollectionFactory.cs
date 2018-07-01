using MockSharp.AbstractFactories.Abstract;

namespace MockSharp.AbstractFactories
{
   public class CollectionFactory<T> : IFactory<T>
   {
      public T Create()
      {
         return default(T);
      }
   }
}
