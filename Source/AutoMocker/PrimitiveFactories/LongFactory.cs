using AutoMocker.PrimitiveFactories.Abstract;
using System;

namespace AutoMocker.PrimitiveFactories
{
   public class LongFactory : IPrimitiveFactory<long>
    {
       public long Create()
       {
          throw new NotImplementedException();
       }
    }
}
