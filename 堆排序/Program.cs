using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 堆排序
{
    class Program
    {
        void HeadSort(int[] a)
        {
            int index = a.Length / 2;
            for (int i = index; i >= 1; i--)
            {
                HeadSortUnit(a, i);
            }
        }

        void HeadSortUnit(int[] a, int index)
        {
            if (index > a.Length / 2)
            {
                return;
            }
            if (index * 2 + 1 > a.Length && a[index] < a[index * 2])//代表没有右结点
            {
                Change(a, index, index * 2);
            }
            else                         //代表有右结点
            {
                if (a[index * 2] > a[index * 2 + 1] && a[index * 2] > a[index])
                {
                    Change(a, index, index * 2);
                    HeadSortUnit(a, index * 2);
                }
                if (a[index * 2 + 1] > a[index * 2] && a[index * 2 + 1] > a[index])
                {
                    Change(a, index, index * 2 + 1);
                    HeadSortUnit(a, index * 2 + 1);
                }
            }
        }

        void Change(int[] a, int c1, int c2)
        {
            int temp;
            temp = a[c1];
            a[c1] = a[c2];
            a[c2] = temp;
        }

        static void Main(string[] args)
        {
            int[] array = new[] { 16, 7, 3, 20, 17, 8 };


        }
    }
}
