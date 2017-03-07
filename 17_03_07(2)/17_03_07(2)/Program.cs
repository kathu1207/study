using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_03_07_2_
{
    //파보나치 수열 
    class Program
    {
        public int Fibonacci(int a)
        {
            if((a ==1)||(a == 2))
            {
                return 1;
            }
            else
            {
                Program sum = new Program();
                return sum.Fibonacci(a - 2) + sum.Fibonacci(a - 1);
            }
        }
           
        static void Main(string[] args)
        {
            for (int num =1;num<=8;num++)
            {
                    Program sum = new Program();
                    int total = sum.Fibonacci(num);
                    Console.WriteLine(total);
            }
        }
    }
}
