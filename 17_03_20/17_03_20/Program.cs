using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_03_20
{
    // 이진트리(수정 요망)
    class node
    {
        public int val;
        public node right;
        public node left;
    }
    class preordertrea
    {
        node root;
        node tmp1;
        node tmp2;
        node tmp3;
        node tmp4;
        node tmp5;
        node tmp6;
        node tmp7;

        public preordertrea()
        {
            root = null;         
        }

        public void push(int val)
        {
            node tmpnode = new node();
            tmpnode.val = val;
            tmpnode.left = null;
            tmpnode.right = null;

            if (root == null)
            {
                tmp1 = tmpnode;
                root = tmp1;
            }
            else if(tmp1.left == null)
            {
                tmp2 = tmpnode;
                tmp1.left = tmp2;
            }
            else if(tmp1.right == null)
            {
                tmp3 = tmpnode;
                tmp1.right = tmp3;
            }
            else if(tmp2.left == null)
            {
                tmp4 = tmpnode;
                tmp2.left = tmp4;
            }
            else if (tmp2.right == null)
            {
                tmp5 = tmpnode;
                tmp2.right = tmp5;
            }
            else if (tmp3.left == null)
            {
                tmp6 = tmpnode;
                tmp3.left = tmp6;
            }
            else if (tmp3.right == null)
            {
                tmp7 = tmpnode;
                tmp3.right = tmp7;
            }
        }
        public int pop()
        {
            if(root != null)
            {
                if(tmp1.left != null)
                {
                    if (tmp2.left != null)
                    {
                        tmp2.left = null;
                        return tmp4.val;
                    }
                    else if (tmp2.right != null)
                    {
                        tmp2.right = null;
                        return tmp5.val;
                    }
                    else
                    {
                        tmp1.left = null;
                        return tmp2.val;
                    }   
                }
                else if(tmp1.right != null)
                {
                    if (tmp3.left != null)
                    {
                        tmp3.left = null;
                        return tmp6.val;
                    }
                    else if (tmp3.right != null)
                    {
                        tmp3.right = null;
                        return tmp7.val;
                    }
                    else
                    {
                        tmp1.right = null;
                        return tmp3.val;
                    }
                }
                root = null;
                return tmp1.val;
            }
            return 0;
        } 

    }
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}
