using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单链表
{
    class Program
    {
        public static void 输出(SingleLinkedList<int> sll)
        {
            for (Node<int> node = sll.head; node != null; node = node.NextNode)
            {
                Console.Write(node.Data + " ");
            }
            Console.WriteLine("总数：" + sll.count);
        }
        static void Main(string[] args)
        {
            SingleLinkedList<int> sll = new SingleLinkedList<int>();
            sll.Add(9);
            sll.Add(8);
            sll.Add(7);
            sll.Add(5);
            sll.Add(4);
            输出(sll);

            sll.Insert(6,1);        //根据下标插入
            输出(sll);

            sll.DeleteAt(1);        //根据下标删除
            输出(sll);

            sll.Delete(9);          //删除确切的数字
            输出(sll);

            Console.WriteLine(sll.Locate(0));
            Console.WriteLine(sll.GetElement(2));
            Console.WriteLine(sll[2]);
           
            Console.WriteLine(sll.IsEmpty());
            sll.Clear();
            Console.WriteLine(sll.IsEmpty());
            Console.ReadKey();
        }
    }
}
