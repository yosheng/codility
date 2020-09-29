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

        static int solution(int X, int Y, int D)
        {
            int count = 0;

            while (X + D * count <　Y)
            {
                count++;
            }

            return count;
        }
        
        static int solutionByMath(int X, int Y, int D)
        {
            int count = 0;

            count = (int)Math.Ceiling((double) (Y - X) / D);

            return count;
        }
    }
}