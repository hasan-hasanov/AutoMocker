using MockSharp.AbstractFactories.Abstract;
using MockSharp.Utils;
using System;
using System.Reflection;

namespace MockSharp.AbstractFactories
{
   public class ClassFactory<T> : IFactory<T>
   {
      public T Create()
      {
         T mockObject = (T)Activator.CreateInstance(typeof(T));
         PropertyInfo[] properties = typeof(T).GetProperties();

         GenericMethodInvokerUtil method = new GenericMethodInvokerUtil();

         foreach (PropertyInfo property in properties)
         {
            method.InvokeMockObject<T>(property.PropertyType, property, mockObject);
         }

         return mockObject;
      }
   }
}
