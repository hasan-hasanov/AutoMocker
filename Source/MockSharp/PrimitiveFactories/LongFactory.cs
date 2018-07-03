using MockSharp.PrimitiveFactories.Abstract;
using System;

namespace MockSharp.PrimitiveFactories
{
   public class LongFactory : IPrimitiveFactory<long>
    {
       public long Create()
       {
          throw new NotImplementedException();
       }
    }
}
