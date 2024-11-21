using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranManAnh
{
    internal class Session_02
    {
        public static void Main()
        {
            Question_01();
            Question_02();
            Question_03();
            Question_04();
            Question_05();
            Question_06();
            Question_07();
            Question_08();
            Question_09();
            Question_10();

            Console.WriteLine("Press any key to stop.");
            Console.ReadKey();
        }

        /// <summary>
        /// 1. Add / Sum Two Numbers.
        /// </summary>
        public static void Question_01()
        {
            Console.Write("Enter number a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter number b = ");
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            int product = a * b;

            Console.WriteLine($"{a} + {b} = {sum}");
            Console.WriteLine($"{a} * {b} = {product}");
        }

        /// <summary>
        /// 2. Swap Values of Two Variables.
        /// </summary>
        public static void Question_02()
        {
            Console.Write("Enter number a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter number b = ");
            int b = int.Parse(Console.ReadLine());
            int swap_a = b;
            int swap_b = a;

            Console.WriteLine($"The swapping value of a = {swap_a}");
            Console.WriteLine($"The swapping value of b = {swap_b}");
        }

        /// <summary>
        /// 3. Multiply two Floating Point Numbers.
        /// </summary>
        public static void Question_03()
        {
            Console.Write("Enter number a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter number b = ");
            double b = double.Parse(Console.ReadLine());
            double product = a * b;

            Console.WriteLine($"{a} * {b} = {product}");
        }

        /// <summary>
        /// 4. Convert feet to meter.
        /// </summary>
        public static void Question_04()
        {
            Console.Write("Enter value a = ");
            double a = double.Parse(Console.ReadLine());
            double b = a * 0.3048;

            Console.WriteLine($"Converting the value of a from feet to meter = {b}");
        }

        /// <summary>
        /// 5. Convert Celsius to Fahrenheit and vice versa.
        /// </summary>
        public static void Question_05()
        {
            Console.Write("Enter value a = ");
            double a = double.Parse(Console.ReadLine());
            double b = a * 9 / 5 + 32;
            double c = b * 5 / 9 - 32;

            Console.WriteLine($"Converting the value of a from Celsius to Fahrenheit = {b}");
            Console.WriteLine($"Converting the value of a from Fahrenheit to Celsius = {c}");
        }

        /// <summary>
        /// 6. Find the Size of data types.
        /// </summary>
        public static void Question_06()
        {
            Console.Write("Enter a string = ");
            double a = double.Parse(Console.ReadLine());
            double size = sizeof(double);

            Console.WriteLine($"The Size of data = {size}");
        }

        /// <summary>
        /// 7. Print ASCII Value.
        /// </summary>
        public static void Question_07()
        {
            Console.Write("Enter a value = ");
            int userInput = Console.Read();

            Console.WriteLine("ASCII value = {0}", userInput);
        }

        /// <summary>
        /// 8. Calculate Area of Circle.
        /// </summary>
        public static void Question_08()
        {
            Console.Write("Enter radius = ");
            double a = double.Parse(Console.ReadLine());
            double PI = 3.14;
            double b = PI * a * a;

            Console.WriteLine($"Area of Circle = {b}");
        }

        /// <summary>
        /// 9. Calculate Area of Square.
        /// </summary>
        public static void Question_09()
        {
            Console.Write("Enter side = ");
            double a = double.Parse(Console.ReadLine());
            double b = a * a;

            Console.WriteLine($"Area of Square = {b}");
        }

        /// <summary>
        /// 10. Convert days to years, weeks and days.
        /// </summary>
        public static void Question_10()
        {
            Console.Write("Enter the numbers of day = ");
            int days = int.Parse(Console.ReadLine());
            int years = days / 365;
            int day_w = days - years * 365;
            int weeks = day_w / 7;
            int d = day_w % 7;

            Console.WriteLine($"{days} is approximately equal to {years} years, {weeks} weeks and {d} days. ");
        }
    }
}
