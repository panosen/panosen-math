using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.Math
{
    /// <summary>
    /// 组合
    /// </summary>
    public static class Combination
    {
        /// <summary>
        /// 组合
        /// </summary>
        public static BigInteger CombinateCount(int from, int count)
        {
            BigInteger value = BigInteger.One;
            for (int i = 0; i < count; i++)
            {
                value *= (from - i);
            }
            for (int i = 0; i < count; i++)
            {
                value /= (i + 1);
            }
            return value;
        }

        /// <summary>
        /// 组合
        /// </summary>
        public static List<List<T>> Combinate<T>(List<T> items, int count)
        {
            List<List<T>> returnValue = new List<List<T>>();

            Backtrack(items, count, 1, new List<int>(), x =>
            {
                returnValue.Add(x);
            });

            return returnValue;
        }

        /// <summary>
        /// 组合
        /// </summary>
        public static void CombinateAction<T>(List<T> items, int count, Action<List<T>> action)
        {
            Backtrack(items, count, 1, new List<int>(), action);
        }

        private static void Backtrack<T>(List<T> items, int count, int start, List<int> tempList, Action<List<T>> action)
        {
            //终止条件，找到一对组合
            if (count == 0)
            {
                action(Compute(items, tempList));
                return;
            }

            if (start <= items.Count - count)
            {
                //不选当前值，k不变
                Backtrack(items, count, start + 1, tempList, action);
            }

            //选择当前值，k要减1
            tempList.Add(start);

            Backtrack(items, count - 1, start + 1, tempList, action);

            //因为是递归调用，跳到下一个分支的时候，要把这个分支选的值给移除
            tempList.RemoveAt(tempList.Count - 1);
        }

        private static List<T> Compute<T>(List<T> items, List<int> temp)
        {
            List<T> returnValue = new List<T>(temp.Count);
            for (int i = 0; i < temp.Count; i++)
            {
                returnValue.Add(items[temp[i] - 1]);
            }
            return returnValue;
        }
    }
}
