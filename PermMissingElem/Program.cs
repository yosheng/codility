using System;
using System.Collections.Generic;

namespace PermMissingElem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(new int[] { }));
            Console.WriteLine(solutionBySum(new int[] { }));
            Console.WriteLine(solutionByMath(new int[] { }));

            Console.WriteLine(solution(new int[] {2, 3, 1, 5}));
            Console.WriteLine(solutionBySum(new int[] { 2, 3, 1, 5 }));
            Console.WriteLine(solutionByMath(new int[] { 2, 3, 1, 5 }));
        }

        /// <summary>
        /// 90%
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        static int solution(int[] A)
        {
            int missEle = 1;

            var sortedSet = new SortedSet<int>();

            // 数字全部加1
            foreach (var item in A)
            {
                sortedSet.Add(item + 1);
            }

            for (int i = 0; i < A.Length; i++)
            {
                // 判断是否连续都能扣除
                if (sortedSet.Contains(A[i]))
                {
                    sortedSet.Remove(A[i]);
                }
            }

            // 判断头尾断号
            if (sortedSet.Count == 1)
            {
                if (sortedSet.Max == A.Length + 1)
                {
                    return sortedSet.Max;
                }
            }

            // 判断是否中间断号
            if (sortedSet.Count == 2)
            {
                return sortedSet.Min;
            }

            return missEle;
        }

        /// <summary>
        /// 80%
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        static int solutionBySum(int[] A)
        {
            int n = A.Length + 1;
            
            // 计算总和
            // var expectSum = (double)((n + 1) * n) / 2;
            var expectSum = Math.Pow(n, 2) / 2 + (double)n / 2;

            int sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i];
            }

            return (int)expectSum - sum;
        }

        /// <summary>
        /// 100%
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        static int solutionByMath(int[] A)
        {
            int
                l = A.Length + 1,
                expectedSum = (int) Math.Ceiling(l / 2.0) * (l + (l + 1) % 2),
                sum = 0;
            for (int i = -1; ++i < A.Length;)
                sum += A[i];
            return expectedSum - sum;
        }
    }
}