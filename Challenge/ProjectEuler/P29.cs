using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenge.ProjectEuler
{
    /// <summary>
    /// https://projecteuler.net/problem=29
    /// </summary>
    public static class P29
    {
        public static int GetAnswer()
        {
            return GetList()
                .Distinct()
                .Count();

            IEnumerable<string> GetList()
            {
                for (int i = 2; i <= 100; i++)
                {
                    for (int j = 2; j <= 100; j++)
                    {
                        yield return Math.Pow(i, j).ToString();
                    }
                }
            }
        }
    }
}
