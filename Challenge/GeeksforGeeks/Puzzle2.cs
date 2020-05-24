using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenge.GeeksforGeeks
{
    /// <summary>
    /// https://www.geeksforgeeks.org/puzzle-2-find-ages-of-daughters/
    /// </summary>
    public class Puzzle2
    {
        public static void FindAges()
        {
            var ages = PossibleAges()
                .GroupBy(ages => ages.Sum())
                .Where(ages => ages.Count() > 1)
                .SelectMany(ages => ages)
                .Where(ages => ages.Count(age => age == ages.Max()) == 1)
                .FirstOrDefault();

            Console.WriteLine(string.Join(", ", ages));
        }

        private static IEnumerable<int[]> PossibleAges(int agesProduct = 72)
        {
            for (int i = 1; i <= agesProduct; i++)
                for (int j = i; j <= agesProduct; j++)
                    for (int k = j; k <= agesProduct; k++)
                        if (i * j * k == agesProduct)
                            yield return new[] { i, j, k };
        }
    }
}
