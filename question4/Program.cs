using System.Linq;

/*
 给定两个大小为 m 和 n 的正序（从小到大）数组 nums1 和 nums2。
请你找出这两个正序数组的中位数，并且要求算法的时间复杂度为 O(log(m + n))。
你可以假设 nums1 和 nums2 不会同时为空。

示例 1:
nums1 = [1, 3]
nums2 = [2]
则中位数是 2.0

示例 2:
nums1 = [1, 2]
nums2 = [3, 4]
则中位数是 (2 + 3)/2 = 2.5
*/
namespace question4
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var reult = solution.FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2 });
        }
    }

    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var result = nums1.Concat(nums2).OrderBy(p => p).ToArray();
            if (result.Count() % 2 == 0)
            {
                return (result[result.Count() / 2 - 1] + result[result.Count() / 2]) / 2;
            }
            else
            {
                return result[result.Count() / 2];
            }
        }
    }
}
