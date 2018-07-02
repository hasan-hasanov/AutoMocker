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
         { typeof(string), new StringFactory() as IPrimitiveFactory<T> },
         { typeof(bool), new BooleanFactory() as IPrimitiveFactory<T> },
         { typeof(byte), null as IPrimitiveFactory<T> },
         { typeof(sbyte), null as IPrimitiveFactory<T> },
         { typeof(char), null as IPrimitiveFactory<T> },
         { typeof(decimal), null as IPrimitiveFactory<T> },
         { typeof(double), null as IPrimitiveFactory<T> },
         { typeof(float), null as IPrimitiveFactory<T> },
         { typeof(int), null as IPrimitiveFactory<T> },
         { typeof(uint), null as IPrimitiveFactory<T> },
         { typeof(long), null as IPrimitiveFactory<T> },
         { typeof(ulong), null as IPrimitiveFactory<T> },
         { typeof(short), null as IPrimitiveFactory<T> },
         { typeof(ushort), null as IPrimitiveFactory<T> },
         { typeof(object), null as IPrimitiveFactory<T> },
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
