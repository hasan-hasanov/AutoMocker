using System;
using MockSharp.AbstractFactories;
using MockSharp.AbstractFactories.Abstract;
using System.Collections;
using System.Collections.Generic;

namespace MockSharp.Context
{
   public class MockContext<T>
   {
      public T CreateMockObject()
      {
         IFactory<T> factory = null;

         if (typeof(IEnumerable).IsAssignableFrom(typeof(T)))
         {
            factory = new CollectionFactory<T>();
         }
         else if (typeof(T).IsArray)
         {
            factory = new ArrayFactory<T>();
         }
         else if (typeof(T).IsClass && typeof(T) != typeof(string))
         {
            factory = new ClassFactory<T>();
         }
         else if (typeof(T).IsPrimitive)
         {
            factory = new PrimitiveFactory<T>();
         }

         return factory.Create();
      }
   }
}
