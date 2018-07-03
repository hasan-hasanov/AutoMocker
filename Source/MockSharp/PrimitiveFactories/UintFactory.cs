using MockSharp.PrimitiveFactories.Abstract;
using System;

namespace MockSharp.PrimitiveFactories
{
   public class UintFactory : IPrimitiveFactory<uint>
    {
       public uint Create()
       {
          throw new NotImplementedException();
       }
    }
}
