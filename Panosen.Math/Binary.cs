using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.Math
{
    /// <summary>
    /// 任意进制转换
    /// </summary>
    public static class Binary
    {
        /// <summary>
        /// 十进制转换为任意进制
        /// </summary>
        public static List<int> ToBase(int num, int @base)
        {
            if (num == 0)
            {
                return new List<int> { 0 };
            }

            List<int> items = new List<int>();
            while (num > 0)
            {
                items.Add(num % @base);
                num /= @base;
            }

            items.Reverse();

            return items;
        }

        /// <summary>
        /// 任意进制转换为十进制
        /// </summary>
        public static int FromBase(List<int> nums, int @base)
        {
            if (nums == null || nums.Count == 0)
            {
                return 0;
            }

            int value = 0;
            for (int index = 0; index < nums.Count; index++)
            {
                value += nums[index];
                if (index < nums.Count - 1)
                {
                    value *= @base;
                }
            }

            return value;
        }
    }
}
