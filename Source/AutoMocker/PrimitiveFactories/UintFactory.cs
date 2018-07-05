using AutoMocker.PrimitiveFactories.Abstract;
using System;

namespace AutoMocker.PrimitiveFactories
{
   public class UintFactory : IPrimitiveFactory<uint>
    {
       public uint Create()
       {
          throw new NotImplementedException();
       }
    }
}
