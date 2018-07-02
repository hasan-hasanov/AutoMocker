using System;
using System.Collections.Generic;
using System.Text;
using MockSharp.PrimitiveFactories.Abstract;

namespace MockSharp.PrimitiveFactories
{
   public class BooleanFactory : IPrimitiveFactory<bool>
   {
      public bool Create()
      {
         return true;
      }
   }
}
