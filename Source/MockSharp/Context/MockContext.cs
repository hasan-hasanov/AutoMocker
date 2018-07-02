using MockSharp.AbstractFactories;
using MockSharp.AbstractFactories.Abstract;
using System.Collections;

namespace MockSharp.Context
{
   public class MockContext<T>
   {
      public T CreateMockObject()
      {
         IFactory<T> factory = null;

         if (typeof(T).IsPrimitive || typeof(T) == typeof(string))
         {
            factory = new PrimitiveFactory<T>();
         }
         else if (typeof(T).IsArray)
         {
            factory = new ArrayFactory<T>();
         }
         else if (typeof(IEnumerable).IsAssignableFrom(typeof(T)))
         {
            factory = new CollectionFactory<T>();
         }
         else if (typeof(T).IsClass && typeof(T) != typeof(string))
         {
            factory = new ClassFactory<T>();
         }

         return factory.Create();
      }
   }
}
