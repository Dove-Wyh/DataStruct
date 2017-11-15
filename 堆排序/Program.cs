using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 堆排序
{
    class Program
    {
        void HeadSort(int[] a, int length)
        {
            for (int i = length; i > 1; i--)        //一共需要排列length - 1次
            {
                int index = i / 2 - 1;              //从有子结点的结点开始
                for (int j = index; j >= 0; j--)
                {
                    HeadSortUnit(a, j, i);          //从左中右三个中把最大和最小的交换位置
                }
                Change(a, 0, i - 1);
                //每次构成一个大顶堆并且交换堆顶（最大值）和最后一个结点之后，输出
                foreach (var i1 in a)
                {
                    Console.Write(i1 + " ");
                }
                Console.WriteLine();
            }
        }

        void HeadSortUnit(int[] a, int index, int length)
        {
            int left = index * 2 + 1;
            int right = left + 1;
            //index*2+1是左孩子的下标，所以index*2+1+1就是右孩子的下标
            if (right > length - 1)//代表没有右孩子
            {
                if (a[index] < a[left])
                {
                    Change(a, index, left);
                }
                return;
            }
            else                    //代表有右孩子
            {
                if (a[left] > a[right] && a[left] > a[index])
                {
                    Change(a, index, left);
                }
                if (a[right] > a[left] && a[right] > a[index])
                {
                    Change(a, index, right);
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
            Program p = new Program();
            int[] array;
            array = new[] { 1, 0, 10, 20, 3, 5, 6, 4, 9, 8, 12, 17, 34, 11 };
            p.HeadSort(array, array.Length);
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}
