using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 最大子列和
{
    /// <summary>
    /// 无法处理全负数数组
    /// </summary>
    class Program
    {
        //最笨的暴力求解算法
        public static void Method0(int[] a)
        {
            int n = a.Length;
            int sum = 0;
            int maxSum = 0;
            int low = 0;
            int high = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    sum = 0;
                    for (int k = i; k <= j; k++)
                    {
                        sum += a[k];
                    }
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        low = i;
                        high = j;
                    }
                }
            }
            Console.WriteLine("最大子列和={0}\t下标从{1}到{2}", maxSum, low, high);
        }
        //稍微聪明一点的暴力求解算法
        public static void Method1(int[] a)
        {
            int n = a.Length;
            int sum = 0;
            int maxSum = 0;
            int low = 0;
            int high = 0;
            for (int i = 0; i < n; i++)
            {
                sum = 0;
                for (int j = i; j < n; j++)
                {
                    sum += a[j];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        low = i;
                        high = j;
                    }
                }
            }
            Console.WriteLine("最大子列和={0}\t下标从{1}到{2}", maxSum, low, high);
        }
        //最快的算法
        public static void Method2(int[] a)
        {
            int n = a.Length;
            int sum = 0;
            int maxSum = 0;
            int low = 0;
            int high = 0;
            for (int i = 0; i < n; i++)
            {
                sum += a[i];
                if (sum <= 0)        //如果<=0,求出的子列为最右的子列，如果<0,求出的子列为最长的子列，无法取得最早的子列
                {
                    sum = 0;
                    low = high = i + 1;
                    continue;
                }
                if (sum >= maxSum)
                {
                    maxSum = sum;
                    high = i;
                }
            }
            Console.WriteLine("最大子列和={0}\t下标从{1}到{2}", maxSum, low, high);
        }
        //分治算法
        public static int Method3(int[] a, int low, int high)
        {
            if (low == high)
            {
                return a[low];
            }
            int index = (low + high) / 2;
            int max = 0;
            int left = 0;
            int right = 0;
            int middle = 0;
            left = Method3(a, low, index);
            right = Method3(a, index + 1, high);
            middle = Method3Unit(a, low, high);
            max = Math.Max(Math.Max(left, right), middle);

            return max;
        }

        public static int Method3Unit(int[] a, int low, int high)
        {
            int index = (low + high) / 2;
            int sum = 0;
            int leftMax = 0;
            int rightMax = 0;
            for (int i = index; i >= low; i--)
            {
                sum += a[i];
                if (sum > leftMax)
                {
                    leftMax = sum;
                }
            }
            sum = 0;
            for (int i = index + 1; i <= high; i++)
            {
                sum += a[i];
                if (sum > rightMax)
                {
                    rightMax = sum;
                }
            }
            return leftMax + rightMax;
        }

        static void Main(string[] args)
        {
            int[] a0 = new[] { 1, 1, 1, -1, -1, 3 };
            int[] a1 = new[] { -2, -3, 1 };
            int[] a2 = new[] { 1, 1, 1, -1, -1, -1, 3, -2 };
            int[] a3 = new[] { -2, 11, -4, 13, -5, -2 };
            Method1(a0);
            Method1(a1);
            Method1(a2);
            Method1(a3);
            Method2(a0);
            Method2(a1);
            Method2(a2);
            Method2(a3);
            Console.WriteLine(Method3(a0, 0, a0.Length - 1));
            Console.WriteLine(Method3(a1, 0, a1.Length - 1));
            Console.WriteLine(Method3(a2, 0, a2.Length - 1));
            Console.WriteLine(Method3(a3, 0, a3.Length - 1));

            Console.ReadKey();
        }
    }
}
