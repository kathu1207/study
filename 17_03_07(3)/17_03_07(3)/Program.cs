using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_03_07_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 배열을 이용해서 홀수 50개를 넣는 코드
            int[] num = new int[50];

            for(int i =0; i<50; i++)
            {
                num[i] = i * 2 + 1;
                Console.WriteLine(num[i]);
            }
            */

            int[] score = new int[20]{
                80,74,81,90,34,84,76,95,45,66,74,82,76,57,51,88,73,98,51,60};

            
            // 최대값, 최소값 구하기
            int max = score[0];
            int min = score[0];

            for(int i= 0;i<20;i++)
            {
                if (score[i] > max)
                {
                    max = score[i];
                }
                else if(score[i]<min)
                {
                    min = score[i];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            
           
        }
    }
}
