using System;
using System.Collections.Generic;

namespace Nesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        static int solution(string S) {
        
            if (S.Length == 0) return 1;
        
            if (S.Length%2 != 0) return 0;
        
            var stack = new Stack<char>();
        
            for(int i=0; i < S.Length; i++){
                if(S[i] == '(') {
                    stack.Push(S[i]);
                } else {
                    if (stack.Count > 0)
                        stack.Pop();
                }
            }        
            return stack.Count == 0 ? 1 : 0;
        }
    }
}