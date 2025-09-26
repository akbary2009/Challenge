using System.Collections.Generic;
using System.Linq;

namespace Challenge.ProjectEuler
{
    /// <summary>
    /// https://projecteuler.net/problem=34
    /// </summary>
    public static class P34
    {
        public static int GetAnswer()
        {
            return GetSequence()
                .Sum();


            IEnumerable<int> GetSequence()
            {
                for (int i = 10; i < 300_000; i++)
                {
                    var digitsSum = i.ToString()
                        .Select(c => int.Parse(c.ToString()))
                        .Select(Fact)
                        .Sum();
                    if (i == digitsSum)
                        yield return i;
                }
            }
        }

        private static int Fact(int number)
        {
            if (number <= 1) return 1;

            return number * Fact(number - 1);
        }
    }
}
