using System.Runtime.InteropServices.ComTypes;

namespace 栈
{
    public class MyStack<T> : IStackDS<T>
    {
        private T[] data;
        public int top;

        public MyStack(int size)
        {
            data = new T[size];
            top = -1;
        }

        public MyStack() : this(8)
        {

        }

        public int Count => top + 1;

        public void Clear()
        {
            top = -1;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < top; i++)
            {
                if (data[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public T Peek()
        {
            return data[top];
        }

        public T Pop()
        {
            top--;
            return data[top + 1];
        }

        public void Push(T item)
        {
            data[++top] = item;
        }
    }
}