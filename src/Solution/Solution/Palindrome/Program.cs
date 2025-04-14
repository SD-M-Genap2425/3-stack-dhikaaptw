using System;

namespace Solution.Palindrome
{
    public static class PalindromeChecker
    {
        public static bool CekPalindrom(string input)
        {
            string normalisasi = new string(input.ToLower().Where(char.IsLetter).ToArray());
            Stack<char> stack = new Stack<char>();
            foreach (char c in normalisasi) {
                stack.Push(c);
            }

            foreach (char c in normalisasi) {
                if (stack.Count == 0 || stack.Pop() != c) {
                    return false;
                }
            }

            return true;
        }
    }
}