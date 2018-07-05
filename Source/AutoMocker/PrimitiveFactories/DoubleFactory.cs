using AutoMocker.PrimitiveFactories.Abstract;
using AutoMocker.Utils;

namespace AutoMocker.PrimitiveFactories
{
   public class DoubleFactory : IPrimitiveFactory<double>
   {
      public double Create()
      {
         return RandomUtil.Instance.NextDouble() * RandomUtil.Instance.Next(int.MinValue, int.MaxValue);
      }
   }
}
