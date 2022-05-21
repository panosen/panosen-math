using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Panosen.Math
{
    /// <summary>
    /// 排列
    /// </summary>
    public static class Permutation
    {
        /// <summary>
        /// 组合
        /// </summary>
        public static BigInteger Permutate(int from, int count)
        {
            BigInteger value = BigInteger.One;
            for (int i = 0; i < count; i++)
            {
                value *= (from - i);
            }
            return value;
        }

        /// <summary>
        /// 排列
        /// </summary>
        public static List<List<T>> Permutate<T>(List<T> letters)
        {
            List<List<T>> returnValue = new List<List<T>>();

            DeepFirst(letters.ToArray(), 0, returnValue);

            return returnValue;
        }

        static void DeepFirst<T>(T[] letters, int x, List<List<T>> returnValue)
        {
            if (x == letters.Length - 1)
            {
                // 添加排列方案
                returnValue.Add(letters.ToList());
                return;
            }
            HashSet<T> hashSet = new HashSet<T>();
            for (int index = x; index < letters.Length; index++)
            {
                // 重复，因此剪枝
                if (hashSet.Contains(letters[index]))
                {
                    continue;
                }
                hashSet.Add(letters[index]);

                //// 交换，将 c[i] 固定在第 x 位
                Swap(letters, index, x);

                // 开启固定第 x + 1 位字符
                DeepFirst(letters, x + 1, returnValue);

                // 恢复交换
                Swap(letters, index, x);
            }
        }

        private static void Swap<T>(T[] items, int source, int target)
        {
            T temp = items[source];
            items[source] = items[target];
            items[target] = temp;
        }
    }
}
