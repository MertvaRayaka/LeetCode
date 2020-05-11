/*
 * 给定一个仅包含数字 2-9 的字符串，返回所有它能表示的字母组合。

给出数字到字母的映射如下（与电话按键相同）。注意 1 不对应任何字母。

示例:
输入："23"
输出：["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"].

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace question17
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var r = solution.LetterCombinations("23");
        }
    }

    public class Solution
    {
        public List<string> LetterCombinations(string digits)
        {
            var dic = CreateMapping();
            var res = new List<string>();
            
            var valueList =new  List<string>();
            int sum = 1;
            for (int i = 0; i < digits.Length; i++)
            {
                var value = string.Empty;
                dic.TryGetValue(digits[i].ToString(),out value);
                sum *= value.Length;
                valueList.Add(value);
            }
            //递归？树的遍历？
            return null;
        }


        public Dictionary<string, string> CreateMapping()
        {
            var Letters = Encoding.ASCII.GetString(Enumerable.Range(97, 26).Select(p => Convert.ToByte(p)).ToArray());
            Dictionary<string, string> dic = new Dictionary<string, string>();
            for (int i = 2; i < 10; i++)
            {
                dic.Add(i.ToString(), Letters.Substring(0, GetValue(i)));
                Letters = Letters.Remove(0, GetValue(i));
            }

            return dic;

            int GetValue(int i)
            {
                if (i == 7 || i == 9) return 4;
                else return 3;
            }
        }

    }
}
