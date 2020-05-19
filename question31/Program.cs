using PermutatianAndCombination;
using System;
using System.Collections.Generic;
using System.Linq;

//下一个排列
/*
 * 实现获取下一个排列的函数，算法需要将给定数字序列重新排列成字典序中下一个更大的排列。

如果不存在下一个更大的排列，则将数字重新排列成最小的排列（即升序排列）。

必须原地修改，只允许使用额外常数空间。

以下是一些例子，输入位于左侧列，其相应输出位于右侧列。
1,2,3 → 1,3,2
3,2,1 → 1,2,3
1,1,5 → 1,5,1

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/next-permutation
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
 */
namespace question31
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] source = new int[] { 1, 2, 3, 4 };
            string src = String.Join("", source);
            List<int[]> ArrList = PermutationAndCombination<int>.GetPermutation(source);
            List<string> DesList = new List<string>();
            foreach (var item in ArrList)
            {
                var tmp = string.Empty;
                foreach (var sub in item)
                {
                    tmp += sub;
                }
                DesList.Add(tmp);
            }

        }
    }
}
