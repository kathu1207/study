using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_03_09_2_
{
    class Program
    {
        // 재귀 호출을 이용한 피보나치 수열
        public static int fibo(int num)
        {
            if (num <= 2)
                return 1;

            return fibo(num - 2) + fibo(num - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("종료할려면 exit");
            while (true)
            {
                string str = Console.ReadLine();
                int num = Int32.Parse(str);
                Console.WriteLine("해당 수열은 {0}",fibo(num));

                if (str == "exit")
                    break;

            }
            
        }
    }
}
