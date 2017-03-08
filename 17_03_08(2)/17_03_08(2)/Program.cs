using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_03_08_2_
{
    class Program
    {
        //ref는 값을 넘기는것이 아니라 주소를 넘기는 것이다.(명시적으로 표시)

        public static void Swap(ref int a,ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;
            Console.WriteLine("{0},{1}", x, y);
            Swap(ref x, ref y);
            Console.WriteLine("{0},{1}", x, y);

        }
    }
}
