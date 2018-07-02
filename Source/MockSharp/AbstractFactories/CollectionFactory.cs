using MockSharp.AbstractFactories.Abstract;
using MockSharp.CollectionFactories;
using MockSharp.CollectionFactories.Abstract;
using System.Collections;

namespace MockSharp.AbstractFactories
{
   public class CollectionFactory<T> : IFactory<T>
   {
      public T Create()
      {
         ICollectionFactory<T> factory = null;

         if (typeof(IDictionary).IsAssignableFrom(typeof(T)))
         {
            factory = new DictionaryFactory<T>() as ICollectionFactory<T>;
         }
         else if (typeof(IList).IsAssignableFrom(typeof(T)))
         {
            factory = new ListFactory<T>() as ICollectionFactory<T>;
         }

         return factory.Create();
      }
   }
}
