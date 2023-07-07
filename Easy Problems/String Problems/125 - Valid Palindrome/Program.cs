using System;
using System.Collections.Generic;
using System.Linq;

namespace _3___Valid_Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Program program = new Program();
            bool isPalindrome = program.IsPalindrome(s);
            Console.WriteLine(isPalindrome);

           
        }

        public bool IsPalindrome(string s)
        {
            string alphanumericString = RemoveNonAlphanumeric(s.ToLower());

            int left = 0;
            int right = alphanumericString.Length - 1;

            while (left <= right)
            {
                if (alphanumericString[left] != alphanumericString[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }
        private static string RemoveNonAlphanumeric(string s)
        {
            char[] charArray = s.ToCharArray();
            int writeIndex = 0;

            for (int readIndex = 0; readIndex < charArray.Length; readIndex++)
            {
                if (IsAlphanumeric(charArray[readIndex]))
                {
                    charArray[writeIndex] = charArray[readIndex];
                    writeIndex++;
                }
            }

            return new string(charArray, 0, writeIndex);
        }

        private static bool IsAlphanumeric(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9');
        }
    }
}

