using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranManAnh
{
    internal class Session_04_Ex3
    {
        public static void Main()
        {
            Question_01();
            Question_02();
            Question_03();
            Question_04();
            Question_06();
            Question_07();
            Question_08();

            Console.WriteLine("Press any key to stop.");
            Console.ReadKey();
        }

        /// <summary>
        /// 1. Check whether a triangle is Equilateral, Isosceles or Scalene.
        /// </summary>
        public static void Question_01()
        {
            Console.Write("Enter a side of a triangle a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter a side of a triangle b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter a side of a triangle c = ");
            int c = int.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("The triangle is Equilateral");
                }
                else if (a != b && a != c && b != c)
                {
                    Console.WriteLine("The triangle is Scalene");
                }
                else
                {
                    Console.WriteLine("The triangle is Isosceles");
                }
            }
            else
            {
                Console.WriteLine("This is not a triangle.");
            }
        }

        /// <summary>
        /// 2. Read 10 numbers and find their average and sum.
        /// </summary>
        public static void Question_02()
        {
            Console.WriteLine("Enter 10 number: ");
            int sum = 0;
            for (int i = 1; i < 11; i++)
            {
                Console.Write($"Enter number {i} = ");
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }
            double ave = sum / 10;

            Console.WriteLine($"The sum of 10 numbers is {sum}.");
            Console.WriteLine($"The average of 10 numbers is {ave}.");
        }

        /// <summary>
        /// 3. Display the multiplication table of a given integer.
        /// </summary>
        public static void Question_03()
        {
            Console.Write("Enter a number = ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine($"Multiplication Table for {a} is: ");
            for (int i = 1; i <= 10; i++)
            {
                int result = a * i;
                Console.WriteLine($"{a} * {i} = {result}");
            }
        }

        /// <summary>
        /// 4. Display a pattern like triangles with a number.
        /// </summary>
        public static void Question_04()
        {
            Console.Write("Enter the number of rows for the triangle = ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("The 1st triangle pattern:");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            Console.WriteLine("The 2nd triangle pattern:");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("The 3rd triangle pattern:");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write("  ");
                }
                int num = 1;
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// 6. Display the n terms of harmonic series and their sum.
        /// </summary>
        public static void Question_06()
        {
            Console.Write("Enter the number of terms for the harmonic series = ");
            int a = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine($"The harmonic = 1/{i}");
                sum += 1.0 / i;
            }
            Console.WriteLine($"The sum of the harmonic series = {sum}");
        }

        /// <summary>
        /// 7. Find the ‘perfect’ numbers within a given number range.
        /// </summary>
        public static void Question_07()
        {
            Console.Write("Enter the lower limit of the range = ");
            int low = int.Parse(Console.ReadLine());
            Console.Write("Enter the upper limit of the range = ");
            int up = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int per = low; per <= up; per++)
            {
                for (int j = 1; j <= per / 2; j++)
                {
                    if (per % j == 0)
                    {
                        sum += j;
                    }
                }
                if (sum == per && per != 0)
                {
                    Console.WriteLine($"The perfect number is {per}.");
                }
                else
                {
                    Console.WriteLine("There is no perfect number in this range.");
                }
            }
        }

        /// <summary>
        /// 8. Write a program to determine whether a given number is prime or not.
        /// </summary>
        public static void Question_08()
        {
            do
            {
                Console.Write("Enter number a (a>1) = ");
                int a = int.Parse(Console.ReadLine());

                if (a > 1)
                {
                    int count = 0;
                    for (int i = 2; i <= Math.Sqrt(a); i++)
                    {
                        if (a % i == 0)
                        {
                            count++;
                            break;
                        }
                    }
                    if (count == 0)
                    {
                        Console.WriteLine($"{a} is a prime.");
                    }
                    else
                    {
                        Console.WriteLine($"{a} is not a prime.");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("The number must be a natural number!!!");
                }
            } while (true);
        }
    }
}
