namespace CaclTotalCount
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3
            Console.WriteLine(solution(new[] { 9, 16, 4 }));
            
            // 4
            Console.WriteLine(solution(new[] { 3, 4, 2, 3, 1 }));

            // 1
            Console.WriteLine(solution(new[] { 1000000000, 1000000000 }));
        }
        
        public static int solution(int[] A)
        {
            var total = new HashSet<int>();

            // 用来计算每次忽略的值
            for (int i = 0; i < A.Length; i++)
            {
                // 计算忽略值后的新数组
                int[] newArray = new int[A.Length - 1];
                int newIndex = 0;
                for (int j = 0; j < A.Length; j++) {
                    
                    // 跳过要忽略的元素才放进去
                    if (j != i)
                    {
                        newArray[newIndex++] = A[j];
                    }
                }

                // 计算总和
                var product = 1;
                foreach (var num in newArray) {
                    product *= num; // 将当前元素乘以累积的乘积
                }
                total.Add(product);
            }
            return total.Count;
        }
    }
}