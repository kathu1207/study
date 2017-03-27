using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_03_27
{
    class Program
    {
        class quicksort
        {
            int start;
            int end;
            int midindex;
            int[] arry = { 1, 3, 4, 9, 11, 14, 19, 20, 21, 25 };

            public quicksort()
            {
                arry = new int[10];
                start = 0;
                end = arry.Length-1;
                midindex = (start + end)/2;
            }

            public void distribute(int val)
            {
                Console.WriteLine("{0} 처음", midindex);

                if (arry[midindex] == val)
                {
                    Console.WriteLine(val);
                }
                else if (start == end)
                {
                    if (arry[start] == val)
                    {
                        Console.WriteLine(val);
                    }
                    else
                    {
                        Console.WriteLine(start);
                        Console.WriteLine("없다");
                    }
                }
                else if(val > arry[midindex])
                {
                    

                    midindex = (start + end) / 2;
                    Console.WriteLine("{0} 크다",midindex);
                    distribute(val);
                   
                }
                else if(val < arry[midindex])
                {
                    Console.WriteLine("{0} 작다", midindex);
                    distribute(val);
                }

            }
        }
        static void Main(string[] args)
        {
            quicksort quick = new quicksort();

            quick.distribute(20);
        }
    }
}
