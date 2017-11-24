using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 钢条切割问题
{
    class Program
    {
        //带备忘的自底向上的动态规划
        static int maxValue(int length, Dictionary<int, int> priceList)
        {
            Dictionary<int, int> maxList = new Dictionary<int, int>();//存储不同长度的最大收益
            maxList.Add(0, 0);
            for (int i = 1; i <= length; i++)
            {
                int max = 0;
                for (int j = 1; j <= i; j++)
                {
                    int value1;
                    priceList.TryGetValue(j, out value1);
                    int value2;
                    maxList.TryGetValue(i - j, out value2);
                    if (max < value1 + value2)
                    {
                        max = value1 + value2;
                    }
                }
                maxList.Add(i, max);
            }
            int maxValue;
            maxList.TryGetValue(length, out maxValue);
            return maxValue;
        }

        static void Main(string[] args)
        {
            Dictionary<int, int> priceList = new Dictionary<int, int>();//存储不同长度对应的价格
            priceList.Add(0, 0);
            priceList.Add(1, 1);
            priceList.Add(2, 5);
            priceList.Add(3, 8);
            priceList.Add(4, 9);
            priceList.Add(5, 10);
            priceList.Add(6, 17);
            priceList.Add(7, 17);
            priceList.Add(8, 20);
            priceList.Add(9, 24);
            priceList.Add(10, 30);

            Console.WriteLine(maxValue(4, priceList));
            Console.WriteLine(maxValue(5, priceList));
            Console.WriteLine(maxValue(6, priceList));
            Console.WriteLine(maxValue(7, priceList));
            Console.WriteLine(maxValue(8, priceList));
            Console.WriteLine(maxValue(9, priceList));
            Console.WriteLine(maxValue(10, priceList));
            Console.ReadKey();
        }
    }
}
