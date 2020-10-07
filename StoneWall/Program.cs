using System;
using System.Collections.Generic;

namespace StoneWall
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int solution(int[] H)
        {
            var stack = new Stack<int>();

            int blocks = 0;

            for (int i = 0; i < H.Length; i++)
            {

                while (stack.Count > 0 && stack.Peek() > H[i])
                {
                    stack.Pop();
                }

                if (stack.Count == 0)
                {
                    blocks++;
                    stack.Push(H[i]);
                }

                if (stack.Peek() < H[i])
                {
                    blocks++;
                    stack.Push(H[i]);
                }
            }

            return blocks;
        }
    }
}
