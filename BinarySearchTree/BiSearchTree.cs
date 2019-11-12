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
        public void Add(TreeNode<T> input)
        {
            //O(n)
            if(Root == null)
            {
                Root = input;
                return;
            }
            TreeNode<T> temp = Root;
            while (true)
            {
                if (input.value.CompareTo(temp.value) <= 0)
                {
                    if(temp.LeftChild == null)
                    {
                        temp.LeftChild = input;
                        return;
                    }
                    else
                    {
                        temp = temp.LeftChild;
                    }
                }
                else if (input.value.CompareTo(temp.value) > 0)
                {
                    if (temp.RightChild == null)
                    {
                        temp.RightChild = input;
                        return;
                    }
                    else
                    {
                        temp = temp.RightChild;
                    }
                }
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
