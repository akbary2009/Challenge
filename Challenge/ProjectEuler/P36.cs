using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenge.ProjectEuler
{
    /// <summary>
    /// https://projecteuler.net/problem=36
    /// </summary>
    public static class P36
    {
        public static int GetAnswer()
        {
            return GetPalindromics(1_000_000)
                .Sum();
        }

        private static IEnumerable<int> GetPalindromics(int max)
        {
            for (int i = 1; i < max; i++)
            {
                if (IsPalindromic(i) && IsPalindromic(Convert.ToString(i, 2)))
                    yield return i;
            }
        }

        private static bool IsPalindromic(int number)
            => IsPalindromic(number.ToString());

        private static bool IsPalindromic(string number)
            => number?.Equals(number.Reverse().Aggregate(string.Empty, (a, b) => a + b)) ?? false;
    }
}
