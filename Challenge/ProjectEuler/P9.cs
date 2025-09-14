using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenge.ProjectEuler
{
    /// <summary>
    /// https://projecteuler.net/problem=9
    /// </summary>
    public static class P9
    {
        public static int GetAnswer()
        {
            var answer = GetPythagoreans()
                .FirstOrDefault(x => x.Item1 + x.Item2 + x.Item3 == 1000);
            return answer.Item1 * answer.Item2 * answer.Item3;
        }

        private static IEnumerable<Tuple<int, int, int>> GetPythagoreans(int maxValue = 1000)
        {
            for (int i = 1; i < maxValue; i++)
            {
                for (int j = i + 1; j < maxValue; j++)
                {
                    var c2 = Math.Pow(i, 2) + Math.Pow(j, 2);
                    var c = Math.Sqrt(c2);
                    if (c > j && (int)c == c)
                        yield return new Tuple<int, int, int>(i, j, (int)c);
                }
            }
        }
    }
}
