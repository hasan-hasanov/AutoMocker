using AutoMocker.PrimitiveFactories.Abstract;
using AutoMocker.Utils;

namespace AutoMocker.PrimitiveFactories
{
   public class UintFactory : IPrimitiveFactory<uint>
   {
      public uint Create()
      {
         return (uint)(RandomUtil.Instance.Next(1 << 30)) << 2 | (uint)(RandomUtil.Instance.Next(1 << 2));
      }
   }
}
