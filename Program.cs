using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class Program
    {
        static void Main(string[] args)
        {
            // int target = 3;
            // int[] arrays = { 1, 3, 2 };
            // var a = TwoSum(arrays, target);
            // Console.WriteLine(a);
            var result =Reverse(345);
            Console.WriteLine(result);
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            var numsDictionary = new Dictionary<int, int>();

            var complement = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                complement = target - nums[i];
                var index = 0;
                if (complement > 0 && numsDictionary.TryGetValue(complement, out index))
                {
                    return new int[] { index, i };
                }

                if (numsDictionary.ContainsKey(nums[i]) == false)
                {
                    numsDictionary.Add(nums[i], i);
                }
            }

            return null;
        }
        public static int Reverse(int x)
        {
            int y = 0;

            while (x != 0)
            {
                int yy = y * 10 + x % 10;

                if ((yy - x % 10) / 10 != y) return 0;
                else y = yy;

                x = x / 10;
            }
            return y;
        }
    }
}
