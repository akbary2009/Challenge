using System.Linq;
using System.Numerics;

namespace Challenge.ProjectEuler
{
    /// <summary>
    /// https://projecteuler.net/problem=20
    /// </summary>
    public static class P20
    {
        public static int GetAnswer()
        {
            return Fact(100)
                .ToString()
                .Select(c => c.ToString())
                .Select(int.Parse)
                .Aggregate(0, (a, b) => a + b);
        }

        private static BigInteger Fact(long number)
        {
            if (number == 1) return 1;

            return number * Fact(number - 1);
        }
    }
}
