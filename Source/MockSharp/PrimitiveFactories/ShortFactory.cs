using MockSharp.PrimitiveFactories.Abstract;
using System;

namespace MockSharp.PrimitiveFactories
{
   public class ShortFactory : IPrimitiveFactory<short>
    {
       public short Create()
       {
          throw new NotImplementedException();
       }
    }
}
