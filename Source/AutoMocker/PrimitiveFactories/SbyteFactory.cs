using AutoMocker.PrimitiveFactories.Abstract;
using AutoMocker.Utils;
using System;

namespace AutoMocker.PrimitiveFactories
{
   public class SbyteFactory : IPrimitiveFactory<sbyte>
   {
      public sbyte Create()
      {
         //TODO: Enchance byte array performance
         byte[] randomByte = new byte[1];
         RandomUtil.Instance.NextBytes(randomByte);
         return Convert.ToSByte(randomByte[0]);
      }
   }
}
