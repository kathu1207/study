using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_03_27_2_
{
    class Program
    {
        //BST(Binary search Tree)

        class node
        {
            public int val;
            public node right;
            public node left;
            public node parent;

            public node()
            {
                val = 0;
                left = null;
                right = null;
                parent = null;
            }
            public node(int _val)
            {
                val = _val;
                left = null;
                right = null;
                parent = null;
            }
        }
        class BST
        {
            node root;
            node curtnode;
            node tmp;

            public BST()
            {
                root = null;
                curtnode = new node();
                tmp = new node();
            }
            public void insert(int _val)
            {
                curtnode = root;

                if (root == null)
                {
                    root = new node();
                    root.val = _val;
                }

                for ( ;curtnode != null;)
                {
                    if(curtnode.val > _val)
                    {
                        if (curtnode.left != null)
                        {
                            curtnode = curtnode.left;
                        }
                        else
                        {
                            curtnode.left = new node(_val);
                            curtnode.left.parent = curtnode;
                            break;

                        }
                    }
                    else
                    {
                        if (curtnode.right != null)
                        {
                            curtnode = curtnode.right;
                        }
                        else
                        {
                            curtnode.right = new node(_val);
                            curtnode.right.parent = curtnode;
                            break;
                        }
                    }
                }
            }
            public void delete(int _val)
            {
                curtnode = root;

                for (; curtnode != null;)
                {
                    if(curtnode.val == _val)
                    {
                        swap();
                    }
                   
                    if (curtnode.val > _val)
                    {
                        curtnode = curtnode.left;
                    }
                    else
                    {
                        curtnode = curtnode.right;
                    }
                }
            }
            public void swap() // 수정 요망 삭제가 제대로 안됨 자리 바꾸기는 성공
            {
                if(curtnode.left != null)
                {
                    tmp = curtnode.left;

                    for (; tmp != null;)
                    {
                        if (tmp.right != null)
                            tmp = tmp.right;
                        else
                        {
                            curtnode.val = tmp.val;
                            break;
                        }
                    }
                }
                else
                {
                    tmp = curtnode.right;

                    for (; tmp != null;)
                    {
                        if (tmp.left != null)
                            tmp = tmp.left;
                        else
                        {
                            curtnode.val = tmp.val;
                            break;
                        }
                    }
                }
                
            }
            public void input()
            {
                Console.WriteLine(root.left.val);
                Console.WriteLine(root.left.right.val);
                Console.WriteLine(root.left.left.val);
                Console.WriteLine(" ");

                Console.WriteLine(root.right.val);
                Console.WriteLine(root.right.right.val);
                Console.WriteLine(root.right.left.val);
                Console.WriteLine(" ");
            }

        }
        static void Main(string[] args)
        {
            BST test = new BST();

            test.insert(14);
            test.insert(18);
            test.insert(15);
            test.insert(19);
            test.insert(20);
            test.insert(11);
            test.insert(12);
            test.insert(7);
            test.insert(8);
            test.insert(9);
            test.insert(10);
            test.insert(6);
            test.insert(5);

            test.input();

            test.delete(11);
            test.delete(18);

            test.input();
            



        }
    }
}
