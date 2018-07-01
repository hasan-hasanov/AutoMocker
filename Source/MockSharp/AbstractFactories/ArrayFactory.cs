using MockSharp.AbstractFactories.Abstract;

namespace MockSharp.AbstractFactories
{
   public class ArrayFactory<T> : IFactory<T>
   {
      public T Create()
      {
         return default(T);
      }
   }
}
