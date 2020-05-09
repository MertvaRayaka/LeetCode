/*整数反转
 * 给出一个 32 位的有符号整数，你需要将这个整数中每位上的数字进行反转。

示例 1:
输入: 123
输出: 321

示例 2:
输入: -123
输出: -321

示例 3:
输入: 120
输出: 21
注意:

假设我们的环境只能存储得下 32 位的有符号整数，则其数值范围为 [−231,  231 − 1]。请根据这个假设，如果反转后整数溢出那么就返回 0。
*/

using System;
using System.Linq;

namespace question7
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var r1 = solution.Reverse(123);
            var r2 = solution.Reverse(-123);
            var r3 = solution.Reverse(120);
        }
    }

    public class Solution
    {
        public int Reverse(int x)
        {
            return x < 0 ? (-1) * Convert.ToInt32(String.Join("", x.ToString().Skip(1).Reverse())) : Convert.ToInt32(String.Join("", x.ToString().Reverse()));
        }
    }
}
