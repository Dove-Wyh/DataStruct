namespace 单链表
{
    public class Node<T>
    {
        private T data;
        private Node<T> nextNode;

        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        public Node<T> NextNode
        {
            get { return nextNode; }
            set { nextNode = value; }
        }

        public Node(T data)
        {
            this.data = data;
        }

        public Node(T data, Node<T> nextNode)
        {
            this.data = data;
            this.nextNode = nextNode;
        }

        public Node(Node<T> nextNode)
        {
            this.nextNode = nextNode;
        }
    }
}