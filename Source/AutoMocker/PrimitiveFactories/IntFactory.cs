using AutoMocker.PrimitiveFactories.Abstract;
using System;

namespace AutoMocker.PrimitiveFactories
{
   public class IntFactory : IPrimitiveFactory<int>
    {
       public int Create()
       {
          throw new NotImplementedException();
       }
    }
}
