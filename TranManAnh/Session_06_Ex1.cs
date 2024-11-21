using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranManAnh
{
    internal class Session_06_Ex1
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            NhapMang(a);
            Console.Write("Mang: "); InMang(a);
            Increase2(a, 2);
            Console.Write("Gia tri mang tang len 2: "); InMang(a);
            Console.Write("Tong cac gia tri cua mang: "); Sum(a);
            int s = Sum(a);
            Console.WriteLine($"Tong cac gia tri cua mang: {s}.");
            Console.Write("Trung binh cac gia tri cua mang: "); Average(a);

            Console.WriteLine("Press any key to stop.");
            Console.ReadKey();
        }

        static void NhapMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Nhap phan tu thu #{i}: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        static void InMang(int[] a)
        {
            foreach (int item in a)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }

        static void Increase2(int[] a, int val)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] += val;
            }
        }

        static int Sum(int[] a)
        {
            int s = 0;
            foreach (int item in a)
            {
                s += item;
            }
            return s;
        }

        static void Average(int[] a)
        {
            int ave = 0;
            int sum = 0;
            foreach (int item in a)
            {
                sum += item;
                ave = sum / a.Length;
            }
            Console.WriteLine(ave);
        }
    }
}
