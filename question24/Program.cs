using System.Collections.Generic;
using System.Linq;

//两两交换链表中的节点
/*
 * 给定一个链表，两两交换其中相邻的节点，并返回交换后的链表。

你不能只是单纯的改变节点内部的值，而是需要实际的进行节点交换。

 

示例:

给定 1->2->3->4, 你应该返回 2->1->4->3.


 */
namespace question24
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = CreateList(new List<int> { 10, 20, 30, 4, 5 ,6});

            //Solution solution = new Solution();

            //int[] arr = Enumerable.Range(1, 10).ToArray();

            //ListNode Head = new ListNode(arr[0]);
            //var tmp = Head;

            //for (int i = 1; i < arr.Length; i++)
            //{
            //    tmp.next = new ListNode(arr[i]);
            //    tmp = tmp.next;
            //}
            //var rr = solution.SwapPairs(Head);
        }

        private static List<int> CreateList(List<int> source)
        {
            List<int> res = new List<int>();
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < source.Count; i++)
            {
                dic.Add(i, source[i]);
            }
            var EvenList = dic.Where(p => p.Key % 2 == 0).ToList();
            var OddList = dic.Where(p => p.Key % 2 == 1).ToList();

            int p1 = 0, p2 = 0;
            while ((p1 + p2) < source.Count)
            {
                if (p1 < OddList.Count)
                {
                    res.Add(OddList[p1].Value);
                    p1++;
                }
                if (p2 < EvenList.Count)
                {
                    res.Add(EvenList[p2].Value);
                    p2++;
                }                 
            }
            return res;
        }
    }


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode dummy = new ListNode(0);
            dummy.next = head;

            ListNode pre = dummy;
            ListNode first = head;
            ListNode second = head.next;
            while (first != null && second != null)
            {
                first.next = second.next;
                second.next = first;
                pre.next = second;

                pre = first;
                first = first.next;
                if (first != null)
                {
                    second = first.next;
                }
            }

            return dummy.next;

        }
    }

}
