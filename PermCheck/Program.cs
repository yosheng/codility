using System;
using System.Collections.Generic;

namespace PermCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        static int solution(int[] A) {
            var set = new HashSet<int>();
            for (int i = 0; i < A.Length; i ++) {
                if (A[i] > A.Length) return 0;
                set.Add(A[i]);
            }
            return set.Count == A.Length ? 1 : 0;
        }
    }
}