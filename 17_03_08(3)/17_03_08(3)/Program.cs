using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_03_08_3_
{
    class Program
    {
        public static void selectionSort(int[] arr)
        {
            for(int i= 0; i< arr.Length; i++)
            {
                for(int j =i; j<arr.Length; j++)
                {
                    if(arr[i]> arr[j])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] score1 = new int[10] { 80, 74, 81, 90, 34, 84, 76, 95, 45, 66 };
            int[] score2 = new int[10] { 74, 82, 76, 57,51,88,73,98,51,60 };

            selectionSort(score1);
            selectionSort(score2);
            
            for(int i = 0; i < score1.Length; i++)
            {
                Console.Write("{0} ", score1[i]);
            }

            Console.WriteLine(" ");

            for (int i = 0; i < score1.Length; i++)
            {
                Console.Write("{0} ", score2[i]);
            }

        }
    }
}
