using System;
using System.Collections.Generic;
using System.Text;

namespace MockSharp.CollectionFactories.Abstract
{
   public interface ICollectionFactory<T>
   {
      T Create();
   }
}
