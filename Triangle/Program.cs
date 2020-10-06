using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        /// <summary>
        /// 93%
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        static int solution(int[] A) {
            Array.Sort(A);
        
            for(int i=0; i<A.Length-2; i++){
                if (A[i]+A[i+1] > A[i+2]) return 1;
            }
        
            return 0;
        }
    }
}