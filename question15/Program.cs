//三数之和
/*给你一个包含 n 个整数的数组 nums，判断 nums 中是否存在三个元素 a，b，c ，使得 a + b + c = 0 ？请你找出所有满足条件且不重复的三元组。

注意：答案中不可以包含重复的三元组。

示例：

给定数组 nums = [-1, 0, 1, 2, -1, -4]，

满足要求的三元组集合为：
[
  [-1, 0, 1],
  [-1, -1, 2]
]
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace question15
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var r = solution.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4, 4, -2 });
        }
    }

    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> res = new List<IList<int>>(); 
            var strList = new List<string>();
            int index = 0, p1 = 0, p2 = 0;

            while (index < nums.Length)
            {
                for (p1 = index + 1; p1 < nums.Length; p1++)
                {
                    for (p2 = p1 + 1; p2 < nums.Length; p2++)
                    {
                        if ((nums[index] + nums[p1] + nums[p2]) == 0)
                        {
                            res.Add(new List<int> { nums[index], nums[p1], nums[p2] });
                        }
                    }
                }
                index++;
            }        
            foreach (var item in res)
            {
                var temp = string.Join(",", item.OrderBy(p => p));
                strList.Add(temp);
            }
            res.Clear();
            foreach (var item in strList.Distinct())
            {
                var temp = new List<int>();
                item.Split(',').ToList().ForEach(p => temp.Add(Convert.ToInt32(p)));
                res.Add(temp);
            }
            return res;
        }
    }
}
