using System;
using System.Linq;

namespace _2_Build_Array_from_Permutation
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int[] ans = BuildArray(nums);
            Console.WriteLine(string.Join(", ", ans));
        }

        private static int[] BuildArray(int[] nums)
        {
            int[] ans = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                ans[i] = nums[nums[i]];
            }
            return ans;
        }
    }
}
