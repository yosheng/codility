using System;

namespace EvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // 18
            Console.WriteLine(EvenSum(new []{4,9,8,2,6}, 3));
            
            // -1
            Console.WriteLine(EvenSum(new []{7,7,7,7,7}, 1));
            
            // 20
            Console.WriteLine(EvenSum(new []{5,6,3,4,2}, 5));
            
            // 12
            Console.WriteLine(EvenSum(new []{2,3,3,5,5}, 3));
        }

        static int EvenSum(int[] array, int k)
        {
            if (array.Length < k)
            {
                return -1;
            }
            
            Array.Sort(array);
            return SubEvenSum(array, k, true);
        }

        static int SubEvenSum(int[] array, int k, bool even)
        {
            if (array.Length < k)
            {
                return -1;
            }

            if (k == 1)
            {
                // 当 k==1 时，最大和就是最大的奇数或偶数
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (even && array[i] % 2 == 0)
                    {
                        return array[i];
                    }
                    else if (!even && array[i] % 2 == 1)
                    {
                        return array[i];
                    }
                }

                return -1;
            }
            /*  因为最后一个元素是假定被用上了的元素
             *  1，2，3，4，5，假定5能被用上，那么再计算1，2，3，4的最大偶数或奇数和 
             */
            var subArray = new int[array.Length - 1];
            Array.Copy(array, subArray, array.Length - 1 );
            int prevEvenSum = SubEvenSum(subArray, k - 1, (array[array.Length - 1] % 2 == 0) == even);

            if (prevEvenSum < 0)
            {
                return SubEvenSum(subArray, k, even);
            }
            else
            {
                return array[array.Length - 1] + prevEvenSum;
            }
        }
    }
}