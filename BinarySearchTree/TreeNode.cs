using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class TreeNode<T>
    {
        public T value;
        public TreeNode<T> LeftChild;
        public TreeNode<T> RightChild;
        public TreeNode(T input)
        {
            value = input;
        }
    }
}
