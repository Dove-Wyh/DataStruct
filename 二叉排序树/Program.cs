using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二叉排序树
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new[] {62, 58, 88, 47, 73, 99, 35, 51, 93, 37};
            Tree tree = new Tree();
            foreach (var item in num)
            {
                //把数组中的每一个数据都穿进去
                tree.Add(item);
            }
            tree.InorderTraversal(tree.root);
            Console.WriteLine();
            
            Console.WriteLine("查找99结果："+tree.Find(99));
            Console.WriteLine("查找98结果：" + tree.Find(98));
            Console.WriteLine("删除73结果：" + tree.Delete(73));
            Console.WriteLine("删除50结果：" + tree.Delete(50));
            tree.InorderTraversal(tree.root);
            Console.WriteLine();
            Console.WriteLine("删除62结果：" + tree.Delete(62));
            tree.InorderTraversal(tree.root);
            Console.ReadKey();
        }
    }
}
