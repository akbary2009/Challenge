using System;

namespace Challenge.ProjectEuler
{
    /// <summary>
    /// https://projecteuler.net/problem=19
    /// </summary>
    public static class P19
    {
        public static int GetAnswer()
        {
            var counter = 0;
            for (DateTime date = new DateTime(1901, 1, 1); date <= new DateTime(2000, 12, 31); date = date.AddMonths(1))
            {
                if (date.DayOfWeek == DayOfWeek.Sunday && date.Day == 1)
                    counter++;
            }

            return counter;
        }
    }
}
