using MockSharp.PrimitiveFactories.Abstract;
using System;

namespace MockSharp.PrimitiveFactories
{
   public class FloatFactory : IPrimitiveFactory<float>
    {
       public float Create()
       {
          throw new NotImplementedException();
       }
    }
}
