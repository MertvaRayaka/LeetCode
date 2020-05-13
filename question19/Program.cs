// 删除链表的倒数第N个节点
/*给定一个链表，删除链表的倒数第 n 个节点，并且返回链表的头结点。

示例：

给定一个链表: 1->2->3->4->5, 和 n = 2.

当删除了倒数第二个节点后，链表变为 1->2->3->5.
说明：

给定的 n 保证是有效的。

进阶：

你能尝试使用一趟扫描实现吗？

 */

using System.Collections.Generic;
using System.Linq;

namespace question19
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var r = solution.RemoveNthFromEnd(Enumerable.Range(1, 5).ToList(), 2);
            int[] arr = Enumerable.Range(1, 5).ToArray();

            ListNode Head = new ListNode(arr[0]);
            var tmp = Head;

            for (int i = 1; i < arr.Length; i++)
            {
                tmp.next = new ListNode(arr[i]);
                tmp = tmp.next;
            }
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
        public List<int> RemoveNthFromEnd(List<int> head, int n)
        {
            head.RemoveAt(head.Count - n);
            return head;
        }
    }
}
