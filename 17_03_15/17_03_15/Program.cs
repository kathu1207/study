using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_03_15
{
    //괄호를 확인하는 스택을 만드시오.

    class bracket
    {
        int[] intArr;
        int top = 0;

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

            if (top > 0)
            {
                top--;
                return intArr[top];
            }
            else
                Console.WriteLine("더 이상 꺼낼 수 없다.");
            return 0;
        }

        public int such()
        {

        }

        public bracket(int size)
        {
            int[] intArr = new int[size];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bracket numsuch = new bracket(10);

            numsuch.push();
        }
    }
}
