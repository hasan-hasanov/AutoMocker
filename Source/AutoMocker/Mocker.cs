using AutoMocker.Context;

namespace AutoMocker
{
   public class Mocker
   {
      public T MockObject<T>()
      {
         MockContext<T> context = new MockContext<T>();
         T mockObject = context.CreateMockObject();

         return mockObject;
      }
   }
}
