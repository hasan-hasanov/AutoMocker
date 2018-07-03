using MockSharp.PrimitiveFactories.Abstract;
using MockSharp.Utils;

namespace MockSharp.PrimitiveFactories
{
   public class DecimalFactory : IPrimitiveFactory<decimal>
   {
      public decimal Create()
      {
         byte scale = (byte)RandomUtil.Instance.Next(29);
         bool sign = RandomUtil.Instance.Next(2) == 1;

         return new decimal(GenerateInt32(),
            GenerateInt32(),
            GenerateInt32(),
            sign,
            scale);
      }

      private int GenerateInt32()
      {
         int firstBits = RandomUtil.Instance.Next(0, 1 << 4) << 28;
         int lastBits = RandomUtil.Instance.Next(0, 1 << 28);
         return firstBits | lastBits;
      }
   }
}
