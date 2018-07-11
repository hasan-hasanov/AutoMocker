using System;
using System.Reflection;

namespace AutoMocker.Utils
{
   public class GenericMethodInvokerUtil
   {
      public object InvokeMockObject<T>(Type type, PropertyInfo property, object currentObject)
      {
         object concreteResult = GetMockObjectResult(type);
         property.SetValue(currentObject, concreteResult);

         return currentObject;
      }

      public object InvokeMockObject<T>(Type type)
      {
         object concreteResult = GetMockObjectResult(type);
         return concreteResult;
      }

      private object GetMockObjectResult(Type type)
      {
         MethodInfo method = typeof(Mocker).GetMethod("MockObject", new Type[0] { });
         MethodInfo generic = method.MakeGenericMethod(type);

         object instance = Activator.CreateInstance(typeof(Mocker));
         object result = generic.Invoke(instance, null);
         object concreteResult = Convert.ChangeType(result, type);

         return concreteResult;
      }
   }
}
