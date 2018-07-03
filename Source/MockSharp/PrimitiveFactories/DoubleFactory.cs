using MockSharp.PrimitiveFactories.Abstract;
using MockSharp.Utils;

namespace MockSharp.PrimitiveFactories
{
   public class DoubleFactory : IPrimitiveFactory<double>
   {
      public double Create()
      {
         return RandomUtil.Instance.NextDouble() * RandomUtil.Instance.Next(int.MinValue, int.MaxValue);
      }
   }
}
