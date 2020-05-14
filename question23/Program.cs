// 合并K个排序链表

/*
 * 合并 k 个排序链表，返回合并后的排序链表。请分析和描述算法的复杂度。

示例:

输入:
[
  1->4->5,
  1->3->4,
  2->6
]
输出: 1->1->2->3->4->4->5->6

 */
using System.Collections.Generic;
using System.Linq;

namespace question23
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = CreateList(new List<List<int>> { new List<int> { 1, 4, 5 }, new List<int> { 1, 3, 4 }, new List<int> { 2, 6 } });
        }

        private static List<int> CreateList(List<List<int>> ArrList)
        {
            List<int> tmp = new List<int>();
            for (int i = 0; i < ArrList.Count; i++)
            {
                tmp = tmp.Concat(ArrList[i]).ToList();
            }
            return tmp.OrderBy(p => p).ToList();
        }
    }


}
