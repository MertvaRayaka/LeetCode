//合并两个有序链表

/*
 * 将两个升序链表合并为一个新的升序链表并返回。新链表是通过拼接给定的两个链表的所有节点组成的。 

示例：

输入：1->2->4, 1->3->4
输出：1->1->2->3->4->4

 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace question21
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new List<int> { 1, 2, 4 }.Concat(new List<int> { 1, 3, 4 }).OrderBy(p => p).ToList();
            Console.ReadLine();
        }
    }
}
