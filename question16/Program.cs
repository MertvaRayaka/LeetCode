//最接近的三数之和
/*
 给定一个包括 n 个整数的数组 nums 和 一个目标值 target。找出 nums 中的三个整数，使得它们的和与 target 最接近。返回这三个数的和。假定每组输入只存在唯一答案。

例如，给定数组 nums = [-1，2，1，-4], 和 target = 1.
与 target 最接近的三个数的和为 2. (-1 + 2 + 1 = 2).
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace question16
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var r = solution.ThreeSumClosest(new int[] { -1, 1, 1, -4,4}, 1);
        }
    }

    public class Solution
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            int index = 0;
            int p1, p2 = 0;
            List<List<int>> ArrList = new List<List<int>>();
            while (index < nums.Length)
            {
                for (p1 = index + 1; p1 < nums.Length; p1++)
                {
                    for (p2 = p1 + 1; p2 < nums.Length; p2++)
                    {
                        ArrList.Add(new List<int> { Math.Abs(nums[index] + nums[p1] + nums[p2] - target), nums[index], nums[p1], nums[p2] });
                    }
                }
                index++;
            }
            var ClosestValue = ArrList.Min(p => p[0]);
            var res = ArrList.Where(p => p[0] == ClosestValue).ToList();
            for (int i = 0; i < res.Count; i++)
            {
                res[i] = res[i].Skip(1).ToList();
            }
            return ClosestValue;
        }
    }
}
