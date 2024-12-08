using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作業2024_12_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyHomeWork01();
            //Console.ReadLine();

            MyHomeWork02();
            Console.ReadLine();
        }
        static void MyHomeWork01()
        {
            int[] a = new int[10];
            float[] b = new float[8];
            double[] c = new double[4];
            string[] d = new string[5];

            int_wrint(a);
            float_wrint(b);
            double_wrint(c);
            string_wrint(d);
        }
        static void int_wrint(int[] a)//整數陣列輸入資料、平均和輸出
        {
            Console.WriteLine("請輸入10個整數");
            for (int i = 0; i < 10; i++)
            {
                Console.Write((i + 1) + ":\t");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            double sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("第" + (i + 1) + "個數字為:\t");
                Console.WriteLine(a[i]);
                sum += a[i];
            }
            Console.WriteLine("平均為:\t" + (sum / 10));
        }
        static void float_wrint(float[] a)//浮點數數陣列輸入資料、平均和輸出
        {
            Console.WriteLine("請輸入8個浮點數");
            for (int i = 0; i < 8; i++)
            {
                Console.Write((i + 1) + ":\t");
                a[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            double sum = 0;
            for (int i = 0; i < 8; i++)
            {
                Console.Write("第" + (i + 1) + "個數字為:\t");
                Console.WriteLine(a[i]);
                sum += a[i];
            }
            Console.WriteLine("平均為:\t" + (sum / 8));
        }
        static void double_wrint(double[] a)//倍精確度數陣列輸入資料、平均和輸出
        {
            Console.WriteLine("請輸入4個倍精確度數");
            for (int i = 0; i < 4; i++)
            {
                Console.Write((i + 1) + ":\t");
                a[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            double sum = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.Write("第" + (i + 1) + "個數字為:\t");
                Console.WriteLine(a[i]);
                sum += a[i];
            }
            Console.WriteLine("平均為:\t" + (sum / 4));
        }
        static void string_wrint(string[] a)//字串陣列輸入資料和輸出
        {
            string temp;
            Console.WriteLine("請輸入5個字串");
            for (int i = 0; i < 5; i++)
            {
                Console.Write((i + 1) + ":\t");
                temp = Console.ReadLine();
                a[i] = temp;
            }
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("第" + (i + 1) + "個字為:\t");
                Console.WriteLine(a[i]);
            }
        }

        static void int_wrint_02(int[] a)//整數陣列輸入資料、平均和輸出
        {
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("第" + (i + 1) + "個數字為:\t");
                Console.WriteLine(a[i]);
                sum += a[i];
            }
            Console.WriteLine("平均為:\t" + (sum / a.Length));
            Console.WriteLine();
        }
        static void float_wrint_02(float[] a)//浮點數數陣列輸入資料、平均和輸出
        { 
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("第" + (i + 1) + "個數字為:\t");
                Console.WriteLine(a[i]);
                sum += a[i];
            }
            Console.WriteLine("平均為:\t" + (sum / a.Length));
            Console.WriteLine();
        }
        static void double_wrint_02(double[] a)//倍精確度數陣列輸入資料、平均和輸出
        {
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("第" + (i + 1) + "個數字為:\t");
                Console.WriteLine(a[i]);
                sum += a[i];
            }
            Console.WriteLine("平均為:\t" + (sum / a.Length));
            Console.WriteLine();
        }
        static void string_wrint_02(string[] a)//字串陣列輸入資料和輸出
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("第" + (i + 1) + "個字為:\t");
                Console.WriteLine(a[i]);
            }
            Console.WriteLine();
        }
        static void MyHomeWork02()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            float[] b = {1,2,2,3,3,4,4,5,5,6 };
            double[] c = { 1, 22, 2,33,3,44,4,55,5,66 };
            string[] d = { "王小明", "陳大明", "李小英", "張小美", "陳不良 "};
            int_wrint_02(a);
            float_wrint_02(b);
            double_wrint_02(c);
            string_wrint_02(d);
        }
    }
}
