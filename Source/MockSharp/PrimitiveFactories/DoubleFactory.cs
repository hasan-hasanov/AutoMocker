using MockSharp.PrimitiveFactories.Abstract;
using System;

namespace MockSharp.PrimitiveFactories
{
   public class DoubleFactory : IPrimitiveFactory<double>
    {
       public double Create()
       {
          throw new NotImplementedException();
       }
    }
}
