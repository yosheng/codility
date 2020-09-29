using System;
using System.Collections.Generic;

namespace OddOccurrencesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7
            Console.WriteLine(solutionBySort(new []{ 9, 3, 9, 3, 9, 7, 9}));
            
            // 7
            Console.WriteLine(solutionByHashSet(new []{ 9, 3, 9, 3, 9, 7, 9}));
        }

        static int solutionBySort(int[] A)
        {
            // 先透过气泡排序由小到大
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[i] > A[j])
                    {
                        var temp = A[j];
                        A[j] = A[i];
                        A[i] = temp;
                    }
                }
            }
            
            Console.WriteLine("[{0}]", string.Join(", ", A));
            
            // 两两比较找出不同
            for (int i = 0; i < A.Length; i += 2)
            {
                if (A[i] != A[i+1])
                {
                    return A[i];
                }
            }

            return 0;
        }

        static int solutionByHashSet(int[] A)
        {
            var hashset = new HashSet<int>();

            foreach (var item in A)
            {
                if (!hashset.Contains(item))
                {
                    hashset.Add(item);
                }
                else
                {
                    hashset.Remove(item);
                }
            }

            foreach (var oddNum in hashset)
            {
                return oddNum;
            }

            return 0;
        }
    }
}