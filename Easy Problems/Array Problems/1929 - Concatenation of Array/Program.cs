using System;
using System.Collections.Generic;
using System.Linq;

namespace _1929___Concatenation_of_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
            Console.WriteLine(string.Join(",",GetConcatenation(nums)));
        }

        private static int[] GetConcatenation(int[] nums)
        {
            List<int> ints = new List<int>(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                ints.Add(nums[i]);
            }
            return ints.ToArray();
        }
    }
}
