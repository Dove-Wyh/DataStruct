namespace 二叉排序树
{
    public class Node
    {
        private int data;
        private Node parent;
        private Node left;
        private Node right;

        public Node(int data)
        {
            this.data = data;
        }

        public int Data
        {
            get { return data; }
            set { this.data = value; }
        }

        public Node Parent
        {
            get { return parent; }
            set { this.parent = value; }
        }
        public Node Left
        {
            get { return left; }
            set { this.left = value; }
        }
        public Node Right
        {
            get { return right; }
            set { this.right = value; }
        }
    }
}