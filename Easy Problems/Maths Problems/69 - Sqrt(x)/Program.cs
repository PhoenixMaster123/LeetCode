using System;

namespace _69___Sqrt_x_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int x = int.Parse(Console.ReadLine());
            Console.WriteLine(MySqrt(x));
        }

        private static int MySqrt(int x)
        {
           double square = Math.Sqrt(x);
           double result = Math.Floor(square);
           int finall = (int)result;
           return finall;

        }
    }
}
