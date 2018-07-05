using AutoMocker.PrimitiveFactories.Abstract;
using System;

namespace AutoMocker.PrimitiveFactories
{
   public class FloatFactory : IPrimitiveFactory<float>
    {
       public float Create()
       {
          throw new NotImplementedException();
       }
    }
}
