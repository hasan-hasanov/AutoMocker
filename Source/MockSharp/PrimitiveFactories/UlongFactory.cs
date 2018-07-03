using MockSharp.PrimitiveFactories.Abstract;
using System;

namespace MockSharp.PrimitiveFactories
{
   public class UlongFactory : IPrimitiveFactory<ulong>
   {
      public ulong Create()
      {
         throw new NotImplementedException();
      }
   }
}
