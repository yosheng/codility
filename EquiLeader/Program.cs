using System;
using System.Collections.Generic;

namespace EquiLeader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int solution(int[] A)
        {

            if (A.Length == 0)
                return 0;

            var dic = new Dictionary<int, int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (!dic.ContainsKey(A[i]))
                {
                    dic.Add(A[i], 1);
                }
                else
                {
                    var count = dic[A[i]];
                    dic[A[i]] = count + 1;
                }
            }

            // 找出出现最多的数字简称领导数
            int maxNum = A[0];
            int maxCount = 1;
            foreach (var item in dic)
            {
                if (item.Value > maxCount)
                {
                    maxNum = item.Key;
                    maxCount = item.Value;
                }
            }

            // 判断领导数字是否过半
            int leaderNum = 0;
            int leaderCount = 0;
            if (maxCount > (0.5) * (A.Length))
            {
                leaderNum = maxNum;
                leaderCount = maxCount;
            }
            else
            {
                return 0;
            }

            // 分割点个数
            var equiLeaderCount = 0;

            // 左边出现领导次数
            var leftLeaderCount = 0;

            for (int i = 0; i < A.Length; i++)
            {

                // 左边找到领导
                if (A[i] == leaderNum)
                {
                    leftLeaderCount++;
                }

                if (leftLeaderCount > (0.5) * (i + 1))
                {
                    // 确认右边
                    var rightLeaderCount = leaderCount - leftLeaderCount;

                    if (rightLeaderCount > (0.5) * (A.Length - i - 1))
                    {
                        equiLeaderCount++;
                    }
                }
            }

            return equiLeaderCount;
        }

        static int solutionNoneCheck(int[] A)
        {
            var dic = new Dictionary<int, int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (!dic.ContainsKey(A[i]))
                {
                    dic.Add(A[i], 1);
                }
                else
                {
                    var count = dic[A[i]];
                    dic[A[i]] = count + 1;
                }
            }

            // 找出出现最多的数字简称领导数
            int maxNum = 0;
            int maxCount = 0;
            foreach (var item in dic)
            {
                if (item.Value > maxCount)
                {
                    maxNum = item.Key;
                    maxCount = item.Value;
                }
            }

            // 分割点个数
            var equiLeaderCount = 0;

            // 左边出现领导次数
            var leftLeaderCount = 0;

            for (int i = 0; i < A.Length; i++)
            {

                // 左边找到领导
                if (A[i] == maxNum)
                {
                    leftLeaderCount++;
                }

                if (leftLeaderCount > (0.5) * (i + 1))
                {
                    // 确认右边
                    var rightLeaderCount = maxCount - leftLeaderCount;

                    if (rightLeaderCount > (0.5) * (A.Length - i - 1))
                    {
                        equiLeaderCount++;
                    }
                }
            }

            return equiLeaderCount;
        }
    }
}
