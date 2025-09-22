using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenge.ProjectEuler
{
    /// <summary>
    /// https://projecteuler.net/problem=30
    /// </summary>
    public static class P30
    {
        public static int GetAnswer()
        {
            return GetSequence()
                .Sum();

            IEnumerable<int> GetSequence()
            {
                for (int i = 10; i < 3_000_000; i++)
                {
                    var digitsSum = i.ToString()
                        .Select(c => Math.Pow(int.Parse(c.ToString()), 5))
                        .Sum();

                    if (i == digitsSum)
                        yield return i;
                }
            }
        }
    }
}
