using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_03_09_4_
{
    
    //히노이의 탑
    class Program
    {

        public static void hanoi(char a, char b, char c,int n)
        {
           if(1 == n)
            {
                Console.WriteLine("{0} - {1} -> {2}", a, n, c);
            }
            else
            {
                hanoi(a, c, b, n - 1);
                Console.WriteLine("{0} - {1} -> {2}", a, n, c);
                hanoi(b, a, c, n - 1);
            }
        }

        static void Main(string[] args)
        {
            hanoi('A', 'B', 'C', 4);
        }
    }
}
