/*
给你 n 个非负整数 a1，a2，...，an，每个数代表坐标中的一个点 (i, ai) 。
在坐标内画 n 条垂直线，垂直线 i 的两个端点分别为 (i, ai) 和 (i, 0)。找出其中的两条线，
使得它们与 x 轴共同构成的容器可以容纳最多的水。
*/

using System.Collections.Generic;
using System.Linq;

namespace question8
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var r = solution.MaxArea(new int[] { 1, 9, 2, 3, 4, 5, 7, 9, 3, 8, 3, 4, 5, 6, 1, 8, 6, 2, 5, 4, 8, 3, 7 });
        }
    }

    public class Solution
    {
        public int MaxArea(int[] height)
        {
            List<Element> elements = new List<Element>();
            int index = 0, square = 0;
            while (index < height.Length)
            {
                for (int i = index + 1; i < height.Length; i++)
                {
                    square = (i - index) * (new int[2] { height[index], height[i] }.Min());
                    elements.Add(new Element { IndexL = index, IndexR = i, Square = square });
                }
                index++;
            }
            var Res = elements.Max(p => p.Square);
            var ConcreteRes = elements.FindAll(p => p.Square == Res);
            return Res;
        }

        class Element
        {
            public int IndexL { get; set; }
            public int IndexR { get; set; }
            public int Square { get; set; }
        }
    }


}
