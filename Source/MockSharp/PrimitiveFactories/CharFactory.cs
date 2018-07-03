using MockSharp.PrimitiveFactories.Abstract;
using System;

namespace MockSharp.PrimitiveFactories
{
   public class CharFactory : IPrimitiveFactory<char>
    {
       public char Create()
       {
          throw new NotImplementedException();
       }
    }
}
