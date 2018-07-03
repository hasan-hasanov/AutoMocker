using MockSharp.PrimitiveFactories.Abstract;
using System;

namespace MockSharp.PrimitiveFactories
{
   public class ByteFactory : IPrimitiveFactory<byte>
    {
       public byte Create()
       {
          throw new NotImplementedException();
       }
    }
}
