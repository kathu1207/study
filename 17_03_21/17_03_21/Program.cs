using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_03_21
{
    //이진 트리 max(수정 요망)
    class Program
    {
        class Treenode
        {
            public int val;
            public Treenode parent;
            public Treenode right;
            public Treenode left;

            public Treenode()
            {
                val = 0;
                parent = null;
                right = null;
                left = null;
            }
            public Treenode(int _val)
            {
                val = _val;
                parent = null;
                right = null;
                left = null;
            }
        }
        class BinaryTree
        {
            Treenode root;
            Treenode last;
            Treenode tmpnode;

            public BinaryTree()
            {
                root = null;
                last = null;
                tmpnode = new Treenode();
            }

            public void push(int val)
            {
                
                if(root == null)
                {
                    root = tmpnode;
                    root.val = val;
                    last = root;
                    root.left = tmpnode = new Treenode();
                    tmpnode.parent = root;

                }
                else 
                {
                    last = tmpnode;
                    last.val = val;
                    
                    
                }
               
            }

            void Findtmpnode()
            {
                Treenode cnode = tmpnode; // 임시로 만든 것 

                if(cnode.parent.left == tmpnode) // tmpnode의 부모의 왼쪽이 자신이냐 라는 의미
                {
                    tmpnode = new Treenode(); //last에 자리를 주었기 때문에 새로 하나 만듬

                    cnode.parent.right = tmpnode;  //오른쪽을 줌
                    tmpnode.parent = cnode.parent; 
                }
                else
                {
                    while((cnode.parent.left != tmpnode)&&(cnode.parent != root)) 
                    {
                        // 왼쪽이 자기자신이 아닐때 즉 오른쪽에 있을때 그리고 부모가 루트가 아닌 경우 하위에서 다른 곳을 갈려는 경우
                        // 왼쪽에 숫자가 있으면 가득 찼다는 경우 이기 때문에 위로 올라가서 확인
                        cnode = cnode.parent;
                    }
                }
            }

            public void such(Treenode load,int val)
            {
                if (load.left != null)
                {
                    such(load.left,val);
                }
                if (load.right != null)
                {
                    such(load.right,val);
                }
                if ((load.left == null) && (load.right == null))
                {

                }
                
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
