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
         { typeof(byte), new ByteFactory() as IPrimitiveFactory<T> },
         { typeof(sbyte), new SbyteFactory() as IPrimitiveFactory<T> },
         { typeof(char), new CharFactory() as IPrimitiveFactory<T> },
         { typeof(decimal), new DecimalFactory() as IPrimitiveFactory<T> },
         { typeof(double), new DoubleFactory() as IPrimitiveFactory<T> },
         { typeof(float), new FloatFactory() as IPrimitiveFactory<T> },
         { typeof(int), new IntFactory() as IPrimitiveFactory<T> },
         { typeof(uint), new UintFactory() as IPrimitiveFactory<T> },
         { typeof(long), new LongFactory() as IPrimitiveFactory<T> },
         { typeof(ulong), new UlongFactory() as IPrimitiveFactory<T> },
         { typeof(short), new ShortFactory() as IPrimitiveFactory<T> },
         { typeof(ushort), new UshortFactory() as IPrimitiveFactory<T> },
         { typeof(object), new ObjectFactory() as IPrimitiveFactory<T> },
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
