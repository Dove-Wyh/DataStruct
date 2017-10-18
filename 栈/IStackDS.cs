using System;

namespace 栈
{
    public interface IStackDS<T>
    {
        int Count { get; }
        bool Contains(T item);
        void Push(T item);
        T Pop();
        T Peek();
        void Clear();

    }
}