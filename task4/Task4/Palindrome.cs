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

         return IsPalindromeRecursive(value);
      }

      private static bool IsPalindromeRecursive(string substring)
      {
         if (substring.First() != substring.Last())
            return false;

         if (substring.Length > 1)
            IsPalindromeRecursive(substring.Substring(1, substring.Length - 1));

         return true;
      }
   }

}

