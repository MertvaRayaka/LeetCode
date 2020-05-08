//给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的那 两个 整数，并返回他们的数组下标。
//你可以假设每种输入只会对应一个答案。但是，数组中同一个元素不能使用两遍。

//示例:
//给定 nums = [2, 7, 11, 15], target = 9
//因为 nums[0] + nums[1] = 2 + 7 = 9
//所以返回[0, 1]

using System.Collections.Generic;
using System.Linq;

namespace question1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ElementAt> elements = new List<ElementAt>();
            elements = GetElements(new int[] { 2, 7, 4, 5, 3, 3, 6, 11, 15, 2, 7, 9, 0, -2 }, 9);
        }

        public static List<ElementAt> GetElements(int[] nums, int target)
        {
            List<ElementAt> list = new List<ElementAt>();
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (list.Any(p => p.Left == i || p.Right == i))
                {
                    continue;
                }
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (list.Any(p => p.Left == j || p.Right == j))
                    {
                        continue;
                    }
                    if ((nums[i] + nums[j]) == target)
                    {
                        list.Add(new ElementAt { Left = i, Right = j });
                        break;
                    }
                }
            }
            return list;
        }
    }

    public class ElementAt
    {
        public int Left { get; set; }
        public int Right { get; set; }
    }
}
