using AutoMocker.PrimitiveFactories.Abstract;
using AutoMocker.Utils;

namespace AutoMocker.PrimitiveFactories
{
   public class IntFactory : IPrimitiveFactory<int>
   {
      public int Create()
      {
         return RandomUtil.Instance.Next(int.MinValue, int.MaxValue);
      }
   }
}
