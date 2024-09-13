using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4
{

   public static class Palindrome
   {
      public static bool IsPalindrome(string value)
      {
         if (string.IsNullOrEmpty(value))
            return false;

         char[] chars = value.ToCharArray();
         return IsPalindromeRecursive(ref chars, 0, chars.Length - 1);
      }

      private static bool IsPalindromeRecursive(ref char[] chars, int firstIndex, int lastIndex)
      {
         if (chars[firstIndex] != chars[lastIndex])
            return false;

         if (lastIndex - firstIndex > 0)
            IsPalindromeRecursive(ref chars, firstIndex + 1, lastIndex - 1);

         return true;
      }
   }

}

