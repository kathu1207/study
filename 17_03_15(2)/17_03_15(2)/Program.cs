using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_03_15_2_
{
    //원형 큐 

    class MyQueue
    {
        int[] QueueArr;
        int frount = 0;
        int rear = 0;

        public void enQueue(int a)
        {
            if ((rear + 1)% QueueArr.Length == frount)
            {
                Console.WriteLine("메모리가 가득 찼습니다.");
            }
            else
            {
                Console.WriteLine("{0}번째 메모리가 참", rear);
                QueueArr[rear++] = a;
                rear = rear % QueueArr.Length;
            }
            
        }

        public int deQueue()
        {
            if (rear == frount)
            {
                Console.WriteLine("메모리가 비어있습니다.");
            }
            else if (frount < QueueArr.Length)
            {
                Console.WriteLine("{0}번째 메모리가 뺌", frount);
                return QueueArr[frount++];
            }
            else 
            {
                frount = 0;
            }
            return 0;
        }

        public MyQueue(int size)
        {
            QueueArr = new int[size];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            MyQueue Que = new MyQueue(7);
        }
    }
}
