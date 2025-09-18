using System;
using System.Linq;

namespace Challenge.ProjectEuler
{
    /// <summary>
    /// https://projecteuler.net/problem=16
    /// </summary>
    public static class P16
    {
        public static int GetAnswer()
        {
            System.Numerics.BigInteger result = 1;
            for (int i = 0; i < 1_000 / 50; i++)
            {
                result *= (long)Math.Pow(2, 50);
            }

            return result.ToString()
                .Select(x => x.ToString())
                .Select(int.Parse)
                .Aggregate(0, (a, b) => a + b);
            //return Math.Pow(2, 1_000).ToString("0")...
        }
    }
}
