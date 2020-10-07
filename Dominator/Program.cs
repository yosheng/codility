using System;
using System.Collections.Generic;

namespace Dominator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int solution(int[] A)
        {

            var dic = new Dictionary<int, int>();

            // 计算数列中每个数字的出现次数
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

            // 找出出现最多的作为统治数
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

            // 判断是否过半
            if (!(maxCount > (A.Length) / 2)) return -1;

            // 回传符合条件的索引
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == maxNum)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
