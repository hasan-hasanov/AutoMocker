using MockSharp.PrimitiveFactories.Abstract;
using System;

namespace MockSharp.PrimitiveFactories
{
   public class DecimalFactory : IPrimitiveFactory<decimal>
    {
       public decimal Create()
       {
          throw new NotImplementedException();
       }
    }
}
