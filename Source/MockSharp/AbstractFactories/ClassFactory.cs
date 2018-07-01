using MockSharp.AbstractFactories.Abstract;

namespace MockSharp.AbstractFactories
{
   public class ClassFactory<T> : IFactory<T>
   {
      public T Create()
      {
         return default(T);
      }
   }
}
