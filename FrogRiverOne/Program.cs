using System;
using System.Collections.Generic;

namespace FrogRiverOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 100%
        /// </summary>
        /// <param name="X"></param>
        /// <param name="A"></param>
        /// <returns></returns>
        static int solution(int X, int[] A)
        {
            var set = new HashSet<int>();
        
            for(int i = 0; i < A.Length; i++){
                set.Add(A[i]);
                if(set.Count == X)
                    return i;
            }
            return -1;
        }
    }
}