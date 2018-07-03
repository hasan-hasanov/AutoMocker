using MockSharp.PrimitiveFactories.Abstract;
using System;

namespace MockSharp.PrimitiveFactories
{
   public class SbyteFactory : IPrimitiveFactory<sbyte>
    {
       public sbyte Create()
       {
          throw new NotImplementedException();
       }
    }
}
