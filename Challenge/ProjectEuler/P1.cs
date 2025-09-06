using System.Linq;

namespace Challenge.ProjectEuler
{
    /// <summary>
    /// https://projecteuler.net/problem=1
    /// </summary>
    public static class P1
    {
        public static string GetAnswer()
        {
            return Enumerable.Range(1, 1_000 - 1)
                .Where(n => n % 3 == 0 || n % 5 == 0)
                .Sum()
                .ToString();
        }
    }
}
