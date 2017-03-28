using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_03_28
{
    class Program
    {
        //2진트리가 기본이고 3트리가 되면 연산이 줄어들어서 안정적이다.
        class node
        {
            public int val;
            public node right;
            public node left;
            public node parent;

            public node(){
                val = 0;
                left = null;
                right = null;
                parent = null;
            }
            public node(int _val){
                val = _val;
                left = null;
                right = null;
                parent = null;
            }
        }
        class TwoThreeTree
        {
            node root;
            node curtnode;

            public TwoThreeTree()
            {
                root = null;
                curtnode = new node();
            }
            public void insert(int _val){

                curtnode = root;

                if (root == null){         
                    root = new node();
                    root.val = _val;
                }

                for (; curtnode != null;) {

                    if (curtnode.val > _val)
                    {
                        if (curtnode.left != null){
                            curtnode = curtnode.left;
                        }
                        else{
                            curtnode.left = new node(_val);
                            curtnode.left.parent = curtnode;
                            break;
                        }
                    }
                    else{
                        if (curtnode.right != null){
                            curtnode = curtnode.right;
                        }
                        else{
                            curtnode.right = new node(_val);
                            curtnode.right.parent = curtnode;
                            break;
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
