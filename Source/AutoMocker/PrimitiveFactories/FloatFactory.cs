using AutoMocker.PrimitiveFactories.Abstract;
using AutoMocker.Utils;
using System;

namespace AutoMocker.PrimitiveFactories
{
   public class FloatFactory : IPrimitiveFactory<float>
   {
      public float Create()
      {
         double mantissa = (RandomUtil.Instance.NextDouble() * 2.0) - 1.0;
         double exponent = Math.Pow(2.0, RandomUtil.Instance.Next(-126, 128));
         return (float)(mantissa * exponent);
      }
   }
}
