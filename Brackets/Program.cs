using System;

namespace Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        static int solution(string S) {
            if (S.Length%2 != 0){
                return 0;
            }
        
            var stack = new Stack<char>();
        
            for(int i=0; i < S.Length; i++){
                if (S[i] == '(' || S[i] == '{' || S[i] == '['){
                    stack.Push(S[i]);
                } else {
                    if (stack.Count == 0) {
                        return 0;
                    }
                
                    var leftSign = stack.Pop();
                
                    if(leftSign == '(' && S[i] != ')') return 0;
                
                    if(leftSign == '{' && S[i] != '}') return 0;
                
                    if(leftSign == '[' && S[i] != ']') return 0;
                }
            }
        
            return stack.Count == 0 ? 1 : 0;
        }
    }
}