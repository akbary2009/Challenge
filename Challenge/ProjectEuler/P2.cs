using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenge.ProjectEuler
{
    /// <summary>
    /// https://projecteuler.net/problem=2
    /// </summary>
    public static class P2
    {
        public static int GetAnswer()
        {
            return Fib(f => f < 4_000_000)
                .Where(n => n % 2 == 0)
                .Sum();
        }

        private static IEnumerable<int> Fib(Func<int, bool> condition = null)
        {
            int fib = 1, fib1 = 0, fib2 = 1;
            for (int i = 0; condition == null || condition(fib); i++)
            {
                fib = fib1 + fib2;
                fib1 = fib2;
                fib2 = fib;

                yield return fib;
            }
        }
    }
}
