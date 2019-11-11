using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BiSearchTree<int> tree = new BiSearchTree<int>();
            tree.Add(new TreeNode<int>(5));
            tree.Add(new TreeNode<int>(7));
            tree.Add(new TreeNode<int>(9));
            tree.Add(new TreeNode<int>(8));
            tree.Add(new TreeNode<int>(3));
            Console.WriteLine(tree.Search(8));
            Console.WriteLine(tree.Search(5));
            Console.WriteLine(tree.Search(6));
            Console.WriteLine(tree.Search(7));
            Console.WriteLine(tree.Search(9));
            Console.WriteLine(tree.Search(3));
            Console.ReadLine();
        }
    }
}
