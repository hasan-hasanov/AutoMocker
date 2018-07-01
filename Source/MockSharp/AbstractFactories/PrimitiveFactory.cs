using MockSharp.AbstractFactories.Abstract;

namespace MockSharp.AbstractFactories
{
   public class PrimitiveFactory<T> : IFactory<T>
   {
      public T Create()
      {
         return default(T);
      }
   }
}
