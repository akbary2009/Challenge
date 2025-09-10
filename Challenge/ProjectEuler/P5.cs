namespace Challenge.ProjectEuler
{
    /// <summary>
    /// https://projecteuler.net/problem=5
    /// </summary>
    public static class P5
    {
        public static int GetAnswer()
        {
            for (int i = 20; i < int.MaxValue; i++)
                if (IsDivisible(i)) return i;

            return 0;
        }

        private static bool IsDivisible(int number)
        {
            for (int i = 2; i <= 20; i++)
                if (number % i != 0) return false;

            return true;
        }
    }
}
