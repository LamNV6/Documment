using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class Program
    {
        static void Main(string[] args)
        {
            int target=3;
            int [] arrays= new int [3];
            Console.Write("\n\nTwo sum: \n");
            Console.Write("Input 3 numbers: \n");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("number - {0} :", i);
                arrays[i]=Convert.ToInt32(Console.ReadLine());
            }
            var a=TwoSum(arrays,target);
            Console.WriteLine(a);
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
    }
}
