using AutoMocker.CollectionFactories.Abstract;
using AutoMocker.Utils;
using System;
using System.Collections;

namespace AutoMocker.CollectionFactories
{
   public class DictionaryFactory<T> : ICollectionFactory<T>
   {
      public T Create()
      {
         GenericMethodInvokerUtil methodInvoker = new GenericMethodInvokerUtil();
         IDictionary dictionary = (IDictionary)Activator.CreateInstance(typeof(T));
         int numberOfElements = RandomUtil.Instance.Next(1, 100);

         Type[] arguments = dictionary.GetType().GetGenericArguments();
         Type keyType = arguments[0];
         Type valueType = arguments[1];

         for (int i = 0; i < numberOfElements; i++)
         {
            object key = methodInvoker.InvokeMockObject<object>(keyType);
            object value = methodInvoker.InvokeMockObject<object>(valueType);

            if (!dictionary.Contains(key))
            {
               dictionary.Add(key, value);
            }
         }

         return (T)dictionary;
      }
   }
}
