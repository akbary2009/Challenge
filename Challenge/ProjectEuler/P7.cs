using System.Collections.Generic;
using System.Linq;

namespace Challenge.ProjectEuler
{
    /// <summary>
    /// https://projecteuler.net/problem=7
    /// </summary>
    public static class P7
    {
        public static int GetAnswer()
        {
            return GetPrimeNumbers()
                .Skip(10_001 - 1)
                .Take(1)
                .FirstOrDefault();
        }

        private static IEnumerable<int> GetPrimeNumbers()
        {
            yield return 2;

            for (int i = 3; i < int.MaxValue; i += 2)
                if (IsPrime(i))
                    yield return i;
        }

        private static bool IsPrime(int number)
        {
            for (int i = 2; i < number / 2; i++)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
