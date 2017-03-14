using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_03_14_2_
{
    class MyStackInt
    {
        // 0 ~ 9 까지의 숫자를 스택 사용해서 사칙연산을 한다.

        int[] intArr;
        int top = 0;

        int had = 0;
        int tail = 0;
        char mark = ' ';
        
        public void push(int val)
        {
            // 스택에 넣는 과정 

            if (top < intArr.Length)
            {
                intArr[top++] = val;
                Console.WriteLine(top);
            }
            else
                Console.WriteLine("stack이 가득참");
        }

        public int pop()
        {
            // 스택에서 빼는 과정 

            if(top > 0)
            {
                top--;
                return intArr[top];
            }
            else
                Console.WriteLine("더 이상 꺼낼 수 없다.");
            return 0;
        }

        public void change(char[] arr)
        {
            
            for(int i = 0; i < arr.Length; i++)
            {
                if(char.IsPunctuation(arr[i]))
                {
                    
                }
                else
                {
                    int a = Convert.ToInt32(arr[i]);
                    push(a);
                } 
                
            }

            for(int i = 0; i < arr.Length; i++)
            {
                
                if (char.IsPunctuation)
                {
                    
                }
            }
        }

        public MyStackInt(int size)
        {
            // 생성자 
            intArr = new int[size];     
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyStackInt sta = new MyStackInt(10);

            string pass = Console.ReadLine();
            char[] arr = pass.ToCharArray();
            sta.change(arr);

        }
    }
}
