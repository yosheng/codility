using System;
using System.Linq;

namespace EvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // 18
            Console.WriteLine(CalcMaxEvenSum(new[] { 4, 9, 8, 2, 6 }, 3));

            // -1
            Console.WriteLine(CalcMaxEvenSum(new[] { 7, 7, 7, 7, 7 }, 1));

            // 20
            Console.WriteLine(CalcMaxEvenSum(new[] { 5, 6, 3, 4, 2 }, 5));

            // 12
            Console.WriteLine(CalcMaxEvenSum(new[] { 2, 3, 3, 5, 5 }, 3));
        }

        static int CalcMaxEvenSum(int[] array, int k)
        {
            if (array.Length < k)
            {
                return -1;
            }

            Array.Sort(array);

            return GetTotalSum(array, k, true);
        }

        static int GetTotalSum(int[] array, int k, bool isEven)
        {
            // 判断总和是基数还是偶数决定最后一个取值
            if (k == 1)
            {
                for (var i = array.Length - 1; i >= 0; i--)
                {
                    var value = array[i];
                    if (isEven == true && value % 2 == 0)
                    {
                        return value;
                    }

                    if (isEven == false && value % 2 == 1)
                    {
                        return value;
                    }
                }

                // 如果都找不到就返回-1
                return -1;
            }

            // 先按照最大数字开始取值计算
            var sum = array[^1];
            // 取出的就移出
            array = array.SkipLast(1).ToArray();
            
            var nextVal = GetTotalSum(array, k - 1, sum % 2 == 0 == isEven);
            if (nextVal < 0)
            {
                return GetTotalSum(array, k, isEven);
            }
            
            return sum + nextVal;
        }

        static int EvenSum(int[] array, int k)
        {
            if (array.Length < k)
            {
                return -1;
            }

            Array.Sort(array);

            return GetMaxEvenSum(array, k, true);
            // return subEvenSum(array, k, true);
        }

        static int GetMaxEvenSum(int[] array, int k, bool isEven)
        {
            if (k > array.Length)
            {
                return -1;
            }

            if (k == 1)
            {
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (isEven)
                    {
                        if (array[i] % 2 == 0)
                        {
                            return array[i];
                        }
                    }
                    else
                    {
                        if (array[i] % 2 != 0)
                        {
                            return array[i];
                        }
                    }
                }

                return -1;
            }

            var curMax = array.Last();
            var newArray = new int[array.Length - 1];
            Array.Copy(array, newArray, array.Length - 1);

            var nextValue = GetMaxEvenSum(newArray, k - 1, curMax % 2 == 0 == isEven);

            if (nextValue > 0)
            {
                return curMax + nextValue;
            }
            else
            {
                return GetMaxEvenSum(newArray, k, isEven);
            }
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

                    if (!isGetEven && array[i] % 2 == 1)
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