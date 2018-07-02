using MockSharp.AbstractFactories.Abstract;
using MockSharp.Utils;
using System;

namespace MockSharp.AbstractFactories
{
   public class ArrayFactory<T> : IFactory<T>
   {
      public T Create()
      {
         var genericMethodInvoker = new GenericMethodInvokerUtil();
         Array array = Activator.CreateInstance(typeof(T), new object[] { RandomUtil.Instance.Next(1, 100) }) as Array;
         for (int i = 0; i < array.Length; i++)
         {
            Type arrayElementType = typeof(T).GetElementType();
            array.SetValue(genericMethodInvoker.InvokeMockObject<T>(arrayElementType), i);
         }

         return (T)Convert.ChangeType(array, typeof(T));
      }
   }
}
