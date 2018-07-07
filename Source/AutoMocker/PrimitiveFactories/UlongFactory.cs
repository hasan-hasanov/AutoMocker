using AutoMocker.PrimitiveFactories.Abstract;
using AutoMocker.Utils;
using System;

namespace AutoMocker.PrimitiveFactories
{
   public class UlongFactory : IPrimitiveFactory<ulong>
   {
      public ulong Create()
      {
         byte[] buffer = new byte[sizeof(ulong)];
         RandomUtil.Instance.NextBytes(buffer);
         return BitConverter.ToUInt64(buffer, 0);
      }
   }
}
