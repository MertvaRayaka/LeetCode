/*将一个给定字符串根据给定的行数，以从上往下、从左到右进行 Z 字形排列。

比如输入字符串为 "LEETCODEISHIRING" 行数为 3 时，排列如下：

L   C   I   R
E T O E S I I G
E   D   H   N
之后，你的输出需要从左往右逐行读取，产生出一个新的字符串，比如："LCIRETOESIIGEDHN"。

请你实现这个将字符串进行指定行数变换的函数：

string convert(string s, int numRows);
示例 1:

输入: s = "LEETCODEISHIRING", numRows = 3
输出: "LCIRETOESIIGEDHN"
示例 2:

输入: s = "LEETCODEISHIRING", numRows = 4
输出: "LDREOEIIECIHNTSG"
解释:

L     D     R
E   O E   I I
E C   I H   N
T     S     G

*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace question6
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var result = solution.Convert("LEETCODEISHIRING", 4);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public string Convert(string s, int numRows)
        {
            List<char>[] Arr = new List<char>[numRows];
            int[] indexArr = GenerateIndex(numRows);
            for (int i = 0; i < numRows; i++)
            {
                Arr[i] = new List<char>();
            }
            int index = 0;
            while (index < s.Length)
            {
                Arr[indexArr[index % (2 * (numRows - 1))]].Add(s[index]);
                index++;
            }
            var charList = new List<char>();
            foreach (var item in Arr)
            {
                foreach (var SubItem in item)
                {
                    charList.Add(SubItem);
                }
            }
            var result = String.Join("", charList);
            return result;
        }

        public int[] GenerateIndex(int numRows)
        {
            var IncreseNum = Enumerable.Range(0, numRows - 1);
            var DecreseNum = IncreseNum.Reverse();
            var result = IncreseNum.Concat(new List<int> { numRows - 1 }).Concat(DecreseNum).Take(2 * (numRows - 1)).ToArray();
            return result;
        }
    }
}
