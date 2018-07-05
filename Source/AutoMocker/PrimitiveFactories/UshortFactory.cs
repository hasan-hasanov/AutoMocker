using AutoMocker.PrimitiveFactories.Abstract;
using System;

namespace AutoMocker.PrimitiveFactories
{
   public class UshortFactory : IPrimitiveFactory<ushort>
    {
       public ushort Create()
       {
          throw new NotImplementedException();
       }
    }
}
