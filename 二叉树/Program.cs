using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二叉树
{
    class Program
    {
        static void InitBinaryTree(Node root)
        {
            Node a = root;
            Node b = new Node('B');
            Node c = new Node('C');
            Node d = new Node('D');
            Node e = new Node('E');
            Node f = new Node('F');
            Node g = new Node('G');
            Node h = new Node('H');
            Node i = new Node('I');
            a.Left = b;
            a.Right = c;
            b.Left = d;
            c.Left = e;
            c.Right = f;
            d.Left = g;
            d.Right = h;
            e.Right = i;
            b.Head = a;
            c.Head = a;
            d.Head = b;
            e.Head = c;
            f.Head = c;
            g.Head = d;
            h.Head = d;
            i.Head = e;
        }

        static void PreorderTraversal(Node root)        //前序遍历 中左右
        {
            Console.Write(root.Data + " ");
            if (root.Left != null)
            {
                PreorderTraversal(root.Left);
            }
            if (root.Right != null)
            {
                PreorderTraversal(root.Right);
            }
        }
        static void InorderTraversal(Node root)         //中序遍历 左中右
        {
            if (root.Left != null)
            {
                InorderTraversal(root.Left);
            }
            Console.Write(root.Data + " ");
            if (root.Right != null)
            {
                InorderTraversal(root.Right);
            }
        }
        static void PostorderTraversal(Node root)       //后序遍历 左右中
        {
            if (root.Left != null)
            {
                PostorderTraversal(root.Left);
            }
            if (root.Right != null)
            {
                PostorderTraversal(root.Right);
            }
            Console.Write(root.Data + " ");
        }

        static void Main(string[] args)
        {
            Node root = new Node('A');
            InitBinaryTree(root);

            PreorderTraversal(root);
            Console.WriteLine();

            InorderTraversal(root);
            Console.WriteLine();

            PostorderTraversal(root);
            Console.WriteLine();

            Console.Read();
        }
    }
}
