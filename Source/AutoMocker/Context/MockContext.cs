using AutoMocker.AbstractFactories;
using AutoMocker.AbstractFactories.Abstract;
using System.Collections;

namespace AutoMocker.Context
{
   public class MockContext<T>
   {
      public T CreateMockObject()
      {
         IFactory<T> factory = null;

         if (typeof(T).IsPrimitive || typeof(T) == typeof(string) || typeof(T) == typeof(decimal))
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
         else if (typeof(T).IsValueType)
         {
            factory = null; //TODO: Handle structs
         }

         return factory.Create();
      }
   }
}
