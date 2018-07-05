using AutoMocker.PrimitiveFactories.Abstract;
using AutoMocker.Utils;

namespace AutoMocker.PrimitiveFactories
{
   public class BooleanFactory : IPrimitiveFactory<bool>
   {
      public bool Create()
      {
         return RandomUtil.Instance.NextDouble() >= 0.5;
      }
   }
}
