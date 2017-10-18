namespace 二叉树
{
    public class Node
    {
        private char data;
        private Node head;
        private Node left;
        private Node right;

        public Node(char data)
        {
            this.data = data;
        }

        public char Data
        {
            get { return data; }
            set { this.data = value; }
        }

        public Node Head
        {
            get { return head; }
            set { this.head = value; }
        }
        public Node Left
        {
            get { return left ; }
            set { this.left = value; }
        }
        public Node Right
        {
            get { return right; }
            set { this.right = value; }
        }
    }
}