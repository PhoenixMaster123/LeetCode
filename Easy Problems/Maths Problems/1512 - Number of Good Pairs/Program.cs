using System;
using System.Linq;

namespace _1512___Number_of_Good_Pairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
            int count = 0;
            int s = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
             
                for (int j = s; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j] && numbers[i] <= numbers[j])
                    {
                        count++;
                    }

                }
                s++;
            }
            Console.WriteLine(count);
        }
    }
}
