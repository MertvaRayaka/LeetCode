//给出两个 非空 的链表用来表示两个非负的整数。其中，它们各自的位数是按照 逆序 的方式存储的，
//并且它们的每个节点只能存储 一位 数字。
//如果，我们将这两个数相加起来，则会返回一个新的链表来表示它们的和。
//您可以假设除了数字 0 之外，这两个数都不会以 0 开头。

//示例：
//输入：(2 -> 4 -> 3) + (5 -> 6 -> 4)
//输出：7 -> 0 -> 8
//原因：342 + 465 = 807
using System.Collections.Generic;

namespace question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            
            var tempArr1 = new int[] { 2, 4, 3 };
            var tempArr2 = new int[] { 5, 6, 4 };
            var l1 = new ListNode(tempArr1[0]);
            var l2 = new ListNode(tempArr2[0]);
            var curr1 = l1;
            var curr2 = l2;
            for (int i = 1; i < tempArr1.Length; i++)
            {
                curr1.next = curr1.next ?? new ListNode(tempArr1[i]);
                curr1 = curr1.next;
                curr2.next = curr2.next ?? new ListNode(tempArr2[i]);
                curr2 = curr2.next;
            }

            ListNode l3 = solution.AddTwoNumbers(l1, l2);
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
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var listNode = new ListNode(-1);
            var currentNode = listNode;
            int temp = 0;

            while (l1 != null || l2 != null)
            {
                temp = (l1?.val ?? 0) + (l2?.val ?? 0) + temp / 10;
                currentNode.next = currentNode.next ?? new ListNode(temp % 10);
                currentNode = currentNode.next;
                l1 = l1?.next; 
                l2 = l2?.next;
            }
            return listNode.next;
        }
    }
}
