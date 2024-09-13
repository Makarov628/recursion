using System;
using System.Collections.Generic;
using System.Linq;

namespace Task7
{

   public static class Maximum
   {
      public static (T max1, T max2) FindTwoMaxInArray<T>(T[] numbers) where T : IComparable<T>
      {
         return FindTwoMaxInArrayRecursive(numbers, numbers.Length - 1, default, default);
      }

      private static (T max1, T max2) FindTwoMaxInArrayRecursive<T>(T[] numbers, int index, T max1, T max2) where T : IComparable<T>
      {
         if (index < 0)
            return (max1, max2);

         T current = numbers[index];
         bool max1LessCurrent = max1.CompareTo(current) < 0;
         bool max2LessOrEqualCurrent = max2.CompareTo(current) <= 0;

         if (max1LessCurrent)
         {
            max2 = max1;
            max1 = current;
         }
         else if (max2LessOrEqualCurrent)
         {
            max2 = current;
         }

         return FindTwoMaxInArrayRecursive(numbers, index - 1, max1, max2);
      }
   }

}

