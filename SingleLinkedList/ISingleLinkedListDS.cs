namespace 单链表
{
    public interface ISingleLinkedListDS<T>
    {
        int Locate(T item);
        bool IsEmpty();
        bool Delete(T item);
        void DeleteAt(int index);
        void Clear();
        void Add(T item);
        void Insert(T item, int index);
        T GetElement(int index);
        T this[int index] { get; }
    }
}
