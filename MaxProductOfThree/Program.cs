using System;

namespace MaxProductOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        /// <summary>
        /// 55%
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        static int solution(int[] A) {
            // 先由小排到大
            for (int i = 0; i < A.Length; i++) {
                for (int j = i+1; j < A.Length; j++){
                    if (A[i] > A[j]) {
                        var temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                    }
                }
            }
        
            int calc = 0;

            // 暴力算法
            for (int i = 0; i < A.Length-2; i++){
                if (i == 0) {
                    calc = A[i] * A[i+1] * A[i+2];
                } else if (A[i] * A[i+1] * A[i+2] > calc){
                    calc = A[i] * A[i+1] * A[i+2];
                }
            }
        
            // 考虑 [-5, 5, -5, 4] 应得 125 而不是 100
            if (A[0] * A[1] * A[A.Length-1] > calc) return A[0] * A[1] * A[A.Length-1];
        
            return calc;
        }
    }
}