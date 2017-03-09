using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_03_09
{
    class Program
    {
        public static void swap(int[] arr)
        {
            for(int i = arr.Length -1; i >= 0; i--)
            {
                for(int j = i-1; j >= 0; j--)
                {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    
                }
            }
        }
        static void Main(string[] args)
        {
            //reverse
            int[] score = new int[20] { 80, 74, 81, 90, 34, 84, 76, 95, 45, 66, 74, 82, 76, 57, 51, 88, 73, 98, 51, 60 };

            swap(score);

            for(int i = 0; i< score.Length; i++)
            {
                Console.WriteLine(score[i]);
            }         
        }
    }
}
