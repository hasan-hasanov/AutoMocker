using MockSharp.PrimitiveFactories.Abstract;
using System;

namespace MockSharp.PrimitiveFactories
{
   public class IntFactory : IPrimitiveFactory<int>
    {
       public int Create()
       {
          throw new NotImplementedException();
       }
    }
}
