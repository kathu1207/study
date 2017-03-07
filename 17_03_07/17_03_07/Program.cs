using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_03_07
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            반복문의 기초

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            */

            /*
            1에서 100까지의 합 

            int sum = 0;

            for(int i = 1; i <=100; i++)
            {
                sum = i + sum;
            }
            Console.WriteLine(sum);
            */
            /*
             * 짝수의 합 
            int sum = 0;
            for(int i = 1;i<=100;i++)
            {
                if(i%2 == 0)
                {
                    sum = i + sum;
                }
                    
            }
            Console.WriteLine(sum);
            */
            for(int i = 1; i<=5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                for (int z = 5; z > i; z--)
                {
                    Console.Write(" ");
                }
                for (int z = 5; z >= i; z--)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }

            for (int i = 1; i <= 5; i++)
            {
                for (int z = 5; z >= i; z--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int z = 5; z >=i; z--)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }

        }
    }
}
