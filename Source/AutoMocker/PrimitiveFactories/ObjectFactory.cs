using AutoMocker.PrimitiveFactories.Abstract;
using System;

namespace AutoMocker.PrimitiveFactories
{
   public class ObjectFactory : IPrimitiveFactory<object>
   {
      public object Create()
      {
         throw new NotImplementedException();
      }
   }
}
