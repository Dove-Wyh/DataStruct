namespace 顺序表
{
    public interface IListDS<T>
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
