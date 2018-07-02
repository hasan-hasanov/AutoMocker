using MockSharp.AbstractFactories.Abstract;
using MockSharp.PrimitiveFactories;
using MockSharp.PrimitiveFactories.Abstract;
using System;
using System.Collections.Generic;

namespace MockSharp.AbstractFactories
{
   public class PrimitiveFactory<T> : IFactory<T>
   {
      private readonly Dictionary<Type, IPrimitiveFactory<T>> _primitiveFactories = new Dictionary<Type, IPrimitiveFactory<T>>()
      {
         { typeof(string), (IPrimitiveFactory<T>)new StringFactory() },
         { typeof(bool), (IPrimitiveFactory<T>)null },
         { typeof(byte), (IPrimitiveFactory<T>)null },
         { typeof(sbyte), (IPrimitiveFactory<T>)null },
         { typeof(char), (IPrimitiveFactory<T>)null },
         { typeof(decimal), (IPrimitiveFactory<T>)null },
         { typeof(double), (IPrimitiveFactory<T>)null },
         { typeof(float), (IPrimitiveFactory<T>)null },
         { typeof(int), (IPrimitiveFactory<T>)null },
         { typeof(uint), (IPrimitiveFactory<T>)null },
         { typeof(long), (IPrimitiveFactory<T>)null },
         { typeof(ulong), (IPrimitiveFactory<T>)null },
         { typeof(short), (IPrimitiveFactory<T>)null },
         { typeof(ushort), (IPrimitiveFactory<T>)null },
         { typeof(object), (IPrimitiveFactory<T>)null },
      };

      public T Create()
      {
         if (_primitiveFactories.ContainsKey(typeof(T)))
         {
            IPrimitiveFactory<T> primitiveFactory = _primitiveFactories[typeof(T)];
            return primitiveFactory.Create();
         }

         throw new KeyNotFoundException($"The key of type: {typeof(T)} is not found.");
      }
   }
}
