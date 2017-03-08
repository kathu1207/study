using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_03_08_4_
{
    class Program
    { 
        public static int sum(int a,int b)
        {
            return a + b;
        }
        
        public static int max(int a, int b)
        {
            int reslut = a > b ? a : b;

            return reslut;
        }

        public static int min(int a, int b)
        {
            int reslut = a < b ?  a : b;
            return reslut;
        }

        public static int main_max(int a, int b, int c)
        {
            if (a > b)
            {
                if (a > c)
                {
                    return a;
                }
                else
                {
                    return c;
                }
            }
            else
            {
                if (b > c)
                {
                    return b;
                }
                else
                {
                    return c;
                }
            }
        }

        public static int main_min(int a, int b, int c)
        {
            if (a < b)
            {
                if (a < c)
                {
                    return a;
                }
                else
                {
                    return c;
                }
            }
            else
            {
                if (b < c)
                {
                    return b;
                }
                else
                {
                    return c;
                }
            }
        }

        public static int power(ref int a,ref int b)
        {
            int sum = a;

            for(int i= 1; i< b; i++)
            {
                sum = sum * a;
            }
            return sum;
        }

        public static int array(int[] arr)
        {
            int reslut = 0;

            for(int i= 0; i< arr.Length; i++)
            {
                reslut = reslut + arr[i];
            }
            return reslut;
        }




            static void Main(string[] args)
        {
          // 메서드 연습

        }
    }
}
