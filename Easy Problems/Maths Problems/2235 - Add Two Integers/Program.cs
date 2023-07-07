using System;

namespace _2235___Add_Two_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Sum(num1,num2));
        }

        private static int Sum(int num1, int num2)
        {
          return num1 + num2;
        }
    }
}
