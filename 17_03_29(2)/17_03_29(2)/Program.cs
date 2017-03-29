using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_03_29_2_
{
    class Program
    {
        class BinaryTreeNode{

            public int val;
            public BinaryTreeNode left;
            public BinaryTreeNode right;
            public BinaryTreeNode parent;

            public BinaryTreeNode(){
                val = 0;
                left = null;
                right = null;
                parent = null;
            }

            public BinaryTreeNode(int _val){
                val = _val;
                left = null;
                right = null;
                parent = null;
            }
        }

        class BinaryTree {

            BinaryTreeNode root;

            public void Insert(BinaryTreeNode parent, BinaryTreeNode left, BinaryTreeNode right){
                parent.left = left;
                parent.right = right;
            }

            void TravelsByPre(BinaryTreeNode _root){

                Console.Write(_root.val + " ");
                if (_root.left != null)
                    TravelsByPre(_root.left);
                if (_root.right != null)
                    TravelsByPre(_root.right);
            }

            public void TravelsByPre(){
                TravelsByPre(root);
            }

            void TravelsByIn(BinaryTreeNode _root){

                if (_root.left != null)
                    TravelsByIn(_root.left);

                Console.Write(_root.val + " ");

                if (_root.right != null)
                    TravelsByIn(_root.right);
            }

            public void TravelsByIn(){
                TravelsByIn(root);
            }

            void TravelsByPost(BinaryTreeNode _root){

                if (_root.left != null)
                    TravelsByPost(_root.left);

                if (_root.right != null)
                    TravelsByPost(_root.right);

                Console.Write(_root.val + " ");
            }

            public void TravelsByPost(){
                TravelsByPost(root);
            }

            public void SetRoot(BinaryTreeNode rootNode){
                root = rootNode;
            }
        }

        class BST : BinaryTree
        {
            BinaryTreeNode root;

            public BST()
            {
                root = null;
            }

            public void Insert(int val){

                if (root == null)
                    root = new BinaryTreeNode(val);
                else{
                    BinaryTreeNode curNode = root;

                    while (true){
                        if (curNode.val > val)
                        {

                            if (curNode.left == null)
                            {
                                curNode.left = new BinaryTreeNode(val);
                                curNode.left.parent = curNode;
                                break;
                            }
                            else
                                curNode = curNode.left;
                        }
                        else if (curNode.val < val)
                        {

                            if (curNode.right == null)
                            {

                                curNode.right = new BinaryTreeNode(val);
                                curNode.right.parent = curNode;
                                break;
                            }
                            else
                                curNode = curNode.right;
                        }
                    }
                }
            }

            public void Delete(int val){

                BinaryTreeNode curNode = root;

                if (curNode == null)
                    Console.WriteLine("BST is empty!!!");
                else{

                    while (true){
                        if (curNode.val == val){

                            if (curNode.left != null){

                                if (curNode.right != null){
                                    BinaryTreeNode leftMaxNode = curNode.left;

                                    while (leftMaxNode.right != null)
                                        leftMaxNode = leftMaxNode.right;

                                    curNode.val = leftMaxNode.val;

                                    if (leftMaxNode.left != null){

                                        leftMaxNode.left.parent = leftMaxNode.parent;
                                        leftMaxNode.parent.right = leftMaxNode.left;
                                    }
                                    else
                                        leftMaxNode.parent.right = null;
                                }
                                else
                                {
                                    curNode.left.parent = curNode.parent;

                                    if (curNode.parent.left == curNode)
                                        curNode.parent.left = curNode.left;

                                    else
                                        curNode.parent.right = curNode.left;
                                }
                            }
                            else{

                                if (curNode.right != null){
                                    curNode.right.parent = curNode.parent;

                                    if (curNode.parent.left == curNode)
                                        curNode.parent.left = curNode.right;

                                    else
                                        curNode.parent.right = curNode.right;
                                }
                                else{ 
                                    if (curNode.parent.left == curNode)
                                        curNode.parent.left = null;

                                    else
                                        curNode.parent.right = null;
                                }
                            }
                            break;
                        }
                        else if (curNode.val > val){

                            if (curNode.left == null){
                                Console.WriteLine(val + " is not BST!!!");
                                break;
                            }
                            else
                                curNode = curNode.left;
                        }
                        else{
                            if (curNode.right == null){
                                Console.WriteLine(val + " is not BST!!!");
                                break;
                            }
                            else
                                curNode = curNode.right;
                        }
                    }
                }
            }

            public bool Search(int val){
                BinaryTreeNode curNode = root;

                if (curNode == null)
                    return false;

                else{
                    while (curNode != null){

                        if (curNode.val == val)
                            return true;

                        else if (curNode.val > val)
                            curNode = curNode.left;
                        else
                            curNode = curNode.right;
                    }
                    return false;
                }
            }      
        }
        static void Main(string[] args)
        {
        }
    }
}
