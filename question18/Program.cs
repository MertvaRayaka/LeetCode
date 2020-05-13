//四数之和
/*
 * 给定一个包含 n 个整数的数组 nums 和一个目标值 target，判断 nums 中是否存在四个元素 a，b，c 和 d ，使得 a + b + c + d 的值与 target 相等？找出所有满足条件且不重复的四元组。

注意：

答案中不可以包含重复的四元组。

示例：

给定数组 nums = [1, 0, -1, 0, -2, 2]，和 target = 0。

满足要求的四元组集合为：
[
  [-1,  0, 0, 1],
  [-2, -1, 1, 2],
  [-2,  0, 0, 2]
]

 */

using System.Collections.Generic;
using System.Linq;

namespace question18
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var r = solution.FourSum(new int[] { 1, 0, -1, 0, -2, 2, 3, -3 }, 0);
        }
    }


    public class Solution
    {
        public List<List<int>> FourSum(int[] nums, int target)
        {
            var res = new List<List<int>>();
            int index = 0;
            while (index < nums.Length)
            {
                //递归怎么处理？
                for (int p1 = index + 1; p1 < nums.Length; p1++)
                {
                    for (int p2 = p1 + 1; p2 < nums.Length; p2++)
                    {
                        for (int p3 = p2 + 1; p3 < nums.Length; p3++)
                        {
                            res.Add(new List<int> { nums[index], nums[p1], nums[p2], nums[p3] });
                        }
                    }
                }
                index++;
            }
            return res.Where(p => p.Sum() == target).Select(p => p.OrderBy(q => q).ToList()).ToList();
        }
    }
}
