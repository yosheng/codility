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

            return subEvenSum(array, k, true);
        }
        
        static int subEvenSum(int[] array, int k, bool isGetEven)
        {
            if (array.Length < k)
            {
                return -1;
            }

            if (k == 1)
            {
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    // 如果前面是偶数这里要取偶数
                    if (isGetEven && array[i] % 2 == 0)
                    {
                        return array[i];
                    }

                    if (!isGetEven && array[i] %2 == 1)
                    {
                        return array[i];
                    }
                }

                return -1;
            }

            // 最大数字
            var cur = array[array.Length - 1];
            
            var subArray = new int[array.Length - 1];
            Array.Copy(array, subArray, array.Length - 1);

            var nextValue = subEvenSum(subArray, k - 1, cur % 2 == 0 == isGetEven);
            if (nextValue > 0)
            {
                return cur + nextValue;
            }
            else
            {
                return subEvenSum(subArray, k, isGetEven);
            }
        }

        static int subTotalSum(int[] array, int k)
        {
            var cur = 0;
            
            // 获取最大
            cur = array[array.Length - 1];
            
            if (k == 1)
            {
                return cur;
            }
            
            // 当前加上下一个获取
            var subArray = new int[array.Length - 1];
            Array.Copy(array, subArray, array.Length - 1);

            return cur + subTotalSum(subArray, k - 1);
        }
    }
}