using MockSharp.PrimitiveFactories.Abstract;
using System;

namespace MockSharp.PrimitiveFactories
{
   public class UshortFactory : IPrimitiveFactory<ushort>
    {
       public ushort Create()
       {
          throw new NotImplementedException();
       }
    }
}
