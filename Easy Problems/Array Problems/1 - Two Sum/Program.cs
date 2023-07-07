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
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == target - nums[i])
                    {
                        return new int[] { i, j };
                    }
                }
            }
            // In case there is no solution, we'll just return null
            return null;
        }
    }
}
