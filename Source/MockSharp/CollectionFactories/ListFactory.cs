using MockSharp.CollectionFactories.Abstract;
using MockSharp.Utils;
using System;
using System.Collections;

namespace MockSharp.CollectionFactories
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
