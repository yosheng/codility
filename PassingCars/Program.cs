using System;

namespace PassingCars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        /// <summary>
        /// 90%
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        static int solution(int[] A) {
            int count = 0;
            int totalCount = 0;
        
            for(int i = 0; i < A.Length; i++) {
                // 朝向东边行走计算配对
                if (A[i] == 0){
                    count++;
                }
                else {
                    totalCount = totalCount + count;
                }
            }
        
            if (totalCount > 1000000000) return -1;
        
            return totalCount;
        }
    }
}