using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenge.ProjectEuler
{
    /// <summary>
    /// https://projecteuler.net/problem=4
    /// </summary>
    public static class P4
    {
        public static int GetAnswer()
        {
            return GetPalindromics()
                .Max();
        }

        private static IEnumerable<int> GetPalindromics()
        {
            for (int i = 999; i > 99; i--)
                for (int j = 999; j > 99; j--)
                    if (IsPalindromic(i * j))
                        yield return i * j;
        }

        private static bool IsPalindromic(int number)
            => number.ToString().Equals(number.ToString()
                .Reverse()
                .Aggregate(string.Empty, (a, b) => a + b));
    }
}
