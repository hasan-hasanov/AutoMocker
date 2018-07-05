using AutoMocker.AbstractFactories.Abstract;
using AutoMocker.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace AutoMocker.AbstractFactories
{
   public class ClassFactory<T> : IFactory<T>
   {
      public T Create()
      {
         T mockObject = (T)Activator.CreateInstance(typeof(T));
         IEnumerable<PropertyInfo> properties = typeof(T).GetProperties().Where(p => p.CanWrite);

         GenericMethodInvokerUtil method = new GenericMethodInvokerUtil();

         foreach (PropertyInfo property in properties)
         {
            if (property.PropertyType == typeof(T))
               throw new Exception("Circular properties are not supported!");

            method.InvokeMockObject<T>(property.PropertyType, property, mockObject);
         }

         return mockObject;
      }
   }
}
