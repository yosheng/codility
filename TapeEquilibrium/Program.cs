using System;
using System.Collections.Generic;

namespace TapeEquilibrium
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            Console.WriteLine(solution(new int[] {3, 1, 2, 4, 3}));
            
            // 2000
            Console.WriteLine(solution(new int[] {-1000, 1000}));
        }

        /// <summary>
        /// 53%
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        static int solution(int[] A)
        {
            if (A.Length == 0)
            {
                return 0;
            }

            if (A.Length == 1)
            {
                return A[0];
            }

            var sortedSet = new SortedSet<int>();

            for (int i = 1; i < A.Length; i++)
            {
                // 计算左边
                var totalLeft = 0;
                for (int leftPoint = i - 1; leftPoint >= 0; leftPoint--)
                {
                    totalLeft += A[leftPoint];
                }

                // 计算右边
                var totalRight = 0;
                for (int rightPoint = i; rightPoint < A.Length; rightPoint++)
                {
                    totalRight += A[rightPoint];
                }

                var curDiff = Math.Abs(totalLeft - totalRight);
                sortedSet.Add(curDiff);
            }

            return sortedSet.Min;
        }
    }
}