using AutoMocker.PrimitiveFactories.Abstract;
using AutoMocker.Utils;

namespace AutoMocker.PrimitiveFactories
{
   public class UshortFactory : IPrimitiveFactory<ushort>
    {
       public ushort Create()
       {
         return (ushort)RandomUtil.Instance.Next(ushort.MinValue, ushort.MaxValue);
      }
    }
}
