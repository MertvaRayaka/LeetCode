using System;
using System.Collections.Generic;
using System.Linq;


/*
给定一个字符串 s，找到 s 中最长的回文子串。你可以假设 s 的最大长度为 1000。
示例 1：
输入: "babad"
输出: "bab"
注意: "aba" 也是一个有效答案。

示例 2：
输入: "cbbd"
输出: "bb"
*/
namespace question5
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            var r = solution.LongestPalindrome("babcccsfsdfqwertyuytrewqad");
        }
    }

    public class Element
    {
        public int Len { get; set; }
        public string Str { get; set; }
    }

    public class Solution
    {
        public List<string> LongestPalindrome(string s)
        {
            int index = 0;
            var list = new List<Element>();
            while (index < s.Length)
            {
                for (int i = 0; i <= s.Length - index; i++)
                {
                    var SplitStr = String.Join("", s.Skip(index).Take(i));
                    if (IsPalindromic(SplitStr) && !String.IsNullOrEmpty(SplitStr))
                    {
                        list.Add(new Element { Str = SplitStr, Len = SplitStr.Length });
                    }
                }
                index++;
            }
            var MaxLen = list.Max(p => p.Len);
            var r = list.FindAll(p => p.Len == MaxLen);
            return r.Select(p => p.Str).ToList();
        }

        public bool IsPalindromic(string SourceStr)
        {
            var ReverseStr = String.Join("", SourceStr.Reverse());
            return String.Equals(SourceStr, ReverseStr);
        }
    }
}
