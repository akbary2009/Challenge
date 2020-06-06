using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge.ProjectEuler
{
    public static class P22
    {
        private const string FileName = @"C:\Users\user\Downloads\p022_names.txt";

        public static ulong GetAnswer()
        {
            object lockObject = new object();
            ulong totalScore = 0;

            var names = File.ReadAllText(FileName)
                .Split(',')
                .OrderBy(name => name);
            Parallel.For(0, names.Count(), i =>
            {
                var nameScore = names.ElementAt(i)
                    .Trim('"')
                    .ToLower()
                    .Select(GetAlphabeticalValue)
                    .Sum() * (i + 1);
                lock (lockObject)
                {
                    totalScore += (ulong)nameScore;
                }
            });

            return totalScore;


            static int GetAlphabeticalValue(char letter) =>
                (letter - 'a') + 1;
        }
    }
}
