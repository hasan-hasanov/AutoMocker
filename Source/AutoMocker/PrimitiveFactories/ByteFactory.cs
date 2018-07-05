using AutoMocker.PrimitiveFactories.Abstract;
using AutoMocker.Utils;

namespace AutoMocker.PrimitiveFactories
{
   public class ByteFactory : IPrimitiveFactory<byte>
   {
      public byte Create()
      {
         //TODO: Enchance byte array performance
         byte[] randomByte = new byte[1];
         RandomUtil.Instance.NextBytes(randomByte);
         return randomByte[0];
      }
   }
}
