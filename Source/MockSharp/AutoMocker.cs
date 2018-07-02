using MockSharp.Context;

namespace MockSharp
{
   public class AutoMocker
   {
      public T MockObject<T>()
      {
         MockContext<T> context = new MockContext<T>();
         T mockObject = context.CreateMockObject();

         return mockObject;
      }
   }
}
