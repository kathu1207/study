using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_03_08_6_
{
    // 분할 하고 분할해서 마지막에 개별로 만든 다음에 큰수 끼리 비교..(병합정렬)
    class Program
    {
        public static void merge(int[] arr,int left,int right,int end,int[] arr2)
        {
            int i = left, j = right, k = left;

            while(j < end && i < right)
            {
                if (arr[i] <= arr[j])
                    arr2[k++] = arr[i++];
                else
                    arr2[k++] = arr[j++];
            }
            if(j >= end)
            {
                while(i < right)
                    arr2[k++] = arr[i++];
            }
            else if (i >= right)
            {
                while(j < end)
                    arr2[k++] = arr[j++];
            }
        }
        public static void division(int[] arr, int[] arr2)// 반을 쪼개는 작업
        {
            for(int i= 1; i<arr.Length; i= 2*i)
            {
                for(int j = 0; j <arr.Length-i; j += 2*i )
                {
                    int end = j + 2 * i;

                    if (end > arr.Length)
                        end = arr.Length;
                    merge(arr, j, j + i, end, arr2);
                }
                for (int k = 0; k < arr.Length; ++k)
                    arr[k] = arr2[k];
            }
        }
        static void Main(string[] args)
        {
            int[] score = new int[20]{
                80,74,81,90,34,84,76,95,45,66,74,82,76,57,51,88,73,98,51,60};

            int[] score_2 = new int[20];

            division(score, score_2);
                
                for (int i = 1; i < score.Length; i++)
                            Console.WriteLine(score[i]);



        }
    }
}
