using AutoMocker.PrimitiveFactories.Abstract;
using AutoMocker.Utils;
using System;

namespace AutoMocker.PrimitiveFactories
{
   public class SbyteFactory : IPrimitiveFactory<sbyte>
   {
      public sbyte Create()
      {
         return Convert.ToSByte(RandomUtil.Instance.Next(sbyte.MinValue, sbyte.MaxValue));
      }
   }
}
