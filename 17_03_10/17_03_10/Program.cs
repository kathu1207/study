using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_03_10
{
    class Program
    {
        public static double sale(double a)
        {
            // 20% 할인해주는 메서드
            return a * 0.8;
        }
        public static int second(int a,int b ,int c)
        {
            // 두번째 큰 정수를 돌려주는 메서드
            int result = 0;

            if ((a >= b)&&(a >= c))
                result = b > c ? b : c;
            
            else if ((b >= a) && (b >= c))
                result = a > c ? a : c;
    
            else
                result = b > a ? b : a;


            return result;
        }
        public static int sum(int a)
        {
            // 10,000 보다 작은 자연수 중에 3또는 5의 배수를 모두 더한 값 (수정 요망)
            int result = 0;
            int sum = 0; ;
            int i = 1;

            while (true)
            {
                if (result < 10000)
                {
                    result = a * i;
                    i++;
                    sum = sum + result;
                }
                else
                    return sum;
            }
        }
        public static double avgemin(int[] arr)
        {
            // 배열에 있는 정수들 중에 평균보다 작은 값들의 비율
            double total = 0;
            double result = 0;
            int cout = 0 ;

            for(int i = 0; i < arr.Length; i++)
            {
                total = total + arr[i];
            }
            total = total / arr.Length;

            for (int i = 0; i < arr.Length; i++)
            {
                if(total >= arr[i])
                {
                    cout++;
                }
            }

            result = cout/arr.Length*100;

            return result;

        }
        public static int avgenew(int[] arr)
        {
            //세준이의 편법
            int max = arr[0];
            int total = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if(max <= arr[i])
                {
                    max = arr[i];
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] / max * 100;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                total = total + arr[i];
            }

            total = total / arr.Length;

            return total;

        }
        public static int strsize(char[] arr)
        {
            // 배열에 문자가 다 들어가고 그것을 안에서 배열을 나눈다. 

            int count = 1;

            for(int i = 0; i< arr.Length; i++)
            {
                if (char.IsWhiteSpace(arr[i]))
                {
                    count = count + 1;
                } 
            }
            return count;
        }

        public static void score(int a)
        {
            // 시험점수를 되돌려 주는 메서드 
            a = a / 10;

            switch (a)
            {
                case 10:
                case 9:
                    Console.WriteLine("A");
                    break;
                case 8:
                    Console.WriteLine("B");
                    break;
                case 7:
                    Console.WriteLine("C");
                    break;
                case 6:
                    Console.WriteLine("D");
                    break;
                default:
                    Console.WriteLine("F");
                    break;
            }
                 
        }

        public static void daycount(int a, int b)
        {
            // 날짜를 넣으면 요일이 나옴 ( 윤년을 계산 못함).. 
            int year_head = 20;
            int year_tail = 07;
            int month = 13*(a + 1)/5;
            int week = (b + month + year_tail + (year_tail / 4) + (year_head / 4) - 2 * year_head)%7;

            Console.WriteLine(week);
            switch (week)
            {
                case 0:
                    Console.WriteLine("일요일");
                    break;
                case 1:
                    Console.WriteLine("월요일");
                    break;
                case 2:
                    Console.WriteLine("화요일");
                    break;
                case 3:
                    Console.WriteLine("수요일");
                    break;
                case 4:
                    Console.WriteLine("목요일");
                    break;
                case 5:
                    Console.WriteLine("금요일");
                    break;
                default:
                    Console.WriteLine("토요일");
                    break;
            }


        }

        public static void arrayinput(int[] arr)
        {
            // 배열을 입력 받아 한줄에 10개씩만 출력
            int count = 0;

            for(int i = 0; i<arr.Length; i++)
            {
                if (count < 9)
                {
                    Console.Write("{0} ", arr[i]);
                    count++;
                }
                else
                {
                    count = 0;
                    Console.WriteLine("{0} ", arr[i]);
                }

            }
        }

        public static void gugudan(int a)
        {
            int i = 1;
            while (i <=9)
            {
                int result = a * i;
                Console.WriteLine(result);
                i++;
            }
        }

        public static void candy(int a , int b)
        {
            // 노답 형제에게 캔디를 주자 !!
            int result = a / b;
            int remainder = a % result;

            Console.WriteLine("인당 캔디{0}, 남은 캔디{1}",result, remainder);
            
        }

        public static void avgestudy(int[] arr)
        {
            // 5명 학생의 평균을 구하는 메소드

            double total = 0;

            for(int i =0; i<arr.Length; i++)
            {
                if(40 > arr[i])
                {
                    total = total + 40;
                }
                else
                    total = total + arr[i];
            }
            total = total / arr.Length;
        }

        public static void sugar(int a)
        {
            // 설탕 배달

            int three = 0;
            int five = a / 5;
                a %= 5; // 5kg에 다 담아지는 봄 
                        // 나머지를 3kg에 담아지는 지 확인 
             
            while(five >= 0)
            {
                if(a % 3 == 0) // 3kg에 담아지는 봄
                {
                    three = a / 3; // 3kg에 담음 
                    a %= 3; // 3kg 에 담은 것을 뺌 
                    break;
                }
                five--; //5kg 봉지 해체
                a += 5; // 5kg를 전체에 넣어줌 
            }
            if (a == 0)
                Console.WriteLine("5kg 설탕 {0}, 3kg 설탕 {1}", five, three);
            else
                Console.WriteLine("배달 불가요");

        }

        public static int paperpiz(int a,int[] arr)
        {
           // 지민이의 책 수정 요망...
            if(a < 10)
            {
                for (int i = 1; i <= a; i++)
                {
                    arr[i] = arr[i] + 1;
                }

                for (int i = 0; i < 10; i++)
                     Console.WriteLine(arr[i]);
            }
            else
            {
                for(int i = 1; i <11; i++)
                {
                    arr[i-1] = arr[i-1] + 1;
                }

                return paperpiz(a - 10, arr);
            }

            return 1;

        }

        public static bool palindrome(char[] arr)
        {
            // 미완성 
            int[] count = new int[10];
  
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("이름{0}, {1}번째",arr[i],i);
            }

            for(int i = 0; i < arr.Length/2 ; i++)
            {
                for(int j = arr.Length; j < arr.Length; j--)
                {
                    if (arr[i] == arr[j])
                    {
                        count[i] = count[i] + 1;
                    }
                }
            }
            return true;
        }





        static void Main (string[] args)
        {
            /*
             * 20% 할인해주는 main
            string str = Console.ReadLine();
            double total = Int64.Parse(str);
            total=sale(total);
            Console.WriteLine(total);
            
            int total = sum(3);
            Console.WriteLine(total);

            score(88);
            daycount(6, 25);
            candy(15, 5);

            sugar(21);
            Console.WriteLine(8%5);
            */

            /*
            int[] arr = new int[10];

            paperpiz(11,arr);
            */
            /*
            string str = "The Curious Case of Benjamin Button";

            int result =strsize(str.ToCharArray());

            Console.WriteLine(result);

            ch
            */
            sugar(7);
        }
    }
}
