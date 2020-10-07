using System;

namespace Fish
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
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        static int solution(int[] A, int[] B) {
            // 假设全部都存活
            int aliveCount = A.Length;
        
            var stack = new Stack<int>();
            for (int i=0; i<A.Length; i++){
                if(B[i] == 1) {
                    stack.Push(A[i]);
                } else {
                    while (stack.Count > 0) {
                        if (stack.Peek() > A[i]) {
                            aliveCount--;
                            break;
                        } else {
                            aliveCount--;
                            stack.Pop();
                        }
                    }
                }
            }
        
            return aliveCount;
        }
        
        /// <summary>
        /// 100%
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        static int solutionByAdd(int[] A, int[] B) {
            int aliveCount = 0;
        
            var stack = new Stack<int>();
            for (int i=0; i<A.Length; i++){
                if(B[i] == 1) {
                    stack.Push(A[i]);
                } else {
                    aliveCount++;
                    while (stack.Count > 0) {
                        var badFish = stack.Pop();
                    
                        if (badFish > A[i]) {
                            // 坏鱼存活
                            stack.Push(badFish);
                            aliveCount--;
                            break;
                        }
                    }
                }
            }
        
            return aliveCount + stack.Count;
        }
    }
}