using MockSharp.PrimitiveFactories.Abstract;
using System;

namespace MockSharp.PrimitiveFactories
{
   public class StringFactory : IPrimitiveFactory<string>
   {
      public string Create()
      {
         return Guid.NewGuid().ToString();
      }
   }
}
