using AutoMocker.CollectionFactories.Abstract;
using AutoMocker.Utils;
using System;
using System.Collections;

namespace AutoMocker.CollectionFactories
{
   public class ListFactory<T> : ICollectionFactory<T>
   {
      public T Create()
      {
         GenericMethodInvokerUtil methodInvoker = new GenericMethodInvokerUtil();
         IList list = (IList)Activator.CreateInstance(typeof(T));

         int numberOfElements = RandomUtil.Instance.Next(1, 100);
         Type valueType = list.GetType().GetGenericArguments()[0];

         for (int i = 0; i < numberOfElements; i++)
         {
            object value = methodInvoker.InvokeMockObject<object>(valueType);
            list.Add(value);
         }

         return (T)list;
      }
   }
}
