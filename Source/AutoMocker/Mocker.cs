using System;
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

      public T MockObject<T>(params Action<T>[] actions)
      {
         T mockObject = MockObject<T>();

         foreach (Action<T> action in actions)
         {
            action(mockObject);
         }

         return mockObject;
      }
   }
}
