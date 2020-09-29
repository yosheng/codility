using System;

namespace CyclicRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            // [9, 7, 6, 3, 8]
            var result1 = solution(new []{ 3, 8, 9, 7, 6}, 3);
            Console.WriteLine("[{0}]", string.Join(", ", result1));
            
            //  [1, 2, 3, 4]
            var result2 = solution(new []{ 1, 2, 3, 4}, 4);
            Console.WriteLine("[{0}]", string.Join(", ", result2));
        }

        static int[] solution(int[] A, int K)
        {
            if (A.Length == K)
            {
                return A;
            }

            int[] result = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                if (i + K >= result.Length)
                {
                    result[(i + K) - result.Length] = A[i];
                }
                else
                {
                    result[i + K] = A[i];
                }
            }

            return result;
        }
    }
}