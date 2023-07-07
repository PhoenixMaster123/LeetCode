using System;

namespace Valid_Perfect_Square

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(IsPerfectSquare(num));
        }

        private static bool IsPerfectSquare(int num)
        {
            bool result = false;
            if (num < 0)
            {
                return result;
            }
            if (num == 0 || num == 1)
            {
                result = true;
                return result;
            }
            for (int i = 0; i <= num / 2; i++)
            {
                if (i * i == num)
                {
                    result = true;
                    return result;
                }
            }
            return result;
        }


    }
}
