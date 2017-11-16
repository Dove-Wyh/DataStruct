using System;

namespace 顺序表
{
    public class SequenceList<T> : IListDS<T>
    {
        public T[] data;
        private T[] newData;//扩充数组大小时候使用
        public int count;

        public SequenceList(int index)
        {
            data = new T[index];
            count = 0;
        }

        public SequenceList() : this(8)//默认构造长度为8的数组
        {

        }

        //索引器的lamda表达式写法和正常写法
        //public T this[int index] => GetElement(index);
        public T this[int index]
        {
            get
            {
                if (index >= count && index < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    return data[index];
                }
            }
        }

        public void Add(T item)
        {
            if (count + 1 > data.Length)
            {
                newData = new T[data.Length * 2];
                Array.Copy(data, newData, data.Length);
                data = newData;
            }
            if (count < data.Length)
            {
                data[count] = item;
                count++;
            }
        }

        public void Clear()
        {
            count = 0;
        }

        public void DeleteAt(int index)
        {
            if (index >= count && index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                for (int i = index; i < count; i++)
                {
                    data[i] = data[i + 1];
                }
                count--;
            }
        }

        public bool Delete(T item)
        {
            int index = Locate(item);
            if (index == -1)
            {
                return false;
            }
            else
            {
                DeleteAt(index);
                return true;
            }
        }

        public T GetElement(int index)
        {
            if (index >= count && index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                return data[index];
            }
        }

        public void Insert(T item, int index)
        {
            //注意：这里count++，所以最后不需要再++了
            if (count++ > data.Length)
            {
                newData = new T[data.Length * 2];
                Array.Copy(data, newData, data.Length);
                data = newData;
                //throw new ArgumentOutOfRangeException();
            }
            if (index > count && index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = count - 1; i > count - index; i--)
            {
                data[i + 1] = data[i];
            }
            data[index] = item;
            //count++;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public int Locate(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (data[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}