using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge.ProjectEuler
{
    public static class P23
    {
        private const int MaxInteger = 28123;

        public static int GetAnswer()
        {
            var abundantNumbersSums = GetAbundantNumbersSums();
            //return Enumerable.Range(1, MaxInteger + 1)
            //    .Where(n => !IsSumOfTwoAbundantNumbers(n, abundantNumbersSums))
            //    .Sum();

            var sum = 0;
            Parallel.For(1, MaxInteger + 1, i =>
            {
                if (!IsSumOfTwoAbundantNumbers(i, abundantNumbersSums))
                    System.Threading.Interlocked.Add(ref sum, i);
            });
            return sum;
        }

        private static bool IsSumOfTwoAbundantNumbers(int number, Dictionary<int, bool> abundantNumbers) =>
            abundantNumbers.ContainsKey(number);

        private static Dictionary<int, bool> GetAbundantNumbersSums()
        {
            var dic = new Dictionary<int, bool>();
            var abundantNumbers = GetAbundantNumbers();

            for (int i = 0; i < abundantNumbers.Count; i++)
            {
                for (int j = i; j < abundantNumbers.Count; j++)
                {
                    var sum = abundantNumbers.ElementAt(i) + abundantNumbers.ElementAt(j);
                    dic[sum] = true;
                }
            }

            return dic;
        }

        private static List<int> GetAbundantNumbers(int min = 12, int max = MaxInteger)
        {
            return Enumerable.Range(min, max - min + 1)
                .Where(IsAbundantNumber)
                .ToList();


            static bool IsAbundantNumber(int number)
            {
                var divisorsSum = 1;
                for (int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        divisorsSum += i;
                        if (divisorsSum > number)
                            break;
                    }
                }

                return divisorsSum > number;
            }
        }
    }
}
