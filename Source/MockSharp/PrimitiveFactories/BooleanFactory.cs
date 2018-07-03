using MockSharp.PrimitiveFactories.Abstract;
using MockSharp.Utils;

namespace MockSharp.PrimitiveFactories
{
   public class BooleanFactory : IPrimitiveFactory<bool>
   {
      public bool Create()
      {
         return RandomUtil.Instance.NextDouble() >= 0.5;
      }
   }
}
