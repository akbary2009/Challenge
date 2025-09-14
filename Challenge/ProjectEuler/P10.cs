using System.Collections.Generic;
using System.Linq;

namespace Challenge.ProjectEuler
{
    /// <summary>
    /// https://projecteuler.net/problem=10
    /// </summary>
    public static class P10
    {
        public static long GetAnswer()
        {
            return GetPrimes(2_000_000).Sum();
        }

        private static IEnumerable<long> GetPrimes(int maxValue)
        {
            for (int i = 2; i < maxValue; i++)
                if (IsPrime(i))
                    yield return i;
        }

        private static bool IsPrime(int number)
        {
            for (int i = 2; i <= number / 2; i++)
                if (number % i == 0) return false;

            return true;
        }
    }
}
