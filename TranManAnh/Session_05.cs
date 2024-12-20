using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranManAnh
{
    internal class Session_05
    {
        public static void Main()
        {
            Question_01();
            Question_02();
            Question_03();
            Question_04();
            Question_05();
            Question_06();

            Console.WriteLine("Press any key to stop.");
            Console.ReadKey();
        }

        /// <summary>
        /// 1. Find the maximum of three numbers.
        /// </summary>
        public static void Question_01()
        {
            int max2nums(int x, int y)
            {
                return x > y ? x : y;
            }

            int max3nums(int x, int y, int z)
            {
                return max2nums(x, max2nums(y, z));
            }

            Console.Write("Enter number a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter number b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter number c = ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"Max of 3 numbers {a}, {b}, {c} is {max3nums(a, b, c)}.");
        }

        /// <summary>
        /// 2. Calculate the factorial of a number (a non-negative integer). The function accepts the number as an argument.
        /// </summary>
        public static void Question_02()
        {
            long fac(int x)
            {
                if (x < 0)
                {
                    x = -x;
                }
                return x == 0 ? 1 : fac(x - 1) * x;
            }

            Console.Write("Enter number a = ");
            int a = int.Parse(Console.ReadLine());
            long result = fac(a);
            Console.WriteLine($"The factorial of {a} is {result}.");
        }

        /// <summary>
        /// 3. Takes a number as a parameter and checks whether the number is prime or not.
        /// </summary>
        public static void Question_03()
        {
            bool prime(int x)
            {
                if (x < 2)
                    return false;
                for (int i = 2; i * i <= x; i++)
                    if (x % i == 0) return false;
                return true;
            }

            Console.Write("Enter number a = ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine($"{a} is " + (prime(a) ? "a prime number." : "not a prime number."));
        }

        /// <summary>
        /// 4. Print </br>
        /// a. all prime numbers that less than a number (enter prompt keyboard). </br>
        /// b. the first N prime numbers. </br>
        /// </summary>
        public static void Question_04()
        {
            bool prime(int x)
            {
                if (x < 2) return false;
                for (int i = 2; i <= Math.Sqrt(x); i++)
                {
                    if (x % i == 0) return false;
                }
                return true;
            }

            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write($"Prime numbers less than {num}: ");
            bool check = false; 
            for (int i = 2; i < num; i++)
            {
                if (prime(i))
                {
                    Console.Write($"{i}, ");
                    check = true;
                }
            }
            if (!check)
                Console.WriteLine($"There is no prime number less than {num}");
            Console.WriteLine();

            Console.Write("Enter the number of first prime numbers (N): ");
            int n = int.Parse(Console.ReadLine());
            Console.Write($"The first {n} prime numbers are: ");
            int count = 0, current = 2; 
            while (count < n)
            {
                if (prime(current))
                {
                    Console.Write($"{current}, ");
                    count++;
                }
                current++;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// 5. Check whether a number is "Perfect" or not. Then print all perfect number that less than 1000.
        /// </summary>
        public static void Question_05()
        {
            bool perfect(int x)
            {
                if (x < 2) return false;
                int sum = 0;
                for (int i = 1; i <= x / 2; i++) 
                {
                    if (x % i == 0) 
                    {
                        sum += i; 
                    }
                }
                return sum == x;
            }
 
            Console.Write("The perfect number that less than 1000: ");
            for (int i = 0; i < 1000; i++)
            {
                if (perfect(i))
                    Console.Write($"{i}, ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// 6. Check whether a string is a pangram or not.
        /// </summary>
        public static void Question_06()
        {
            bool Pangram(string str)
            {
                str = str.ToLower();
                bool[] alphabet = new bool[26];
                foreach (char c in str)
                {
                    if (c >= 'a' && c <= 'z')
                    {
                        alphabet[c - 'a'] = true;
                    }
                }
                foreach (bool letter in alphabet)
                {
                    if (!letter) return false;
                }
                return true;
            }

            Console.WriteLine("Enter a string to check if it's a pangram:");
            string input = Console.ReadLine();

            if (Pangram(input))
            {
                Console.WriteLine("The string is a pangram.");
            }
            else
            {
                Console.WriteLine("The string is not a pangram.");
            }
        }
    }
}
