using System;

namespace BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {
            // print 5
            Console.WriteLine(solution(1041));
            
            // print 0
            Console.WriteLine(solution(32));
        }
        
        public static int solution(int N)
        {
            int count = 0;
            int max = 0;
            bool find = false;

            if (N <= 0)
            {
                return max;
            }

            while (N > 0)
            {
                // 判断最右边的二进位是否为1
                if ((N & 1) == 1)
                {
                    find = true;
                    count = 0;
                }
                else
                {
                    if (find)
                    {
                        count++;
                    }
                }
                
                // 判断当前的 count 是否大于之前的 max
                if (count > max)
                {
                    max = count;
                }

                N = N >> 1;
            }

            return max;
        }
    }
}