namespace CalcStr
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3
            Console.WriteLine(solution("7891"));

            // 4
            Console.WriteLine(solution("11"));
            
            Console.WriteLine(solution("98"));

            // 898
            Console.WriteLine(solution("899"));
            
            // 9
            Console.WriteLine(solution("10"));
            
            // 89
            Console.WriteLine(solution("98"));
            
        }
        
        /// <summary>
        /// 找出一个比输入数字小的最大数
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static string solution(string S)
        {
            // 如果输入是"0"，直接返回"0"
            if (S == "0")
            {
                return "0";
            }
    
            // 如果输入长度为1，返回比它小1的数
            if (S.Length <= 1)
            {
                return (int.Parse(S) - 1).ToString();
            }
    
            // 获取第一个数字
            var firstNum = S.Substring(0, 1);
            if (firstNum == "0")
            {
                // 如果第一个数字是0，去掉0后继续处理剩余部分
                return solution(S.Substring(1));
            }
            else
            {
                // 方案1：保持第一个数字不变，处理剩余部分
                var f1 = firstNum + solution(S.Substring(1));
        
                // 方案2：第一个数字减1，后面全部变成9
                var f2 = (int.Parse(firstNum) - 1).ToString();
                f2 = f2 == "0" ? "" : f2;  // 如果第一个数字变成0，就去掉它
                for (int i = 0; i < S.Length - 1; i++)
                {
                    f2 += "9";
                }
        
                // 计算两个方案的各位数字之和
                int fi1 = 0;
                for (int i = 0; i < f1.Length; i++)
                {
                    fi1 += int.Parse(f1.Substring(i, 1));
                }
                int fi2 = 0;
                for (int i = 0; i < f2.Length; i++)
                {
                    fi2 += int.Parse(f2.Substring(i, 1));
                }
        
                // 返回各位数字之和较大的方案
                return fi1 >= fi2 ? f1 : f2;
            }
        }
    }
}