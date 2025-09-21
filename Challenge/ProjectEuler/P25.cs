using System;
using System.Numerics;

namespace Challenge.ProjectEuler
{
    /// <summary>
    /// https://projecteuler.net/problem=25
    /// </summary>
    public static class P25
    {
        public static int GetAnswer()
        {
            BigInteger fib1 = 1, fib2 = 1, fib;

            for (int i = 3; i <= int.MaxValue; i++)
            {
                fib = fib1 + fib2;
                fib1 = fib2;
                fib2 = fib;

                if (fib.ToString().Length == 1000)
                    return i;
            }

            throw new Exception();
        }
    }
}
