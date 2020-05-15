//括号生成

/*
 * 数字 n 代表生成括号的对数，请你设计一个函数，用于能够生成所有可能的并且 有效的 括号组合。
示例：

输入：n = 3
输出：[
       "((()))",
       "(()())",
       "(())()",
       "()(())",
       "()()()"
     ]
 * */

using System.Collections.Generic;

namespace question22
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var r = solution.GenerateParenthesis(3);
        }
    }

    public class Solution
    {
        List<string> res = new List<string>();
        public List<string> GenerateParenthesis(int n)
        {
            dfs(n, n, "");
            return res;
        }

        private void dfs(int left, int right, string curStr)
        {
            if (left == 0 && right == 0)
            { // 左右括号都不剩余了，递归终止
                res.Add(curStr);
                return;
            }

            if (left > 0)
            { // 如果左括号还剩余的话，可以拼接左括号
                dfs(left - 1, right, curStr + "(");
            }
            if (right > left)
            { // 如果右括号剩余多于左括号剩余的话，可以拼接右括号
                dfs(left, right - 1, curStr + ")");
            }
        }
    }
}
