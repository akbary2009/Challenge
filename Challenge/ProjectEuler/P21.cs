using System.Collections.Generic;
using System.Linq;

namespace Challenge.ProjectEuler
{
    /// <summary>
    /// https://projecteuler.net/problem=21
    /// </summary>
    public static class P21
    {
        public static int GetAnswer()
        {
            return GetAmicableNumbers(10_000)
                .Sum();
        }

        private static IEnumerable<int> GetAmicableNumbers(int max)
        {
            for (int i = 1; i < max; i++)
                if (IsAmicable(i))
                    yield return i;
        }

        private static bool IsAmicable(int number)
        {
            var sum = GetProperDivisors(number).Sum();
            return GetProperDivisors(sum).Sum() == number && number != sum;
        }

        private static IEnumerable<int> GetProperDivisors(int number)
        {
            for (int i = 1; i <= number / 2; i++)
                if (number % i == 0)
                    yield return i;
        }
    }
}
