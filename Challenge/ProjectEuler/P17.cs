using System.Collections.Generic;

namespace Challenge.ProjectEuler
{
    /// <summary>
    /// https://projecteuler.net/problem=17
    /// </summary>
    public static class P17
    {
        private const string And = "and";

        private static Dictionary<int, string> NumberWordsDictionary => new Dictionary<int, string>
        {
            { 1, "one" },
            { 2, "two" },
            { 3, "three" },
            { 4, "four" },
            { 5, "five" },
            { 6, "six" },
            { 7, "seven" },
            { 8, "eight" },
            { 9, "nine" },
            { 10, "ten" },
            { 11, "eleven" },
            { 12, "twelve" },
            { 13, "thirteen" },
            { 14, "fourteen" },
            { 15, "fifteen" },
            { 16, "sixteen" },
            { 17, "seventeen" },
            { 18, "eighteen" },
            { 19, "nineteen" },
            { 20, "twenty" },
            { 30, "thirty" },
            { 40, "forty" },
            { 50, "fifty" },
            { 60, "sixty" },
            { 70, "seventy" },
            { 80, "eighty" },
            { 90, "ninety" },
            { 100, "hundred" },
            { 1000, "thousand" },
        };

        public static int GetAnswer()
        {
            var result = 0;
            for (int i = 1; i <= 1_000; i++)
                result += GetWord(i).Length;

            return result;
        }

        private static string GetWord(int number)
        {
            var word = string.Empty;

            do
            {
                if (number / 10 == 0)
                {
                    word += NumberWordsDictionary[number];
                    number = 0;
                }
                else if (number / 100 == 0)
                {
                    word += number < 20
                        ? NumberWordsDictionary[number]
                        : NumberWordsDictionary[number / 10 * 10];
                    number = number < 20 ? 0 : number % 10;
                }
                else if (number / 1000 == 0)
                {
                    word += NumberWordsDictionary[number / 100] + NumberWordsDictionary[100]
                        + (number % 100 != 0 ? And : string.Empty);
                    number %= 100;
                }
                else if (number / 1000 != 0)
                {
                    word += NumberWordsDictionary[number / 1000] + NumberWordsDictionary[1000]
                        + (number % 1000 != 0 ? And : string.Empty);
                    number %= 1000;
                }

            } while (number > 0);

            return word;
        }
    }
}
