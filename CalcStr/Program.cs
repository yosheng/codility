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
        
        public static string solution(string S)
        {
            if (S == "0")
            {
                return "0";
            }
            
            if (S.Length <= 1)
            {
                return (int.Parse(S) - 1).ToString();
            }
            
            var firstNum = S.Substring(0, 1);
            if (firstNum == "0")
            {
                return solution(S.Substring(1));
            }
            else
            {
                var f1 = firstNum + solution(S.Substring(1));
                var f2 = (int.Parse(firstNum) - 1).ToString();
                f2 = f2 == "0" ? "" : f2;
                for (int i = 0; i < S.Length - 1; i++)
                {
                    f2 += "9";
                }
                
                // 比较大小
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
                return fi1 >= fi2 ? f1 : f2;
            }
        }
    }
}