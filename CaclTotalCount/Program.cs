using System;
using System.Linq;

namespace EvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3
            Console.WriteLine(solution(new[] { 9, 16, 4 }));

            // 4
            Console.WriteLine(solution(new[] { 3, 4, 2, 3, 1 }));

            // 1
            Console.WriteLine(solution(new[] { 1000000000, 1000000000 }));
        }
        
        public static int solution(int[] A)
        {
            var total = new HashSet<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (i+1 == A.Length)
                {
                    // 末位跟头部计算
                    total.Add(A[0] * A[i]);
                    break;
                }
                var calc = A[i] * A[i + 1];
                total.Add(calc);
            }
            return total.Count;
        }
    }
}