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
