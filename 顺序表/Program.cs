using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 顺序表
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    SequenceList<int> sequenceList0 = new SequenceList<int>();
        //    sequenceList0.Add(1);
        //    sequenceList0.Add(22);
        //    sequenceList0.Add(33);
        //    sequenceList0.Add(44);
        //    sequenceList0.Add(55);
        //    sequenceList0.Add(66);
        //    sequenceList0.Add(77);

        //    Console.WriteLine(sequenceList0.Locate(33));

        //    Console.WriteLine(sequenceList0.IsEmpty());

        //    sequenceList0.Delete(22);
        //    for (int i = 0; i < sequenceList0.count; i++)
        //    {
        //        Console.Write(sequenceList0.GetElement(i) + " ");
        //    }
        //    Console.WriteLine();

        //    sequenceList0.DeleteAt(1);
        //    for (int i = 0; i < sequenceList0.count; i++)
        //    {
        //        Console.Write(sequenceList0.GetElement(i) + " ");
        //    }
        //    Console.WriteLine();

        //    sequenceList0.Insert(99, 1);
        //    for (int i = 0; i < sequenceList0.count; i++)
        //    {
        //        Console.Write(sequenceList0.GetElement(i) + " ");
        //    }
        //    Console.WriteLine();

        //    sequenceList0.Clear();

        //    for (int i = 0; i < 100; i++)
        //    {
        //        sequenceList0.Add(i);
        //        //Console.WriteLine(sequenceList0.count + " " + sequenceList0.data.Length);
        //    }

        //    Console.ReadKey();
        //}

        static void Main(string[] args)
        {
            SequenceList<int> a = new SequenceList<int>();
            a.Add(1);
            a.Add(2);
            a.Add(3);
            a.Add(4);
            a.Add(5);
            a.Add(6);
            a.Add(7);
            a.Add(8);
            a.Add(9);
            a.Add(10);

            a.DeleteAt(5);
            a.Insert(99, 5);

            for (int i = 0; i < a.count; ++i)
            {
                if (i == 5)
                {
                    Trace.Assert(a[i] == 99);
                }
                else
                {
                    Trace.Assert(a[i] == i + 1);
                }
            }


            a = new SequenceList<int>();
            for (int i = 0; i <= 10000; ++i)
            {
                a.Add(i + 100);
            }

            for (int i = 100; i > 0; --i)
            {
                a.Insert(999, i * 100);
                a.DeleteAt(i * 100 - 1);
            }

            for (int i = 0; i < 10000; ++i)
            {
                int n = i + 100;
                if (n % 100 == 99)
                {

                    Trace.Assert(a[i] == 999);
                }
                else
                {
                    //Console.WriteLine(i + " " + a[i]);
                    Trace.Assert(a[i] == n);
                }
            }

            Console.WriteLine("测试成功！");
            Console.WriteLine("仅测试了Add, Insert, RemoveAt, Count四个方法");
            Console.ReadKey();
        }
    }
}
