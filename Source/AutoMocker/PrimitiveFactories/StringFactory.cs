using AutoMocker.PrimitiveFactories.Abstract;
using System;

namespace AutoMocker.PrimitiveFactories
{
   public class StringFactory : IPrimitiveFactory<string>
   {
      public string Create()
      {
         return Guid.NewGuid().ToString();
      }
   }
}
