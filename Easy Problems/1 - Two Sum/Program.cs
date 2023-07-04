using System;
using System.Linq;

namespace _1__Two_Sum___Easy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray(); // Read Massiv 
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(", ", TwoSum(nums, target))); // Combine Massiv
        }

        private static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] + nums[i + 1] == target)
                {
                    return new int[] { i, i + 1 };
                }
            }

            // If no pair is found, you can return null or an empty array.
            return new int[0];
        }
    }
}
