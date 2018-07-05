using AutoMocker.PrimitiveFactories.Abstract;
using AutoMocker.Utils;
using System;

namespace AutoMocker.PrimitiveFactories
{
   public class LongFactory : IPrimitiveFactory<long>
   {
      public long Create()
      {
         byte[] buf = new byte[8];
         RandomUtil.Instance.NextBytes(buf);
         long longRand = BitConverter.ToInt64(buf, 0);

         return longRand;
      }
   }
}
