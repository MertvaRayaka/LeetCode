/*给定一个字符串，请你找出其中不含有重复字符的 最长子串 的长度。

示例 1:

输入: "abcabcbb"
输出: 3 
解释: 因为无重复字符的最长子串是 "abc"，所以其长度为 3。
示例 2:

输入: "bbbbb"
输出: 1
解释: 因为无重复字符的最长子串是 "b"，所以其长度为 1。
示例 3:

输入: "pwwkew"
输出: 3
解释: 因为无重复字符的最长子串是 "wke"，所以其长度为 3。
     请注意，你的答案必须是 子串 的长度，"pwke" 是一个子序列，不是子串。
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string str = "abcasdfsrwegvcxdddereresfgfdgre" +
                "tlkuroweiroqwtijkncxiviayuierhtqinfjklsdglfds" +
                "lgjhdfsopgerotureopihgdnsvkjlfnsdghfsdgeriop" +
                "utioregjdfhlsghdfspgqwertyuiopasdfghjklzxcvbnmd" +
                "xxsadsadsdxcjlkjfoeiwrhnsdjkbkhhqwuioueoiqjkdnc" +
                "vuiefotirnei243294823jnwjknvcsddvsdfbcbb" +
                "abcasdfsrwegvcxdddereresfgfdgre" +
                "tlkuroweiroqwtijkncxiviayuierhtqinfjklsdglfds" +
                "lgjhdfsopgerotureopihgdnsvkjlfnsdghfsdgeriop" +
                "utioregjdfhlsghdfspgqwertyuiopasdfghjklzxcvbnmd" +
                "xxsadsadsdxcjlkjfoeiwrhnsdjkbkhhqwuioueoiqjkdnc" +
                "vuiefotirnei243294823jnwjknvcsddvsdfbcbb" +
                "abcasdfsrwegvcxdddereresfgfdgre" +
                "tlkuroweiroqwtijkncxiviayuierhtqinfjklsdglfds" +
                "lgjhdfsopgerotureopihgdnsvkjlfnsdghfsdgeriop" +
                "utioregjdfhlsghdfspgqwertyuiopasdfghjklzxcvbnmd" +
                "xxsadsadsdxcjlkjfoeiwrhnsdjkbkhhqwuioueoiqjkdnc" +
                "vuiefotirnei243294823jnwjknvcsddvsdfbcbb" +
                "abcasdfsrwegvcxdddereresfgfdgre" +
                "tlkuroweiroqwtijkncxiviayuierhtqinfjklsdglfds" +
                "lgjhdfsopgerotureopihgdnsvkjlfnsdghfsdgeriop" +
                "utioregjdfhlsghdfspgqwertyuiopasdfghjklzxcvbnmd" +
                "xxsadsadsdxcjlkjfoeiwrhnsdjkbkhhqwuioueoiqjkdnc" +
                "vuiefotirnei243294823jnwjknvcsddvsdfbcbb"
                + "abcasdfsrwegvcxdddereresfgfdgre" +
                "tlkuroweiroqwtijkncxiviayuierhtqinfjklsdglfds" +
                "lgjhdfsopgerotureopihgdnsvkjlfnsdghfsdgeriop" +
                "utioregjdfhlsghdfspgqwertyuiopasdfghjklzxcvbnmd" +
                "xxsadsadsdxcjlkjfoeiwrhnsdjkbkhhqwuioueoiqjkdnc" +
                "vuiefotirnei243294823jnwjknvcsddvsdfbcbb" +
                "abcasdfsrwegvcxdddereresfgfdgre" +
                "tlkuroweiroqwtijkncxiviayuierhtqinfjklsdglfds" +
                "lgjhdfsopgerotureopihgdnsvkjlfnsdghfsdgeriop" +
                "utioregjdfhlsghdfspgqwertyuiopasdfghjklzxcvbnmd" +
                "xxsadsadsdxcjlkjfoeiwrhnsdjkbkhhqwuioueoiqjkdnc" +
                "vuiefotirnei243294823jnwjknvcsddvsdfbcbb" +
                "abcasdfsrwegvcxdddereresfgfdgre" +
                "tlkuroweiroqwtijkncxiviayuierhtqinfjklsdglfds" +
                "lgjhdfsopgerotureopihgdnsvkjlfnsdghfsdgeriop" +
                "utioregjdfhlsghdfspgqwertyuiopasdfghjklzxcvbnmd" +
                "xxsadsadsdxcjlkjfoeiwrhnsdjkbkhhqwuioueoiqjkdnc" +
                "vuiefotirnei243294823jnwjknvcsddvsdfbcbb" +
                "abcasdfsrwegvcxdddereresfgfdgre" +
                "tlkuroweiroqwtijkncxiviayuierhtqinfjklsdglfds" +
                "lgjhdfsopgerotureopihgdnsvkjlfnsdghfsdgeriop" +
                "utioregjdfhlsghdfspgqwertyuiopasdfghjklzxcvbnmd" +
                "xxsadsadsdxcjlkjfoeiwrhnsdjkbkhhqwuioueoiqjkdnc" +
                "vuiefotirnei243294823jnwjknvcsddvsdfbcbb" +
                "abcasdfsrwegvcxdddereresfgfdgre" +
                "tlkuroweiroqwtijkncxiviayuierhtqinfjklsdglfds" +
                "lgjhdfsopgerotureopihgdnsvkjlfnsdghfsdgeriop" +
                "utioregjdfhlsghdfspgqwertyuiopasdfghjklzxcvbnmd" +
                "xxsadsadsdxcjlkjfoeiwrhnsdjkbkhhqwuioueoiqjkdnc" +
                "vuiefotirnei243294823jnwjknvcsddvsdfbcbb" +
                "abcasdfsrwegvcxdddereresfgfdgre" +
                "tlkuroweiroqwtijkncxiviayuierhtqinfjklsdglfds" +
                "lgjhdfsopgerotureopihgdnsvkjlfnsdghfsdgeriop" +
                "utioregjdfhlsghdfspgqwertyuiopasdfghjklzxcvbnmd" +
                "xxsadsadsdxcjlkjfoeiwrhnsdjkbkhhqwuioueoiqjkdnc" +
                "vuiefotirnei243294823jnwjknvcsddvsdfbcbb" +
                "abcasdfsrwegvcxdddereresfgfdgre" +
                "tlkuroweiroqwtijkncxiviayuierhtqinfjklsdglfds" +
                "lgjhdfsopgerotureopihgdnsvkjlfnsdghfsdgeriop" +
                "utioregjdfhlsghdfspgqwertyuiopasdfghjklzxcvbnmd" +
                "xxsadsadsdxcjlkjfoeiwrhnsdjkbkhhqwuioueoiqjkdnc" +
                "vuiefotirnei243294823jnwjknvcsddvsdfbcbb" +
                "abcasdfsrwegvcxdddereresfgfdgre" +
                "tlkuroweiroqwtijkncxiviayuierhtqinfjklsdglfds" +
                "lgjhdfsopgerotureopihgdnsvkjlfnsdghfsdgeriop" +
                "utioregjdfhlsghdfspgqwertyuiopasdfghjklzxcvbnmd" +
                "xxsadsadsdxcjlkjfoeiwrhnsdjkbkhhqwuioueoiqjkdnc" +
                "vuiefotirnei243294823jnwjknvcsddvsdfbcbb" +
                "abcasdfsrwegvcxdddereresfgfdgre" +
                "tlkuroweiroqwtijkncxiviayuierhtqinfjklsdglfds" +
                "lgjhdfsopgerotureopihgdnsvkjlfnsdghfsdgeriop" +
                "utioregjdfhlsghdfspgqwertyuiopasdfghjklzxcvbnmd" +
                "xxsadsadsdxcjlkjfoeiwrhnsdjkbkhhqwuioueoiqjkdnc" +
                "vuiefotirnei243294823jnwjknvcsddvsdfbcbb" +
                "abcasdfsrwegvcxdddereresfgfdgre" +
                "tlkuroweiroqwtijkncxiviayuierhtqinfjklsdglfds" +
                "lgjhdfsopgerotureopihgdnsvkjlfnsdghfsdgeriop" +
                "utioregjdfhlsghdfspgqwertyuiopasdfghjklzxcvbnmd" +
                "xxsadsadsdxcjlkjfoeiwrhnsdjkbkhhqwuioueoiqjkdnc" +
                "vuiefotirnei243294823jnwjknvcsddvsdfbcbb"
                + "abcasdfsrwegvcxdddereresfgfdgre" +
                "tlkuroweiroqwtijkncxiviayuierhtqinfjklsdglfds" +
                "lgjhdfsopgerotureopihgdnsvkjlfnsdghfsdgeriop" +
                "utioregjdfhlsghdfspgqwertyuiopasdfghjklzxcvbnmd" +
                "xxsadsadsdxcjlkjfoeiwrhnsdjkbkhhqwuioueoiqjkdnc" +
                "vuiefotirnei243294823jnwjknvcsddvsdfbcbb" +
                "abcasdfsrwegvcxdddereresfgfdgre" +
                "tlkuroweiroqwtijkncxiviayuierhtqinfjklsdglfds" +
                "lgjhdfsopgerotureopihgdnsvkjlfnsdghfsdgeriop" +
                "utioregjdfhlsghdfspgqwertyuiopasdfghjklzxcvbnmd" +
                "xxsadsadsdxcjlkjfoeiwrhnsdjkbkhhqwuioueoiqjkdnc" +
                "vuiefotirnei243294823jnwjknvcsddvsdfbcbb" +
                "abcasdfsrwegvcxdddereresfgfdgre" +
                "tlkuroweiroqwtijkncxiviayuierhtqinfjklsdglfds" +
                "lgjhdfsopgerotureopihgdnsvkjlfnsdghfsdgeriop" +
                "utioregjdfhlsghdfspgqwertyuiopasdfghjklzxcvbnmd" +
                "xxsadsadsdxcjlkjfoeiwrhnsdjkbkhhqwuioueoiqjkdnc" +
                "vuiefotirnei243294823jnwjknvcsddvsdfbcbb" +
                "abcasdfsrwegvcxdddereresfgfdgre" +
                "tlkuroweiroqwtijkncxiviayuierhtqinfjklsdglfds" +
                "lgjhdfsopgerotureopihgdnsvkjlfnsdghfsdgeriop" +
                "utioregjdfhlsghdfspgqwertyuiopasdfghjklzxcvbnmd" +
                "xxsadsadsdxcjlkjfoeiwrhnsdjkbkhhqwuioueoiqjkdnc" +
                "vuiefotirnei243294823jnwjknvcsddvsdfbcbb" +
                "abcasdfsrwegvcxdddereresfgfdgre" +
                "tlkuroweiroqwtijkncxiviayuierhtqinfjklsdglfds" +
                "lgjhdfsopgerotureopihgdnsvkjlfnsdghfsdgeriop" +
                "utioregjdfhlsghdfspgqwertyuiopasdfghjklzxcvbnmd" +
                "xxsadsadsdxcjlkjfoeiwrhnsdjkbkhhqwuioueoiqjkdnc" +
                "vuiefotirnei243294823jnwjknvcsddvsdfbcbb" +
                "abcasdfsrwegvcxdddereresfgfdgre" +
                "tlkuroweiroqwtijkncxiviayuierhtqinfjklsdglfds" +
                "lgjhdfsopgerotureopihgdnsvkjlfnsdghfsdgeriop" +
                "utioregjdfhlsghdfspgqwertyuiopasdfghjklzxcvbnmd" +
                "xxsadsadsdxcjlkjfoeiwrhnsdjkbkhhqwuioueoiqjkdnc" +
                "vuiefotirnei243294823jnwjknvcsddvsdfbcbb" +
                "abcasdfsrwegvcxdddereresfgfdgre" +
                "tlkuroweiroqwtijkncxiviayuierhtqinfjklsdglfds" +
                "lgjhdfsopgerotureopihgdnsvkjlfnsdghfsdgeriop" +
                "utioregjdfhlsghdfspgqwertyuiopasdfghjklzxcvbnmd" +
                "xxsadsadsdxcjlkjfoeiwrhnsdjkbkhhqwuioueoiqjkdnc" +
                "vuiefotirnei243294823jnwjknvcsddvsdfbcbb" +
                "abcasdfsrwegvcxdddereresfgfdgre" +
                "tlkuroweiroqwtijkncxiviayuierhtqinfjklsdglfds" +
                "lgjhdfsopgerotureopihgdnsvkjlfnsdghfsdgeriop" +
                "utioregjdfhlsghdfspgqwertyuiopasdfghjklzxcvbnmd" +
                "xxsadsadsdxcjlkjfoeiwrhnsdjkbkhhqwuioueoiqjkdnc" +
                "vuiefotirnei243294823jnwjknvcsddvsdfbcbb" +
                "abcasdfsrwegvcxdddereresfgfdgre" +
                "tlkuroweiroqwtijkncxiviayuierhtqinfjklsdglfds" +
                "lgjhdfsopgerotureopihgdnsvkjlfnsdghfsdgeriop" +
                "utioregjdfhlsghdfspgqwertyuiopasdfghjklzxcvbnmd" +
                "xxsadsadsdxcjlkjfoeiwrhnsdjkbkhhqwuioueoiqjkdnc" +
                "vuiefotirnei243294823jnwjknvcsddvsdfbcbb" +
                "abcasdfsrwegvcxdddereresfgfdgre" +
                "tlkuroweiroqwtijkncxiviayuierhtqinfjklsdglfds" +
                "lgjhdfsopgerotureopihgdnsvkjlfnsdghfsdgeriop" +
                "utioregjdfhlsghdfspgqwertyuiopasdfghjklzxcvbnmd" +
                "xxsadsadsdxcjlkjfoeiwrhnsdjkbkhhqwuioueoiqjkdnc" +
                "vuiefotirnei243294823jnwjknvcsddvsdfbcbb"
                + "abcasdfsrwegvcxdddereresfgfdgre" +
                "tlkuroweiroqwtijkncxiviayuierhtqinfjklsdglfds" +
                "lgjhdfsopgerotureopihgdnsvkjlfnsdghfsdgeriop" +
                "utioregjdfhlsghdfspgqwertyuiopasdfghjklzxcvbnmd" +
                "xxsadsadsdxcjlkjfoeiwrhnsdjkbkhhqwuioueoiqjkdnc" +
                "vuiefotirnei243294823jnwjknvcsddvsdfbcbb" +
                "abcasdfsrwegvcxdddereresfgfdgre" +
                "tlkuroweiroqwtijkncxiviayuierhtqinfjklsdglfds" +
                "lgjhdfsopgerotureopihgdnsvkjlfnsdghfsdgeriop" +
                "utioregjdfhlsghdfspgqwertyuiopasdfghjklzxcvbnmd" +
                "xxsadsadsdxcjlkjfoeiwrhnsdjkbkhhqwuioueoiqjkdnc" +
                "vuiefotirnei243294823jnwjknvcsddvsdfbcbb" +
                "abcasdfsrwegvcxdddereresfgfdgre" +
                "tlkuroweiroqwtijkncxiviayuierhtqinfjklsdglfds" +
                "lgjhdfsopgerotureopihgdnsvkjlfnsdghfsdgeriop" +
                "utioregjdfhlsghdfspgqwertyuiopasdfghjklzxcvbnmd" +
                "xxsadsadsdxcjlkjfoeiwrhnsdjkbkhhqwuioueoiqjkdnc" +
                "vuiefotirnei243294823jnwjknvcsddvsdfbcbb" +
                "abcasdfsrwegvcxdddereresfgfdgre" +
                "tlkuroweiroqwtijkncxiviayuierhtqinfjklsdglfds" +
                "lgjhdfsopgerotureopihgdnsvkjlfnsdghfsdgeriop" +
                "utioregjdfhlsghdfspgqwertyuiopasdfghjklzxcvbnmd" +
                "xxsadsadsdxcjlkjfoeiwrhnsdjkbkhhqwuioueoiqjkdnc" +
                "vuiefotirnei243294823jnwjknvcsddvsdfbcbb" +
                "abcasdfsrwegvcxdddereresfgfdgre" +
                "tlkuroweiroqwtijkncxiviayuierhtqinfjklsdglfds" +
                "lgjhdfsopgerotureopihgdnsvkjlfnsdghfsdgeriop" +
                "utioregjdfhlsghdfspgqwertyuiopasdfghjklzxcvbnmd" +
                "xxsadsadsdxcjlkjfoeiwrhnsdjkbkhhqwuioueoiqjkdnc" +
                "vuiefotirnei243294823jnwjknvcsddvsdfbcbb" +
                "abcasdfsrwegvcxdddereresfgfdgre" +
                "tlkuroweiroqwtijkncxiviayuierhtqinfjklsdglfds" +
                "lgjhdfsopgerotureopihgdnsvkjlfnsdghfsdgeriop" +
                "utioregjdfhlsghdfspgqwertyuiopasdfghjklzxcvbnmd" +
                "xxsadsadsdxcjlkjfoeiwrhnsdjkbkhhqwuioueoiqjkdnc" +
                "vuiefotirnei243294823jnwjknvcsddvsdfbcbb";
            var result = solution.LengthOfLongestSubstring(str);
            Console.WriteLine(result);
            int resultTask = 0;
            var elements = new List<Element>();
            Task.Run(() => resultTask = solution.LengthOfLongestSubstring1(str, ref elements).Result)
                .ContinueWith(new Action<Task<int>>(p => Console.WriteLine(resultTask)));
            Console.ReadLine();
        }
    }

    public class Element
    {
        public string Str { get; set; }
        public int Len { get; set; }
    }

    public class Solution
    {
        public Task<int> LengthOfLongestSubstring1(string s, ref List<Element> elementsref)
        {
            int index = 0;
            List<Element> elements = new List<Element>();
            while (index < s.Length)
            {
                for (int i = 0; i < s.Length - index; i++)
                {
                    var substr = String.Join("", s.Skip(index).Take(i));
                    bool flag = substr.GroupBy(p => p).Any(p => p.Count() > 1);
                    if (!flag && !String.IsNullOrEmpty(substr))
                    {
                        elements.Add(new Element { Str = substr, Len = substr.Length });
                    }
                    if (substr.GroupBy(p => p).Any(p => p.Count() > 1)) break;
                }
                index++;
            }

            var Max = elements.Max(q => q.Len);
            elementsref = elements.FindAll(p => p.Len == Max);
            return Task.FromResult(Max);
        }

        public int LengthOfLongestSubstring(string s)
        {
            HashSet<int> set = new HashSet<int>();
            int left = 0;
            int right = 0;
            int res = 0;
            for (; right < s.Length;)
            {
                if (set.Contains(s[right]))
                {
                    set.Remove(s[left]);
                    left++;
                }
                else
                {
                    set.Add(s[right]);
                    right++;
                }
                res = Math.Max(set.Count, res);
            }
            return res;
        }
    }
}
