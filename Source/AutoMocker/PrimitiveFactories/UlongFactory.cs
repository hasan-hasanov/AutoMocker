using AutoMocker.PrimitiveFactories.Abstract;
using System;

namespace AutoMocker.PrimitiveFactories
{
   public class UlongFactory : IPrimitiveFactory<ulong>
   {
      public ulong Create()
      {
         throw new NotImplementedException();
      }
   }
}
