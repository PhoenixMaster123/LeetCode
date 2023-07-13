using System;

namespace _2769._Find_the_Maximum_Achievable_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int t = int.Parse(Console.ReadLine());
            Console.WriteLine(TheMaximumAchievableX(num,t));
        }

        private static int TheMaximumAchievableX(int num, int t)
        {
            int x = num + t + t;
            return x;
        }
    }
}
