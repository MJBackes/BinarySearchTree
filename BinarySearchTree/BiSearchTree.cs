using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BiSearchTree<T> where T:IComparable
    {
        public TreeNode<T> Root;
        public void Add(T input)
        {
            //O(n)
            TreeNode<T> inputNode = new TreeNode<T>(input);
            if(Root == null)
            {
                Root = inputNode;
                return;
            }
            TreeNode<T> temp = Root;
            while (true)
            {
                if (input.CompareTo(temp.value) <= 0)
                {
                    if(temp.LeftChild == null)
                    {
                        temp.LeftChild = inputNode;
                        return;
                    }
                    else
                    {
                        temp = temp.LeftChild;
                    }
                }
                else if (input.CompareTo(temp.value) > 0)
                {
                    if (temp.RightChild == null)
                    {
                        temp.RightChild = inputNode;
                        return;
                    }
                    else
                    {
                        temp = temp.RightChild;
                    }
                }
            }
        }
        public void AddRecursive(T input)
        {
            //O(logn)
            if (Root == null)
                Root = new TreeNode<T>(input);
            else if (input.CompareTo(Root.value) <= 0)
            {
              Root.LeftChild = AddRecursive(input, Root.LeftChild);
            }
            else
            {
               Root.RightChild = AddRecursive(input, Root.RightChild);
            }
        }
        public TreeNode<T> AddRecursive(T input,TreeNode<T> subRoot)
        {
            if (subRoot == null)
                return new TreeNode<T>(input);
            else if (input.CompareTo(subRoot.value) <= 0)
            {
              subRoot.LeftChild = AddRecursive(input, subRoot.LeftChild);
                return subRoot;
            }
            else
            {
               subRoot.RightChild = AddRecursive(input, subRoot.RightChild);
                return subRoot;
            }
        }
        public bool Search(T input)
        {
            //O(logn)
            if (Root == null)
                return false;
            if (input.CompareTo(Root.value) == 0)
            {
                return true;
            }
            else if(input.CompareTo(Root.value) < 0)
            {
                return Search(input, Root.LeftChild);
            }
            else
            {
                return Search(input, Root.RightChild);
            }

        }
        public bool Search(T input, TreeNode<T> subRoot)
        {
            if (subRoot == null)
                return false;
            if (input.CompareTo(subRoot.value) == 0)
            {
                return true;
            }
            else if (input.CompareTo(subRoot.value) < 0)
            {
                return Search(input, subRoot.LeftChild);
            }
            else
            {
                return Search(input, subRoot.RightChild);
            }
        }
    }
}
