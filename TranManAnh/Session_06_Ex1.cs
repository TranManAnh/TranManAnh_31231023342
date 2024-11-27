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

        
        /// <summary>
        /// Enter item values for this array.
        /// </summary>
        /// <param name="a"></param>
        static void NhapMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Nhap phan tu thu #{i}: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        /// <summary>
        /// Print the array to screen.
        /// </summary>
        /// <param name="a"></param>
        static void InMang(int[] a)
        {
            foreach (int item in a)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Write a function that increase each item of the array by adding it with 2.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="val"></param>
        static void Increase2(int[] a, int val)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] += val;
            }
        }

        /// <summary>
        /// Write a function that calculate the sum of all items of the array.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static int Sum(int[] a)
        {
            int s = 0;
            foreach (int item in a)
            {
                s += item;
            }
            return s;
        }

        /// <summary>
        /// Write a function that calculate the average of all items of the array.
        /// </summary>
        /// <param name="a"></param>
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
