using System;

namespace 二叉排序树
{
    public class Tree
    {
        public Node root = null;
        public Node temp;

        //添加结点
        public void Add(int data)
        {
            Node node = new Node(data);
            temp = root;
            if (root == null)
            {
                root = node;
            }
            else
            {
                while (true)
                {
                    if (node.Data < temp.Data)
                    {
                        if (temp.Left == null)
                        {
                            temp.Left = node;
                            node.Parent = temp;
                            return;
                        }
                        else
                        {
                            temp = temp.Left;
                        }
                    }
                    else//node.Data >= temp.Data
                    {
                        if (temp.Right == null)
                        {
                            temp.Right = node;
                            node.Parent = temp;
                            return;
                        }
                        else
                        {
                            temp = temp.Right;
                        }
                    }
                }
            }
        }

        //中序遍历 左中右
        public void InorderTraversal(Node node)
        {
            if (node.Left != null)
            {
                InorderTraversal(node.Left);
            }
            Console.Write(node.Data + " ");
            if (node.Right != null)
            {
                InorderTraversal(node.Right);
            }
        }

        //查找结点
        public bool Find(int data)
        {
            Node node = new Node(data);
            temp = root;
            if (root == null)
            {
                return false;
            }

            while (true)
            {
                if (temp.Data == node.Data)
                {
                    return true;
                }

                if (node.Data < temp.Data)
                {
                    if (temp.Left == null)
                    {
                        return false;
                    }
                    temp = temp.Left;
                }
                else
                {
                    if (temp.Right == null)
                    {
                        return false;
                    }
                    temp = temp.Right;
                }
            }
        }

        //删除节点
        public bool Delete(int data)
        {
            if (Find(data) == false)
            {
                return false;
            }
            //如果结点没有左右子树
            if (temp.Left == null && temp.Right == null)
            {
                if (temp.Parent == null)
                {
                    root = null;
                    return true;
                }
                if (temp.Parent.Left == temp)
                {
                    temp.Parent.Left = null;
                }
                else
                {
                    temp.Parent.Right = null;
                }
                return true;
            }
            //如果有右子树没有左子树
            if (temp.Left == null && temp.Right != null)
            {
                if (temp.Parent.Left == temp)
                {
                    temp.Parent.Left = temp.Right;
                }
                else
                {
                    temp.Parent.Right = temp.Right;
                }
                return true;
            }
            //如果有左子树没有右子树
            if (temp.Right == null && temp.Left != null)
            {
                if (temp.Parent.Left == temp)
                {
                    temp.Parent.Left = temp.Left;
                }
                else
                {
                    temp.Parent.Right = temp.Left;
                }
                return true;
            }
            //剩下只有有左右子树的情况
            Node minInRight = temp.Right;
            //先找到右子树中的最小值
            while (true)
            {
                if (minInRight.Left == null)
                {
                    break;
                }
                else
                {
                    minInRight = minInRight.Left;
                }
            }
            //最小值结点肯定没有左子树，并且在它父节点的左边，所以把最小值结点的右子树付给最小值结点的父节点的左边
            minInRight.Parent = minInRight.Parent;
            minInRight.Parent.Left = minInRight.Right;

            //如果删除的是不是根节点
            if (temp.Parent != null)
            {
                minInRight.Parent = temp.Parent;
                if (temp.Parent.Left == temp)
                {
                    temp.Parent.Left = minInRight;
                }
                else
                {
                    temp.Parent.Right = minInRight;
                }
            }

            //把要删除的结点的左子树给最小值的左边
            minInRight = temp.Left.Parent;
            minInRight.Left = temp.Left;
            //把要删除的结点的右子树给最小值的右边
            minInRight = temp.Right.Parent;
            minInRight.Right = temp.Right;

            return true;
        }
    }
}