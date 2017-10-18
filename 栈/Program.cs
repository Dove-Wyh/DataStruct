using System;
using System.Collections.Generic;

namespace 栈
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            MyStack<int> stack = new MyStack<int>();
            stack.Push(80);
            Console.WriteLine(stack.Contains(80));
            Console.WriteLine(stack.Count);
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Count);


            Console.ReadKey();
        }
    }
}
