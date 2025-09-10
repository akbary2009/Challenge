using System;
using System.Linq;

namespace Challenge.ProjectEuler
{
    /// <summary>
    /// https://projecteuler.net/problem=6
    /// </summary>
    public static class P6
    {
        public static int GetAnswer()
        {
            var nums = Enumerable.Range(1, 100);
            var squareSum = nums
                .Select(n => Math.Pow(n, 2))
                .Sum();

            return (int)(Math.Pow(nums.Sum(), 2) - squareSum);
        }
    }
}
