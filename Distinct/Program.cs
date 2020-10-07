using System;
using System.Collections.Generic;

namespace Distinct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        static int solution(int[] A) {
            var set = new HashSet<int>();
        
            for (int i = 0; i < A.Length; i++){
                set.Add(A[i]);
            }
        
            return set.Count;
        }
    }
}