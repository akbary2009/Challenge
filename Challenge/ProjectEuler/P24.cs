using System.Collections.Generic;
using System.Linq;

namespace Challenge.ProjectEuler
{
    /// <summary>
    /// https://projecteuler.net/problem=24
    /// </summary>
    public static class P24
    {
        public static string GetAnswer()
        {
            var digits = Enumerable.Range(0, 10).Select(n => n.ToString());
            var lexicographicPermutations = GetLexicographicPermutations(digits);

            return lexicographicPermutations
                .Skip(1_000_000 - 1)
                .Take(1)
                .FirstOrDefault();
        }

        private static IEnumerable<string> GetLexicographicPermutations(IEnumerable<string> list)
        {
            if (list.Count() == 1) yield return list.First();

            foreach (var item in list)
                foreach (var p in GetLexicographicPermutations(list.Except(new[] { item })))
                    yield return item + p;
        }
    }
}
