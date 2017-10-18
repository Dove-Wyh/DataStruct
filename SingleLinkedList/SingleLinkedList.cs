using System;

namespace 单链表
{
    public class SingleLinkedList<T> : ISingleLinkedListDS<T>
    {
        public int count;

        public Node<T> head;

        public SingleLinkedList()
        {
            head = null;
        }

        public T this[int index] => GetElement(index);

        public void Add(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> tempNode = head;
                while (tempNode.NextNode != null)
                {
                    tempNode = tempNode.NextNode;
                }
                tempNode.NextNode = newNode;
            }
            count++;
        }

        public void Clear()
        {
            head = null;
            count = 0;
        }

        public bool Delete(T item)
        {
            DeleteAt(Locate(item));
            return true;
        }

        public void DeleteAt(int index)
        {
            count--;
            if (index == 0)
            {
                head = head.NextNode;
                return;
            }
            Node<T> tempNode = head;
            for (int i = 0; i < index - 1; i++)
            {
                tempNode = tempNode.NextNode;
            }
            tempNode.NextNode = tempNode.NextNode.NextNode;
        }

        public T GetElement(int index)
        {
            Node<T> tempNode = head;
            for (int i = 0; i < index; i++)
            {
                tempNode = tempNode.NextNode;
            }
            return tempNode.Data;
        }

        public void Insert(T item, int index)
        {
            Node<T> newNode = new Node<T>(item);
            if (index == 0)
            {
                newNode.NextNode = head;
                head = newNode;
            }
            else
            {
                Node<T> tempNode = head;
                for (int i = 0; i < index - 1; i++)
                {
                    tempNode = tempNode.NextNode;
                }
                newNode.NextNode = tempNode.NextNode;
                tempNode.NextNode = newNode;
            }
            count++;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public int Locate(T item)
        {
            int i = -1;
            for (Node<T> node = head; node != null; node = node.NextNode)
            {
                i++;
                if (node.Data.Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}