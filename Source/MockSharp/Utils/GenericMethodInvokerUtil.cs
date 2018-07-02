using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MockSharp.Utils
{
   public class GenericMethodInvokerUtil
   {
      public object InvokeMockObject<T>(Type type, PropertyInfo property, object currentObject)
      {
         MethodInfo method = typeof(AutoMocker).GetMethod("MockObject");
         MethodInfo generic = method.MakeGenericMethod(type);
         object result = generic.Invoke(null, null);
         object concreteResult = Convert.ChangeType(result, type);

         property.SetValue(currentObject, concreteResult);

         return currentObject;
      }

      public object InvokeMockObject<T>(Type type)
      {
         MethodInfo method = typeof(AutoMocker).GetMethod("MockObject");
         MethodInfo generic = method.MakeGenericMethod(type);

         object instance = Activator.CreateInstance(typeof(AutoMocker));
         object result = generic.Invoke(instance, null);
         object concreteResult = Convert.ChangeType(result, type);

         return concreteResult;
      }
   }
}
