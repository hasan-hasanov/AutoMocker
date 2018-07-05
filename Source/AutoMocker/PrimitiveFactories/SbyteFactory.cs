using AutoMocker.PrimitiveFactories.Abstract;
using System;

namespace AutoMocker.PrimitiveFactories
{
   public class SbyteFactory : IPrimitiveFactory<sbyte>
    {
       public sbyte Create()
       {
          throw new NotImplementedException();
       }
    }
}
