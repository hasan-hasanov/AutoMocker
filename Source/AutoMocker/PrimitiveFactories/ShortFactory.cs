using AutoMocker.PrimitiveFactories.Abstract;
using System;

namespace AutoMocker.PrimitiveFactories
{
   public class ShortFactory : IPrimitiveFactory<short>
    {
       public short Create()
       {
          throw new NotImplementedException();
       }
    }
}
