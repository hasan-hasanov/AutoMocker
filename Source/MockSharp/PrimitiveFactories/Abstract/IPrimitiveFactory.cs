using System;
using System.Collections.Generic;
using System.Text;

namespace MockSharp.PrimitiveFactories.Abstract
{
   public interface IPrimitiveFactory<T> 
   {
      T Create();
   }
}
