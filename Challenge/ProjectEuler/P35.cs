using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenge.ProjectEuler
{
    /// <summary>
    /// https://projecteuler.net/problem=35
    /// </summary>
    public static class P35
    {
        public static int GetAnswer()
        {
            return GetSequence(1_000_000)
                .Count();


            IEnumerable<int> GetSequence(int max)
            {
                for (int i = 2; i < max; i++)
                {
                    if (IsPrime(i) && GetRotations(i).All(IsPrime))
                        yield return i;
                }
            }

        }

        private static IEnumerable<int> GetRotations(int number)
        {
            for (int i = 1; i < number.ToString().Length; i++)
            {
                var factor = (int)Math.Pow(10, i);
                var a = number / factor;
                var b = number % factor;
                yield return int.Parse(b.ToString() + a.ToString());
            }
        }

        private static bool IsPrime(int number)
        {
            for (int i = 2; i <= number / 2; i++)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
