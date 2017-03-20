using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_03_20_2_
{
    // 트리를 이용한 계산기
    class Program
    {
        class node
        {
            public int  val;
            public char math;
            public node left;
            public node right;

            public node()
            {
                val = 0;
                left = null;
                right = null;
            }
            public node(int _val)
            {
                val = _val;
                left = null;
                right = null;
            }
            public node(char _math)
            {
                math = _math;
                left = null;
                right = null;
            }
        }
        class tree
        {
            node root;

            public void Insert(node parent, node left, node right)
            {
                parent.left = left;
                parent.right = right;
            }

            void TravelsByPost(node load)
            {
                if (load.left != null)
                    TravelsByPost(load.left);

                if (load.right != null)
                    TravelsByPost(load.right);

                if ((char.IsSymbol(load.math)) || (char.IsPunctuation(load.math)))
                {
                    int a = load.left.val;
                    int b = load.right.val;

                    switch (load.math)
                    {
                        case '*':
                            load.val = a * b;
                            break;
                        case '+':
                            load.val = a + b;
                            break;
                        case '-':
                            load.val = a - b;
                            break;
                        case '/':
                            load.val = a / b;
                            break;
                        default:
                            break;
                    }
                }
                
               
                    Console.Write(load.val + " ");
            }

            public void TravelsByPost()

            {
                TravelsByPost(root);
            }

            public void SetRoot(node rootNode)
            {
                root = rootNode;
            }

        }

        static void Main(string[] args)
        {
            node tmpNode1 = new node('+');
            node tmpNode2 = new node(2);
            node tmpNode3 = new node('*');
            //node tmpNode4 = new node();
            //node tmpNode5 = new node();
            node tmpNode6 = new node(3);
            node tmpNode7 = new node(7);

            tree Tree = new tree();

            Tree.SetRoot(tmpNode1);

            Tree.Insert(tmpNode1, tmpNode2, tmpNode3);
            //Tree.Insert(tmpNode2, tmpNode4, tmpNode5);
            Tree.Insert(tmpNode3, tmpNode6, tmpNode7);

            Tree.TravelsByPost();
            Console.WriteLine();
        }
    }
}
