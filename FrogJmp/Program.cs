using System;

namespace FrogJmp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(10,85,30));
            
            Console.WriteLine(solutionByMath(10,85,30));
        }

        /// <summary>
        /// 44%
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="D"></param>
        /// <returns></returns>
        static int solution(int X, int Y, int D)
        {
            int count = 0;

            while (X + D * count <　Y)
            {
                count++;
            }

            return count;
        }
        
        /// <summary>
        /// 100%
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="D"></param>
        /// <returns></returns>
        static int solutionByMath(int X, int Y, int D)
        {
            int count = 0;

            count = (int)Math.Ceiling((double) (Y - X) / D);

            return count;
        }
    }
}