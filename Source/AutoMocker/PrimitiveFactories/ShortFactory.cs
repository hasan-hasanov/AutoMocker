using AutoMocker.PrimitiveFactories.Abstract;
using AutoMocker.Utils;

namespace AutoMocker.PrimitiveFactories
{
   public class ShortFactory : IPrimitiveFactory<short>
   {
      public short Create()
      {
         return (short)RandomUtil.Instance.Next(short.MinValue, short.MaxValue);
      }
   }
}
