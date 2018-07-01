using System;
using MockSharp.AbstractFactories;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MockSharp.AbstractFactories.Abstract;

namespace MockSharp.Context
{
   public class MockContext<T>
   {
      public T CreateMockObject()
      {
         T mockObject = default(T);

         if (typeof(IEnumerable).IsAssignableFrom(typeof(T)))
         {
            CollectionFactory<T> collectionFactory = new CollectionFactory<T>();
            mockObject = collectionFactory.Create();
         }
         else if (typeof(T).IsArray)
         {
            ArrayFactory<T> arrayFactory = new ArrayFactory<T>();
            mockObject = arrayFactory.Create();
         }
         else if (typeof(T).IsClass && typeof(T) != typeof(string))
         {
            ClassFactory<T> classFactory = new ClassFactory<T>();
            mockObject = classFactory.Create();
         }
         else if (typeof(T).IsPrimitive)
         {
            PrimitiveFactory<T> primitiveFactory = new PrimitiveFactory<T>();
            mockObject = primitiveFactory.Create();
         }

         return mockObject;
      }
   }
}
