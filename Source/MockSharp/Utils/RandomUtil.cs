using System;

namespace MockSharp.Utils
{
   public class RandomUtil : Random
   {
      private static RandomUtil _instance;

      public static RandomUtil Instance
      {
         get
         {
            if (_instance == null)
               _instance = new RandomUtil();

            return _instance;
         }
      }

      private RandomUtil() { }
   }
}
