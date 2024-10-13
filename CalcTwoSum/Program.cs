using System;
using System.Linq;

namespace EvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4
            Console.WriteLine(solution(new[] { 1, 4 ,4 }));
        }
        
        public static int solution(int[] A)
        {
            int n = A.Length;
            int ans = 1000000;
            for (int i = 0; i < n - 1; i++) {
                for (int j = i + 1; j < n; j++) {
                    ans = Math.Min(ans, A[i] * A[j] > 0 ? A[i] * A[j] : ans);
                }
            }
            return ans;
        }
        
        public static int solutionProblem(int[] A)
        {
            int n = A.Length;
            int ans = 1000000;
            for (int i = 0; i < n - 1; i++) {
                if (A[i] * A[i + 1] != 0) {
                    ans = Math.Min(ans, A[i] * A[i + 1]);
                }
            }
            return ans;
        }
    }
}