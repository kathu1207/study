using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_03_08_5_
{
    class Program
    {
        public static int max(int[] arr)
        {   // 가장큰 값을 반환
            int reslut = 0;
            
            for(int i= 0; i< arr.Length; i++)
            {
                if (arr[i] > reslut)
                {
                    reslut = arr[i];
                }
            }
            return reslut;
        }
        public static int min(int[] arr)
        {   // 가장 작은 값을 반환 
            int reslut = arr[0];
      
            for(int i = 1; i< arr.Length; i++)
            {
                if (arr[i] < reslut)
                    reslut = arr[i];
            }
            return reslut;
        }
        public static int average(int[] arr)
        {   //평균을 구함
            int reslut = 0;

            for(int i= 0; i<arr.Length; i++)
            {
                reslut = reslut + arr[i];
            }

            reslut = reslut / arr.Length;
            return reslut;
        }
        public static string lsln(int[] arr,int a)
        {   //배열과 한 개의 정수를 받아서 배열 안에 그 정수가 있는 지 구분
            string reslut = " ";
            for(int i= 0; i<arr.Length; i++)
            {
                if (a == arr[i])
                {
                    reslut = "참";
                    break;
                }
                else
                    reslut = "거짓";
            }
            return reslut;
        }
        public static int frequency(int[] arr, int a)
        {   //배열과 한 개의 정수를 받아서 배열안에 정수가 몇개 있는지 찾는 함수 
            int reslut = 0;
            for(int i =0; i<arr.Length; i++)
            {
                if (a == arr[i])
                {
                    reslut = reslut + 1;
                }

            }
            return reslut;
        }

        public static int maxfrequency(int[] arr) 
        {
            // 정수 배열을 입력 받아서 배열중에 가장 많이 나오는 수를 돌려주는 메소드

            int[] save = new int[arr.Length];
            int dump = 0;
            int input = 0;

            for (int i = 0; i < arr.Length; i++) // 배열중에 가장 많이 나오는 수를 찾음 
            { 
                int reslut = 0;
                int select = arr[i];
                
                for (int j = 0; j < arr.Length; j++)
                {
                    if (select == arr[j])
                    {
                        reslut = reslut + 1;
                    }

                }
                save[i] = reslut; //배열의 중복 수를 저장함
            }

            for (int i = 0; i < arr.Length; i++) 
            {
                if (save[i] > dump) // 중복 된 수 중에서 가장 큰 값을 찾음 
                {
                    dump = save[i];
                }   
            }

            for(int i = 0; i<arr.Length; i++)
            {
                if(save[i] == dump) // 가장 많이 나온 중복 수의 위치를 찾음 
                {
                    input = arr[i];
                }
            }

            return input; 
        }

        public static void swap(ref int a, ref int b)
        {   //두 개의 정수를 받아서 a는 b로, b는 a로 바꾸는 함수
            int temp = a;
            a = b;
            b = a;
        }

        static void Main(string[] args)
        {
            int[] score = new int[10] { 74, 42, 68, 31, 85, 91, 26, 82, 55, 90 };

            int[] count = new int[10];

            Console.WriteLine("중단 할려면 exit를 치시오.");

            for (int i = 0; i < count.Length; i++)
            {
                Console.WriteLine("숫자를 입력하세요: ");
                string str = Console.ReadLine();

                if (str == "exit")
                    break;

                count[i] = Int32.Parse(str);

            }
            int reslut = maxfrequency(count);
            Console.WriteLine("가장 큰 수는 {0}",reslut);

        }
    }
}
