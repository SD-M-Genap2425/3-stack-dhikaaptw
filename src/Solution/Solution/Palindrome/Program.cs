using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution.Palindrome
{
    public static class PalindromeChecker
    {
        public static bool CekPalindrom(string input)
        {
            string cleaned = new string(input
                .Where(char.IsLetterOrDigit)
                .Select(char.ToLower)
                .ToArray());

            Stack<char> stack = new Stack<char>();
            foreach (char c in cleaned)
                stack.Push(c);

            foreach (char c in cleaned)
            {
                if (c != stack.Pop())
                    return false;
            }

            return true;
        }
    }
}