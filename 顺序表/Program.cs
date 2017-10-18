using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 顺序表
{
    class Program
    {
        static void Main(string[] args)
        {
            SequenceList<int> sequenceList0 = new SequenceList<int>();
            sequenceList0.Add(1);
            sequenceList0.Add(22);
            sequenceList0.Add(33);

            Console.WriteLine(sequenceList0.Locate(33));

            Console.WriteLine(sequenceList0.IsEmpty());

            sequenceList0.Delete(22);
            for (int i = 0; i < sequenceList0.count; i++)
            {
                Console.Write(sequenceList0.GetElement(i) + " ");
            }
            Console.WriteLine();

            sequenceList0.DeleteAt(1);
            for (int i = 0; i < sequenceList0.count; i++)
            {
                Console.Write(sequenceList0.GetElement(i) + " ");
            }
            Console.WriteLine();
            
            sequenceList0.Insert(99,1);
            for (int i = 0; i < sequenceList0.count; i++)
            {
                Console.Write(sequenceList0.GetElement(i) + " ");
            }
            Console.WriteLine();

            sequenceList0.Clear();

            for (int i = 0; i < 100; i++)
            {
                sequenceList0.Add(i);
                Console.WriteLine(sequenceList0.count + " " + sequenceList0.data.Length);
            }

            Console.ReadKey();


        }
    }
}
