using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 背包问题
{
    class Program
    {
        /// <summary>
        /// 设定,一个物品只能放一次
        /// </summary>

        public static int 不带备忘从顶向下递归穷举法(int capacity, int count, int[] weight, int[] price)
        {
            if (count == 0)//从后向前依次选择放与不放,为1表示遍历完了
            {
                return 0;
            }
            if (weight[count] > capacity)//如果放不下,就放下一次东西
            {
                return 不带备忘从顶向下递归穷举法(capacity, count - 1, weight, price);
            }
            else//如果能放下,选择放还是不放
            {
                int value1 = 不带备忘从顶向下递归穷举法(capacity - weight[count], count - 1, weight, price) + price[count];
                int value2 = 不带备忘从顶向下递归穷举法(capacity, count - 1, weight, price);
                return value1 > value2 ? value1 : value2;
            }
        }

        //这个方法在第一次运行时候没有减少程序运行次数,而是在运行更小规模问题时候会有用

        public static int 带备忘从顶向下递归穷举法(int capacity, int count, int[] weight, int[] price)
        {
            
            if (capacity == 0 || count == 0)//如果背包没有空间了,或者东西从后往前拿完了
            {
                return 0;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("   ");
            }
            Console.Write(capacity + " " + count);
            n++;
            Console.WriteLine();
            if (results[capacity, count] != 0)
            {
                return results[capacity, count];
            }

            if (weight[count] > capacity)//如果放不下,就放下一个东西
            {
                n++;
                results[capacity, count] = 带备忘从顶向下递归穷举法(capacity, count - 1, weight, price);
                return results[capacity, count];
            }
            else//如果能放下,选择放还是不放
            {
                n++;
                int value1 = 带备忘从顶向下递归穷举法(capacity - weight[count], count - 1, weight, price) + price[count];
                
                int value2 = 带备忘从顶向下递归穷举法(capacity, count - 1, weight, price);
                results[capacity, count] = value1 > value2 ? value1 : value2;
                return results[capacity, count];
            }
        }

        public static int 动态规划法(int capacity, int count, int[] weight, int[] price)
        {
            if (results[capacity,count] != 0)
            {
                return results[capacity, count];
            }
            for (int i = 1; i <= capacity; i++)
            {
                for (int j = 1; j <= count; j++)
                {
                    if (weight[j] > i)
                    {
                        results[i, j] = results[i, j - 1];
                    }
                    else
                    {
                        int max1 = results[i - weight[j], j - 1] + price[j];
                        int max2 = results[i, j - 1];
                        results[i, j] = max1 > max2 ? max1 : max2;
                    }
                }
            }
            return results[capacity, count];
        }

        static int n = 0;
        static int[] weight = new[] { 0, 3, 4, 5, 6, 7, 8 };
        static int[] price = new[] { 0, 4, 5, 6, 7, 8, 9 };
        static int capacity = 8;
        static int count = weight.Length;
        static int[,] results = new int[capacity + 1, count];

        static void Main(string[] args)
        {
            //int[] weight = new[] { 0, 8, 7, 6, 5, 4, 3 };
            //int[] price = new[] { 0, 9, 8, 7, 6, 5, 4 };

            //Console.WriteLine(不带备忘从顶向下递归穷举法(capacity, count - 1, weight, price));
            Console.WriteLine(带备忘从顶向下递归穷举法(capacity, count - 1, weight, price));
            //Console.WriteLine(动态规划法(capacity, count - 1, weight, price));
            Console.ReadKey();
        }
    }
}
