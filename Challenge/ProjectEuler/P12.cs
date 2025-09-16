using System.Collections.Generic;
using System.Linq;

namespace Challenge.ProjectEuler
{
    /// <summary>
    /// https://projecteuler.net/problem=12
    /// </summary>
    public static class P12
    {
        public static int GetAnswer()
        {
            var triangleNumber = 0;
            for (int i = 1; i < int.MaxValue; i++)
            {
                triangleNumber += i;
                if (GetDivisors(triangleNumber).Count() > 500)
                    return triangleNumber;
            }

            return 0;
        }

        private static IEnumerable<int> GetDivisors(int number)
        {
            yield return 1;

            for (int i = 2; i <= number / 2; i++)
                if (number % i == 0)
                    yield return i;

            yield return number;
        }
    }
}
