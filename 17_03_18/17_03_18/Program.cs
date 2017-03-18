using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_03_18
{
    class Node
    {
        public int val; // 값을 담는 상자
        public Node next; // 다음 노드
    }

    class MyStackByLL
    {
        Node head;
        Node tail;

        public MyStackByLL()
        {
            head = tail = null;
        }

        public void push(int val)
        {
            
            Node tmpNode = new Node();
            tmpNode.val = val;
            tmpNode.next = null;

            if ( tail == null )
            {
                head = tmpNode;
                tail = tmpNode; 
            }
            else
            {
                tail.next = tmpNode;
                tail = tmpNode;  // 가리키는 곳이 똑같이 안은가 ??
            }
           
        }

        public int pop()
        {
            Node curnode = head;

            while(curnode.next != tail)
            {
                curnode = curnode.next;
            }
                int val = tail.val;
                tail = curnode;
                Console.WriteLine(val);
      
            return 0;
        }

         
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyStackByLL node = new MyStackByLL();

            node.push(10);
            node.push(20);
            node.push(30);
            node.pop();
            node.pop();
            node.pop();
        }
    }
}
