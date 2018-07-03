using MockSharp.PrimitiveFactories.Abstract;
using System;

namespace MockSharp.PrimitiveFactories
{
   public class ObjectFactory : IPrimitiveFactory<object>
   {
      public object Create()
      {
         throw new NotImplementedException();
      }
   }
}
