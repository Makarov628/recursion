using System;
using System.Collections.Generic;
using System.Linq;

namespace Task7
{

   public static class Maximum
   {
      public static (int max1, int max2) FindTwoMaxInArray(int[] numbers)
      {
         return FindTwoMaxInArrayRecursive(numbers, numbers.Length - 1, int.MinValue, int.MinValue);
      }

      private static (int max1, int max2) FindTwoMaxInArrayRecursive(int[] numbers, int index, int max1, int max2)
      {
         if (index < 0)
            return (max1, max2);

         int current = numbers[index];

         if (current > max1)
         {
            max2 = max1;
            max1 = current;
         }
         else if (current >= max2)
         {
            max2 = current;
         }

         return FindTwoMaxInArrayRecursive(numbers, index - 1, max1, max2);
      }
   }

}

